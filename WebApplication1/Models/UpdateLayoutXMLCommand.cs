
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UpdateLayoutXMLCommand
    {
        public int OwnerID { get; set; }
        public string KeyId { get; set; }
        public string DBProvider { get; set; }
        public string DBType { get; set; }
        public string DBConnStr { get; set; }

        public string selectedLayoutIdValue { get; set; }
        public string selectedRoleIdValue { get; set; }

        public string selectedObjectIdValue { get; set; }
        public string selectedLayoutTypeIDValue { get; set; }
        public LayoutType1 LayoutTypeList { get; set; }
        public string FieldId { get; set; }
        public string FieldName { get; set; }
        public string Objectid { get; set; }
        public string DependentFieldName { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
        public string OptionDependentId { get; set; }
        public string OptionDependentName { get; set; }
        public string VisibilityDisplayNames { get; set; }
        public string VisibilityValues { get; set; }
        public string RadioInput { get; set; }

        public string CustomErrorMessage { get; set; } /*Add this Deepika*/
    }

    public enum LayoutType1

    {
        None = 0,
        New = 1,
        Details = 2,
        Search = 3,
        History = 4,
        Navigation = 5,
        SSPNew = 6,
        SSPDetails = 7,
        PrinterFriendly = 8,
        QuickCreate = 9,
        HomePage = 10,
        MobileNew = 11,
        MobileDetails = 12,
        QuickDetail = 13,
        SSPHome = 14,
        MobileSearch = 15,
        CalendarNew = 16,
        CalendarDetail = 17,
        Outlook = 18,
        MobileHome = 19,
        Invalid = -1,
    }
}