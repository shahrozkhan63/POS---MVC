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
    
    public partial class POS_COMPANY
    {
        public long COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_DESC { get; set; }
        public byte[] LOGO { get; set; }
        public string HTTP_HOST_ADDRESS { get; set; }
        public string NTN_NO { get; set; }
        public string REGISTEREDBY { get; set; }
        public bool ISACTIVE_FLAG { get; set; }
        public bool ISPOSTED_FLAG { get; set; }
        public string CREATEDBY { get; set; }
        public string MODIFIEDBY { get; set; }
        public System.DateTime CREATEDWHEN { get; set; }
        public Nullable<System.DateTime> MODIFIEDWHEN { get; set; }
        public bool IsMultipleBranch { get; set; }
        public bool IsWarehouse { get; set; }
        public bool IsWarehouseStock { get; set; }
        public bool IsWarehouseTracking { get; set; }
        public bool IsWarehouseShipment { get; set; }
        public bool IsVendor { get; set; }
        public bool IsVendorShipment { get; set; }
        public bool IsDisplayTracking { get; set; }
        public bool IsRFQ { get; set; }
        public bool IsAccounting { get; set; }
        public bool IsCashierCounter { get; set; }
        public bool IsPromotion { get; set; }
        public bool IsPaymentSystem { get; set; }
    }
}
