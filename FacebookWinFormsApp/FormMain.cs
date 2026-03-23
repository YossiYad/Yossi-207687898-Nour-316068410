using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        User m_LoggedInUser;
        FacebookWrapper.LoginResult m_LoginResult;

        private FriendsAnalyzer m_friendAnalyzer;

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
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                "user_photos", 
                "user_posts", 
                "user_friends" 
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
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

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;

            //pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            this.Text = $"Logged in as {m_LoggedInUser.Name}";

            m_friendAnalyzer = new FriendsAnalyzer(m_LoggedInUser); 
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_friendAnalyzer = null; 
            pictureBoxProfile.Image = null;
        }

        private void buttonFindActiveFriends_Click(object sender, EventArgs e)
        {
            if (m_friendAnalyzer == null)
            {
                MessageBox.Show("Please login first");
                return;
            }

            if (!m_friendAnalyzer.IsAnalyzed)
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

            new System.Threading.Thread(() =>
            {
                try
                {
                    List<User> topActiveFriends = m_friendAnalyzer.GetActiveFriends(10);

                    listBoxFriends.Invoke(new Action(() =>
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
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    buttonFindActiveFriends.Invoke(new Action(() =>
                    {
                        buttonFindActiveFriends.Enabled = true;
                    }));
                }
            }).Start();
        }

        private void buttonFindGhostFriends_Click(object sender, EventArgs e)
        {
            if (m_friendAnalyzer == null) return;

            labelStatus.Text = "Status: Searching for ghosts...";
            labelStatus.ForeColor = Color.Blue;
            buttonFindGhostFriends.Enabled = false;
            listBoxFriends.Items.Clear();

            new System.Threading.Thread(() =>
            {
                try
                {
                    List<User> ghostFriends = m_friendAnalyzer.GetGhostFriends();

                    listBoxFriends.Invoke(new Action(() =>
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
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    buttonFindGhostFriends.Invoke(new Action(() =>
                    {
                        buttonFindGhostFriends.Enabled = true;
                    }));
                }
            }).Start();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (m_friendAnalyzer != null)
            {
                m_friendAnalyzer.ResetAnalyzer();
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
    }
}
