using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			FacebookWrapper.FacebookService.s_CollectionLimit = 200;
		}

		private User m_LoggedInUser;
		private FacebookWrapper.LoginResult m_LoginResult;
		private FriendsAnalyzer m_FriendAnalyzer;
		private PhotoArchiver m_PhotoArchiver;

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Clipboard.SetText("design.patterns");

			if (m_LoginResult == null)
			{
				login();
			}
		}

		private void login()
		{
			m_LoginResult = FacebookService.Login(
				textBoxAppID.Text,
				"email",
				"public_profile",
				"user_photos", 
				"user_posts", 
				"user_friends" 
				);

			if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && m_LoginResult.LoggedInUser != null)
			{
				afterLogin();
			}
		}

		private void buttonConnectAsDesig_Click(object sender, EventArgs e)
		{
			try
			{
				m_LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBQ89SIPgqvUNRPYwshVbzNFtykREi0CbEUsssHsY0ceBnLKHx9uOtmH5ClGksE6EzWZBRylGglQToWaaqV2QWsOcus79byyncz93TDesQvzX2pv2kllZA8mEg5iDMiYktoptWXySLSrS4Y2ATeDyEEFsJLZBmyshcy464jImETOhjyGYYKxJDZBWhxzRWLsRZApkMmJiEG742LGjEq486o9RgdhFrkuTLT0xup5efuMsJNL8ENsJqZC");

				afterLogin();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Login Failed");
			}
		}

		private void afterLogin()
		{
			m_LoggedInUser = m_LoginResult.LoggedInUser;
			
			m_PhotoArchiver = new PhotoArchiver(m_LoggedInUser);

			buttonLogin.Text = string.Format("Logged in as {0}", m_LoginResult.LoggedInUser.Name);
			buttonLogin.BackColor = Color.LightGreen;
			buttonLogin.Enabled = false;
			buttonLogout.Enabled = true;

			pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
			this.Text = string.Format("Logged in as {0}", m_LoggedInUser.Name);

			m_FriendAnalyzer = new FriendsAnalyzer(m_LoggedInUser); 
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
			buttonLogin.BackColor = buttonLogout.BackColor;
			m_LoginResult = null;
			buttonLogin.Enabled = true;
			buttonLogout.Enabled = false;
			m_FriendAnalyzer = null; 
			pictureBoxProfile.Image = null;
		}

		private void buttonFindActiveFriends_Click(object sender, EventArgs e)
		{
			if (m_FriendAnalyzer == null)
			{
				MessageBox.Show("Please login first");
				return;
			}

			if (!m_FriendAnalyzer.IsAnalyzed)
			{
				labelStatus.Text = "Status: Analyzing Facebook data...";
				labelStatus.ForeColor = Color.AliceBlue;
			}
			else
			{
				labelStatus.Text = "Status: Fetching data from memory...";
				labelStatus.ForeColor = Color.Green;
			}

			buttonFindActiveFriends.Enabled = false;
			listBoxFriends.Items.Clear();

			new System.Threading.Thread(delegate()
			{
				try
				{
					m_FriendAnalyzer.AnalyzeInteractions();

					if (m_FriendAnalyzer.UsingDummyData && !m_FriendAnalyzer.HasRealFriends)
					{
						List<DummyFriend> dummyActive = m_FriendAnalyzer.GetDummyActiveFriends(10);

						this.Invoke(new Action(delegate()
						{
							MessageBox.Show("The Facebook API currently restricts access to friends, likes and comments.\nDisplaying generated Dummy Data for demonstration purposes.",
											"API Limitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}));

						listBoxFriends.Invoke(new Action(delegate()
						{
							listBoxFriends.DisplayMember = "";
							foreach (DummyFriend friend in dummyActive)
							{
								listBoxFriends.Items.Add(friend);
							}

							labelStatus.Text = "Status: Analysis Complete (Dummy Data)";
							labelStatus.ForeColor = Color.Green;
						}));
					}
					else
					{
						List<User> topActiveFriends = m_FriendAnalyzer.GetActiveFriends(10);

						if (m_FriendAnalyzer.UsingDummyData)
						{
							this.Invoke(new Action(delegate()
							{
								MessageBox.Show("The Facebook API currently restricts access to likes and comments.\nDisplaying generated Dummy Data for demonstration purposes.",
												"API Limitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}));
						}

						listBoxFriends.Invoke(new Action(delegate()
						{
							listBoxFriends.DisplayMember = "Name";
							foreach (User friend in topActiveFriends)
							{
								listBoxFriends.Items.Add(friend);
							}

							labelStatus.Text = "Status: Analysis Complete";
							labelStatus.ForeColor = Color.Green;
						}));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
				finally
				{
					buttonFindActiveFriends.Invoke(new Action(delegate()
					{
						buttonFindActiveFriends.Enabled = true;
					}));
				}
			}).Start();
		}

		private void buttonFindGhostFriends_Click(object sender, EventArgs e)
		{
			if (m_FriendAnalyzer == null)
			{
				return;
			}

			labelStatus.Text = "Status: Searching for ghosts...";
			labelStatus.ForeColor = Color.Blue;
			buttonFindGhostFriends.Enabled = false;
			listBoxFriends.Items.Clear();

			new System.Threading.Thread(delegate()
			{
				try
				{
					m_FriendAnalyzer.AnalyzeInteractions();

					if (m_FriendAnalyzer.UsingDummyData && !m_FriendAnalyzer.HasRealFriends)
					{
						List<DummyFriend> dummyGhosts = m_FriendAnalyzer.GetDummyGhostFriends();

						listBoxFriends.Invoke(new Action(delegate()
						{
							listBoxFriends.DisplayMember = "Name";
							foreach (DummyFriend ghost in dummyGhosts)
							{
								listBoxFriends.Items.Add(ghost);
							}

							labelStatus.Text = "Status: Found " + dummyGhosts.Count + " ghosts (Dummy Data).";
							labelStatus.ForeColor = Color.Green;
						}));
					}
					else
					{
						List<User> ghostFriends = m_FriendAnalyzer.GetGhostFriends();

						listBoxFriends.Invoke(new Action(delegate()
						{
							listBoxFriends.DisplayMember = "Name";
							foreach (User friend in ghostFriends)
							{
								listBoxFriends.Items.Add(friend);
							}

							labelStatus.Text = "Status: Found " + ghostFriends.Count + " ghosts.";
							labelStatus.ForeColor = Color.Green;
						}));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
				finally
				{
					buttonFindGhostFriends.Invoke(new Action(delegate()
					{
						buttonFindGhostFriends.Enabled = true;
					}));
				}
			}).Start();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			if (m_FriendAnalyzer != null)
			{
				m_FriendAnalyzer.ResetAnalyzer();
				listBoxFriends.Items.Clear();
				pictureBoxFriend.Image = null;

				labelStatus.Text = "Status: Waiting for scan";
				labelStatus.ForeColor = Color.Black;

				MessageBox.Show("Data reset successfully!");
			}
		}

		private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxFriends.SelectedItem is User selectedFriend)
			{
				if (selectedFriend.PictureNormalURL != null)
				{
					pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
				}
				else
				{
					pictureBoxFriend.Image = null;
				}
			}
		}

		private void buttonLoadAlbums_Click(object sender, EventArgs e)
		{
			if (m_LoggedInUser == null)
			{
				MessageBox.Show("Please login first.");
				return;
			}

			listBoxAlbums.Items.Clear();
			listBoxAlbums.DisplayMember = "Name";

			foreach (Album album in m_LoggedInUser.Albums)
			{
				listBoxAlbums.Items.Add(album);
			}
		}

		private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxAlbums.SelectedItem is Album selectedAlbum)
			{
				if (selectedAlbum.PictureAlbumURL != null)
				{
					pictureBoxAlbumCover.LoadAsync(selectedAlbum.PictureAlbumURL);
				}
				else
				{
					pictureBoxAlbumCover.Image = null;
				}
			}
		}

		private void buttonDownloadAlbum_Click(object sender, EventArgs e)
		{
			if (listBoxAlbums.SelectedItem == null)
			{
				MessageBox.Show("Please select an album first");
				return;
			}

			Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
			FolderBrowserDialog folderDialog = new FolderBrowserDialog();

			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				string destinationPath = folderDialog.SelectedPath;
				buttonDownloadAlbum.Enabled = false;

				new System.Threading.Thread(delegate()
				{
					try
					{
						List<Photo> photosToDownload = new List<Photo>();
						foreach (Photo photo in selectedAlbum.Photos)
						{
							photosToDownload.Add(photo);
						}

						m_PhotoArchiver.DownloadPhotos(photosToDownload, destinationPath);

						this.Invoke(new Action(delegate()
						{
							MessageBox.Show("Album downloaded successfully!");
						}));
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
					}
					finally
					{
						buttonDownloadAlbum.Invoke(new Action(delegate()
						{
							buttonDownloadAlbum.Enabled = true;
						}));
					}
				}).Start();
			}
		}

		private void buttonMoveToArchive_Click(object sender, EventArgs e)
		{
			if (m_PhotoArchiver == null)
			{
				return;
			}

			int yearsToArchive = (int)numericUpDownYears.Value;
			List<Photo> oldPhotos = m_PhotoArchiver.GetPhotosOlderThan(yearsToArchive);

			if (oldPhotos.Count == 0)
			{
				MessageBox.Show("Did not find any photos older than " + yearsToArchive + " years.");
				return;
			}

			FolderBrowserDialog folderDialog = new FolderBrowserDialog();

			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				string destinationPath = folderDialog.SelectedPath;
				buttonMoveToArchive.Enabled = false;

				new System.Threading.Thread(delegate()
				{
					try
					{
						m_PhotoArchiver.DownloadPhotos(oldPhotos, destinationPath);

						this.Invoke(new Action(delegate()
						{
							MessageBox.Show("Finished archiving " + oldPhotos.Count + " photos!");
						}));
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
					}
					finally
					{
						buttonMoveToArchive.Invoke(new Action(delegate()
						{
							buttonMoveToArchive.Enabled = true;
						}));
					}
				}).Start();
			}
		}
	}
}
