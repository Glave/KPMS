//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_Option_Info
    {
        public int Id { get; set; }
        public string Project_No { get; set; }
        public Nullable<short> Item_No { get; set; }
        public short Tender_Version { get; set; }
        public string Option_Description { get; set; }
        public Nullable<decimal> Hours_M { get; set; }
        public Nullable<bool> ME_Solution_Check { get; set; }
        public Nullable<decimal> Hours_E { get; set; }
        public Nullable<bool> EE_Solution_Check { get; set; }
        public string OE_response_ME { get; set; }
        public string OE_response_EE { get; set; }
        public string OE_ME_Comments { get; set; }
        public string OE_EE_Comments { get; set; }
        public Nullable<bool> CTQ_ME { get; set; }
        public Nullable<bool> CTQ_EE { get; set; }
        public string Options_Drawing_Name { get; set; }
        public string Options_Drawing_Address { get; set; }
        public string Options_Solution_ME_Name { get; set; }
        public string Options_Solution_ME_Address { get; set; }
        public string Options_Solution_EE_Name { get; set; }
        public string Options_Solution_EE_Address { get; set; }
        public Nullable<short> Order_Version { get; set; }
    }
}
