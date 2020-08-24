namespace Kztek.Web.Core.Models
{
    public class SessionConfig
    {
        public const string MemberSession = "cp_memberSession";
        public const string MemberCookies = "cp_memberCookies";
        public const string MemberSystemSession = "cp_memberSystemSession";
        public const string MemberSystemCookies = "cp_memberSystemCookies";
        public const string WebInfoSession = "cp_webinfoSession";
        public const string SystemConfigSession = "cp_webinfoSession";
        public const string CustomerSession = "cp_customerSession";
        public const string CustomerCookies = "cp_customerCookies";
        public const string MemberManagerSession = "cp_memberManagerSession";
        public const string MemberManagerCookies = "cp_memberManagerCookies";
        public const string ServiceCookies = "SM_ServiceCookies";
        public const string ServiceSession = "SM_ServiceSession";

        /// <summary>
        ///Session/Cookies name admin quản lý dịch vụ
        /// </summary>
        #region User manager Service
        public const string Admin_Loginr_Service_Session = "Admin_Login_Service_Session";
        public const string Admin_Login_Service_Cookies = "Admin_Login_Service_Cookies";
        public const string User_Manager_Service_Session = "User_Manager_Service_Session";
        public const string User_Manager_Service_Cookies = "User_Manager_Service_Cookies";
        #endregion

        public const string PackageChooseCookies = "PackageChooseCookies";
    }
}