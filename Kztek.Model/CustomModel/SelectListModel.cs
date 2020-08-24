using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kztek.Model.CustomModel
{
    public class SelectListModel
    {
        public string ItemValue { get; set; }
        public string ItemText { get; set; }
    }


    public class SelectListModel2
    {
        public string ItemValue { get; set; }
        public string ItemText { get; set; }
        public string ItemOtherValue { get; set; }
    }

    public class SelectListModel3
    {
        public string ItemValue { get; set; }
        public string ItemText { get; set; }
        public int ItemOtherValue { get; set; }
    }

    public class SelectListModel4
    {
        public string DriverLicense { get; set; }
        public string DriverLicenseRank { get; set; }
        public string DateActive { get; set; }
        public string DateExpire { get; set; }
    }
    public class SelectListModelTree
    {
        public string ItemValue { get; set; }
        public string ItemText { get; set; }
        public string ParentValue { get; set; }//Cấp cha 
    }
    public class SelectListModel1
    {
        public string ItemValue { get; set; }

        public string ItemText { get; set; }

        public int ItemIndex { get; set; }

        public string ItemCode { get; set; }

        public string Icon { get; set; }

        public string Color { get; set; }

        public string AreaName { get; set; }
    }

    public class SelectListModel_Resolution
    {
        public string Text { get; set; }
    }

    public class SelectListModel6
    {
        public int ItemValue { get; set; }

        public string ItemText { get; set; }
    }
    public class SelectListModelAutocomplete
    {
        //Id
        public string id { get; set; }

        //Tên tìm thêm
        public string name { get; set; }

        //Tên hiển thị
        public string value { get; set; }
    }
    public class SelectListModel_FileUpload
    {
        public string FileUploadName { get; set; }

        public string BoxRenderId { get; set; }

        public string Base64String { get; set; }

        public string FilePath { get; set; }

        public string Id { get; set; }
    }

}
