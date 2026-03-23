using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    /*feature that helps us know who is the most active friend in the FaceBook's friends List, comments and likes this users post and photos*/
    class FriendsAnalyzer
    {
        private readonly User r_LoggedInUser;
        private Dictionary<User, int> m_FriendsPoints;
        private bool m_IsAnalyzed;

        public FriendsAnalyzer(User i_LoggedInUser)
        {
            this.r_LoggedInUser = i_LoggedInUser;
            m_FriendsPoints = new Dictionary<User, int>();
            m_IsAnalyzed = false;

            initializeFriendsPointDictionary();
        }

        public bool IsAnalyzed
        {
            get { return m_IsAnalyzed; }
        }

        public void ResetAnalyzer()
        {
            m_IsAnalyzed = false;
            m_FriendsPoints.Clear();
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

            m_IsAnalyzed = true;
        }

        private void calculateFriendsInteractions(IEnumerable<PostedItem> i_ItemsToScan)
        {
            foreach (PostedItem postedItem in i_ItemsToScan)
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

        public List<User> GetActiveFriends(int i_friendsAmount)
        {
            if (!m_IsAnalyzed)
            {
                AnalyzeInteractions();
            }

            List<KeyValuePair<User, int>> friendsPointList = new List<KeyValuePair<User, int>>(m_FriendsPoints);
            friendsPointList.Sort((firstFriend, secondFriend) => secondFriend.Value.CompareTo(firstFriend.Value));

            List<User> topActiveFriends = new List<User>();

            for (int i = 0; i < i_friendsAmount && i< friendsPointList.Count; i++)
            {
                topActiveFriends.Add(friendsPointList[i].Key);
            }

            return topActiveFriends;
        }
    }
}
