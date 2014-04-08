using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace asthanarht.fbindi.Constant
{
    public class FbConstant
    {
        public const string NOT_AUTHORIZED = "Not Authorized";
        public const string FACEBOOK_LOGIN_COMPLETE_URL = "http://localhost:29341/home/index";
        public const string FACEBOOK_USER_DENIED = "user_denied";
        public const string FACEBOOK_ERROR_REASON = "error_reason";

        /// <summary>
        /// This will be on the Application Settings on FB
        /// </summary>
        public const string FACEBOOK_APP_ID = "749608768405485";
        public const string FACEBOOK_SECRET = "7b684cf376f8ea0b2eaf5a997147decc";

        /// <summary>
        /// Permissions that we need from the user to interact with the User's FB account
        /// </summary>
        /// <seealso cref="http://developers.facebook.com/docs/authentication/permissions/"/>
        public const string FACEBOOK_SCOPE = "email,publish_stream,user_hometown,user_website,read_friendlists,read_insights,read_requests,read_stream,read_mailbox,publish_stream,publish_actions,manage_notifications";


    }
}