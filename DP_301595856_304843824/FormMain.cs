using System.Net;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{   
    public partial class FormMain : Form
    {
        private const int k_IsLegalSelect = 1;
        private HoroscopeLogic m_horoscope = new HoroscopeLogic();
        private AppLogic m_Logic = new AppLogic();

        public FormMain()
        {
            InitializeComponent();
        }

        public HoroscopeLogic Horoscope
        {
            get
            {
                return m_horoscope;
            }

            set
            {
                m_horoscope = value;
            }
        }

        public AppLogic LogicApp
        {
            get
            {
                return m_Logic;
            }

            set
            {
                m_Logic = value;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LogicApp.loginToFacebook();
                doAfterLogIn();
                if (LogicApp.m_LoggedInUser != null)
                {
                    this.ButtonLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "You didn't chose AppId" + Environment.NewLine + "Please choose AppId in the ComboBox first");
            }
        }

        private void doAfterLogIn()
        {
            comboBoxAppId.Enabled = false;
            LogicApp.m_LoggedInUser = LogicApp.m_Result.LoggedInUser;
            this.TextProfile.Text = "Hello: " + LogicApp.m_LoggedInUser.FirstName + " " + LogicApp.m_LoggedInUser.LastName;
            this.PictureBoxProfile.ImageLocation = LogicApp.m_LoggedInUser.PictureNormalURL;
            this.listBoxAboutMe.Items.Add("About Me:");
            this.listBoxAboutMe.Items.Add("Gender: " + LogicApp.m_LoggedInUser.Gender);
            this.listBoxAboutMe.Items.Add("Birthdate: " + LogicApp.m_LoggedInUser.Birthday);
            this.listBoxAboutMe.Items.Add("Relationship status: " + LogicApp.m_LoggedInUser.RelationshipStatus);
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            try
            {
                LogicApp.m_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Your status has been posted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOut()
        {
            try
            {
                FacebookService.Logout(afterLogout);
            }
            catch
            {
                MessageBox.Show("You havent logged in yet");
            }
        }

        private void afterLogout()
        {
            MessageBox.Show("Thank you" + " " + LogicApp.m_LoggedInUser.FirstName + " " + "you are now logged out");
            Close();
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            showFriends();
        }

        private void showFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in LogicApp.UserFriendsCollection)
                {
                    listBoxFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookWrapper.ObjectModel.User selectedFriend = listBoxFriends.SelectedItem as User;
            buttonCommonPhotosFeature.Text = "Common Photo with:" + selectedFriend.Name;

            if (selectedFriend.PictureNormalURL != null)
            {
                pictureBoxFriends.LoadAsync(selectedFriend.PictureSmallURL);
            }
            else
            {
                pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
            }
        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            showEvents();
        }

        private void showEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            try
            {
                foreach (Event currentEvent in LogicApp.UserEventsCollection)
                {
                    listBoxEvents.Items.Add(currentEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selectedEvent = listBoxEvents.SelectedItem as Event;
            pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
        }

        private void buttonLikePages_Click(object sender, EventArgs e)
        {
            showPages();
        }

        private void showPages()
        {
            listBoxLikePages.Items.Clear();
            listBoxLikePages.DisplayMember = "Name";

            try
            {
                foreach (Page currentLikedPage in LogicApp.UserLikedPagesCollection)
                {
                    listBoxLikePages.Items.Add(currentLikedPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedPage = listBoxLikePages.SelectedItem as Page;
            pictureBoxPage.LoadAsync(selectedPage.PictureSmallURL);
        }

        private void buttonHoroscopeFeature_Click(object sender, EventArgs e)
        {
            showHoroscope();
        }

        private void showHoroscope()
        {
            int month = Horoscope.dateConvert(LogicApp.m_LoggedInUser.Birthday, 0, 2);
            int day = Horoscope.dateConvert(LogicApp.m_LoggedInUser.Birthday, 3, 2);
            string horoscopeText = Horoscope.GetHoroscopeByDateOfBirth(day, month);

            FormHoroscope form = new FormHoroscope(horoscopeText);
            form.Show();
        }

        private void buttonCommonPhotosFeature_Click(object sender, EventArgs e)
        {
            showCommonPhotos();
        }

        private void showCommonPhotos()
        {
            User selectedUser = listBoxFriends.SelectedItem as User;

            listBoxCommonPhoto.Items.Clear();
            listBoxCommonPhoto.DisplayMember = "CreatedTime";
            try
            {
                addCommonPicturesToListBox();
                if (listBoxCommonPhoto.Items.Count == 0)
                {
                    MessageBox.Show(string.Format("You have no common photos with {0}", LogicApp.CurrentFriendNameForCommonPicsFeature));
                }
            }
            catch
            {
                MessageBox.Show("You have no albums");
            }
        }

        private void addCommonPicturesToListBox()
        {
            User selectedFriend = listBoxFriends.SelectedItem as User;
            LinkedList<Photo> photoList = CommonPhotosLogic.MakeListOfCommonPhotos(LogicApp.UserAlbumsCollection, selectedFriend.Name);
            foreach (Photo currentPhoto in photoList)
            {
                listBoxCommonPhoto.Items.Add(currentPhoto);
            }
        }

        private void listBoxCommonPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo selectedPage = listBoxCommonPhoto.SelectedItem as Photo;
            pictureBoxCommonPhoto.LoadAsync(selectedPage.PictureNormalURL);
        }

        private void comboBoxAppId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicApp.AppID = comboBoxAppId.SelectedItem.ToString();
        }
    }
}
