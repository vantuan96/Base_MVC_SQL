namespace Kztek.Web.Core.Models
{
    public class ConstField
    {
        #region Memory cache name

        public const string MemCacheMember = "memCacheMember";

        public const string MemCachePermissions = "memCachePermissions";

        public const string AllListMenuFunctionCache = "allListMenuFunctionCache";

        public const string AllListStationCache = "allListStationCache";

        public const string ListUserRole = "listUserRole";

        public const string ListUserStation = "listUserStation";

        public const string ListRoleMenu = "listRoleMenu";

        public const string List_MN_Role_Menu = "list_MN_Role_Menu";

        public const string ListLane = "listLane";

        public const string ListGate = "listGate";

        public const string ListPC = "listPC";

        public const string ListUser = "listUser";

        public const string ListCompany = "listCompany";

        public const string ListRoute = "listRoute";

        public const string ListServicePriceType = "listServicePriceType";

        public const string WebConfigObj = "WebConfigObj";

        public const string CacheService = "CacheService";

            /// <summary>
            /// Cache người quản lý dịch vụ
            /// </summary>
            #region Memory cache name user manger service
            public const string UserManagerService = "userMangerServiceCache";
            public const string UserManagerServicePermissions = "userMangerServiceCachePermissions";
            public const string AllListMenuFunctionServiceCache = "allListMenuFunctionServiceCache";
            public const string ListUserRoleService = "listUserRoleService";
            public const string ListRoleMenuService = "listRoleMenuService";
        #endregion
        #endregion Memory cache name

        #region TimeCache

        public const int TimeCache = 86400;

        #endregion TimeCache

        #region PageSize

        public const int PageSizeDefault = 25;

        #endregion PageSize

        #region Sessions

        public const string Popup = "Popup";

        #endregion Sessions


        public const string YogaArea = "Yoga";
    }
}