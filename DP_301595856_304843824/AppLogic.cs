using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public class AppLogic
    {
        public User m_LoggedInUser;
        public LoginResult m_Result;

        public string AppID;
        
        public void loginToFacebook()
        {   
            m_Result = FacebookService.Login(
                AppID,
                "public_profile",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "publish_pages",
                "publish_actions",
                "rsvp_event");
            m_LoggedInUser = m_Result.LoggedInUser;
            setPropertiesAfterLogin();
        }

        public string CurrentFriendNameForCommonPicsFeature { get; set; } = null;

        public string UserName { get; set; }

        public string UserPicURL { get; set; }

        public FacebookObjectCollection<User> UserFriendsCollection { get; set; }

        public FacebookObjectCollection<Event> UserEventsCollection { get; set; }

        public FacebookObjectCollection<Page> UserLikedPagesCollection { get; set; }

        public FacebookObjectCollection<Album> UserAlbumsCollection { get; set; }

        private void setPropertiesAfterLogin()
        {
            UserName = m_LoggedInUser.Name;
            UserPicURL = m_LoggedInUser.PictureNormalURL;
            UserFriendsCollection = m_LoggedInUser.Friends;
            UserLikedPagesCollection = m_LoggedInUser.LikedPages;
            UserAlbumsCollection = m_LoggedInUser.Albums;
            UserEventsCollection = m_LoggedInUser.Events;
        }
    }
}
