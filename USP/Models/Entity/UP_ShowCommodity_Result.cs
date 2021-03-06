//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace USP.Models.Entity
{
    using System;
    
    public partial class UP_ShowCommodity_Result
    {
        public Nullable<long> RowNo { get; set; }
        public Nullable<long> RowCnt { get; set; }
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string DetailLink { get; set; }
        public string Type { get; set; }
        public string TBKLink { get; set; }
        public decimal Price { get; set; }
        public long MonthOrder { get; set; }
        public decimal IncomeRate { get; set; }
        public decimal Commission { get; set; }
        public string SellerId { get; set; }
        public string SellerWangWangName { get; set; }
        public string ShopName { get; set; }
        public string PlatformName { get; set; }
        public string CouponId { get; set; }
        public long CouponCount { get; set; }
        public long CouponLeft { get; set; }
        public string CouponDenomination { get; set; }
        public System.DateTime CouponBeginTime { get; set; }
        public System.DateTime CouponEndTime { get; set; }
        public string CouponLink { get; set; }
        public string PromotionLink { get; set; }
        public string Reserve { get; set; }
        public string Remark { get; set; }
        public long Creator { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<long> Auditor { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public Nullable<long> Canceler { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
    }
}
