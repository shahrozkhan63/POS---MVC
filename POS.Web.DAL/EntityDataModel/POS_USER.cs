//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeezTech.POS.Web.DAL.EntityDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class POS_USER
    {
        public long USER_ID { get; set; }
        public string CODE { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public bool ISACTIVE_FLAG { get; set; }
        public short LOGIN_TYPE { get; set; }
        public string MASTER_PASSWORD { get; set; }
        public long BRANCH_ID { get; set; }
        public Nullable<bool> ISPOSTED_FLAG { get; set; }
        public string CREATEDBY { get; set; }
        public string MODIFIEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDWHEN { get; set; }
        public Nullable<System.DateTime> MODIFIEDWHEN { get; set; }
    }
}
