using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
	class FriendsAnalyzer
	{
		private readonly User r_LoggedInUser;
		private Dictionary<User, int> m_FriendsPoints;
		private bool m_IsAnalyzed;
		private List<DummyFriend> m_DummyActiveFriends;
		private List<DummyFriend> m_DummyGhostFriends;

		public bool UsingDummyData { get; private set; } = false;

		public bool HasRealFriends
		{
			get
			{
				return m_FriendsPoints.Count > 0;
			}
		}

		public FriendsAnalyzer(User i_LoggedInUser)
		{
			this.r_LoggedInUser = i_LoggedInUser;
			m_FriendsPoints = new Dictionary<User, int>();
			m_IsAnalyzed = false;
			m_DummyActiveFriends = new List<DummyFriend>();
			m_DummyGhostFriends = new List<DummyFriend>();

			initializeFriendsPointDictionary();
		}

		public bool IsAnalyzed
		{
			get
			{
				return m_IsAnalyzed;
			}
		}

		public void ResetAnalyzer()
		{
			m_IsAnalyzed = false;
			UsingDummyData = false;
			m_FriendsPoints.Clear();
			m_DummyActiveFriends.Clear();
			m_DummyGhostFriends.Clear();
			initializeFriendsPointDictionary();
		}

		private void initializeFriendsPointDictionary()
		{
			if (r_LoggedInUser.Friends != null)
			{
				foreach (User friend in r_LoggedInUser.Friends)
				{
					m_FriendsPoints.Add(friend, 0);
				}
			}
		}

		public void AnalyzeInteractions()
		{
			if (m_IsAnalyzed)
			{
				return;
			}

			try
			{
				if (r_LoggedInUser.Posts != null)
				{
					calculateFriendsInteractions(r_LoggedInUser.Posts);
				}

				if (r_LoggedInUser.Albums != null)
				{
					foreach (Album photoAlbum in r_LoggedInUser.Albums)
					{
						if (photoAlbum.Photos != null)
						{
							calculateFriendsInteractions(photoAlbum.Photos);
						}
					}
				}
			}
			catch (Exception)
			{
				if (!UsingDummyData)
				{
					UsingDummyData = true;
					injectDummyData();
				}
			}

			if (m_FriendsPoints.Count == 0 && !UsingDummyData)
			{
				UsingDummyData = true;
				injectDummyData();
			}

			m_IsAnalyzed = true;
		}

		private void calculateFriendsInteractions(IEnumerable<PostedItem> i_ItemsToScan)
		{
			bool apiBlocked = false;

			foreach (PostedItem postedItem in i_ItemsToScan)
			{
				try
				{
					if (postedItem.LikedBy != null)
					{
						foreach (User likerUser in postedItem.LikedBy)
						{
							if (m_FriendsPoints.ContainsKey(likerUser))
							{
								m_FriendsPoints[likerUser] += 1;
							}
						}
					}

					if (postedItem.Comments != null)
					{
						foreach (Comment comment in postedItem.Comments)
						{
							User commentUser = comment.From;
							if (commentUser != null && m_FriendsPoints.ContainsKey(commentUser))
							{
								m_FriendsPoints[commentUser] += 1;
							}
						}
					}
				}
				catch (Exception)
				{
					apiBlocked = true;
					break;
				}
			}

			if (apiBlocked && !UsingDummyData)
			{
				UsingDummyData = true;
				injectDummyData();
			}
		}

		public List<User> GetGhostFriends()
		{
			if (!m_IsAnalyzed)
			{
				AnalyzeInteractions();
			}

			List<User> inactiveGhostFriends = new List<User>();

			foreach (KeyValuePair<User, int> friend in m_FriendsPoints)
			{
				if (friend.Value == 0)
				{
					inactiveGhostFriends.Add(friend.Key);
				}
			}

			return inactiveGhostFriends;
		}

		public List<DummyFriend> GetDummyGhostFriends()
		{
			if (!m_IsAnalyzed)
			{
				AnalyzeInteractions();
			}

			return m_DummyGhostFriends;
		}

		public List<User> GetActiveFriends(int i_FriendsAmount)
		{
			if (!m_IsAnalyzed)
			{
				AnalyzeInteractions();
			}

			List<KeyValuePair<User, int>> friendsPointList = new List<KeyValuePair<User, int>>(m_FriendsPoints);
			friendsPointList.Sort(delegate(KeyValuePair<User, int> firstFriend, KeyValuePair<User, int> secondFriend)
			{
				return secondFriend.Value.CompareTo(firstFriend.Value);
			});

			List<User> topActiveFriends = new List<User>();

			for (int i = 0; i < i_FriendsAmount && i < friendsPointList.Count; i++)
			{
				topActiveFriends.Add(friendsPointList[i].Key);
			}

			return topActiveFriends;
		}

		public List<DummyFriend> GetDummyActiveFriends(int i_FriendsAmount)
		{
			if (!m_IsAnalyzed)
			{
				AnalyzeInteractions();
			}

			List<DummyFriend> result = new List<DummyFriend>();
			int count = Math.Min(i_FriendsAmount, m_DummyActiveFriends.Count);

			for (int i = 0; i < count; i++)
			{
				result.Add(m_DummyActiveFriends[i]);
			}

			return result;
		}

		private void injectDummyData()
		{
			Random random = new Random();

			if (m_FriendsPoints.Count > 0)
			{
				List<User> friendsList = new List<User>(m_FriendsPoints.Keys);

				foreach (User friend in friendsList)
				{
					if (random.Next(1, 100) > 30)
					{
						m_FriendsPoints[friend] += random.Next(1, 50);
					}
				}
			}
			else
			{
				generateDummyFriends(random);
			}
		}

		private void generateDummyFriends(Random i_Random)
		{
			string[] activeNames = new string[]
			{
				"Yael Cohen", "Omer Levi", "Noa Mizrahi", "Itai Peretz",
				"Shira Friedman", "Alon Katz", "Maya Goldberg", "Eitan Shapira",
				"Tal Avraham", "Lior Rosenberg", "Dana Ben-David", "Noam Golan",
				"Roni Schwartz", "Ori Blum", "Hila Stern", "Yonatan Klein",
				"Inbar Levy", "Ido Bar", "Tamar Wolf", "Rotem Fischer",
				"Amit Dahan", "Gal Hadid", "Yarin Azulay", "Sapir Ohana",
				"Ofir Ben-Ami", "Tomer Malka", "Noy Elbaz", "Yuval Shaked",
				"Matan Zohar", "Keren Nahmias"
			};

			string[] ghostNames = new string[]
			{
				"David Silberstein", "Rachel Gutman", "Moshe Abramov",
				"Sivan Harari", "Elad Pinto", "Michal Yosef",
				"Benny Tsarfati", "Liora Ashkenazi", "Nadav Bitton",
				"Ayelet Rosen", "Gil Hasson", "Efrat Koren"
			};

			List<KeyValuePair<string, int>> activeFriendScores = new List<KeyValuePair<string, int>>();

			foreach (string name in activeNames)
			{
				int score = i_Random.Next(5, 80);
				activeFriendScores.Add(new KeyValuePair<string, int>(name, score));
			}

			foreach (string name in ghostNames)
			{
				activeFriendScores.Add(new KeyValuePair<string, int>(name, 0));
			}

			activeFriendScores.Sort(delegate(KeyValuePair<string, int> first, KeyValuePair<string, int> second)
			{
				return second.Value.CompareTo(first.Value);
			});

			m_DummyActiveFriends.Clear();
			m_DummyGhostFriends.Clear();

			foreach (KeyValuePair<string, int> friendScore in activeFriendScores)
			{
				if (friendScore.Value == 0)
				{
					m_DummyGhostFriends.Add(new DummyFriend(friendScore.Key, friendScore.Value));
				}
				else
				{
					m_DummyActiveFriends.Add(new DummyFriend(friendScore.Key, friendScore.Value));
				}
			}
		}
	}
}