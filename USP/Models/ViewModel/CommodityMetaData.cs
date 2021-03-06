//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template made by Louis-Guillaume Morand.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace USP.Models.ViewModel
{
    
    
    public class CommodityMetaData
    {
        [Required] 
        public virtual long ID
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required] 
        public virtual string Code
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required] 
        public virtual string Name
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string Picture
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string DetailLink
        {
            get;
            set;
        }
    	
        [StringLength(50, ErrorMessage="最多可输入50个字符")]
        [Required] 
        public virtual string Type
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string TBKLink
        {
            get;
            set;
        }
        [Required] 
        public virtual decimal Price
        {
            get;
            set;
        }
        [Required] 
        public virtual long MonthOrder
        {
            get;
            set;
        }
        [Required] 
        public virtual decimal IncomeRate
        {
            get;
            set;
        }
        [Required] 
        public virtual decimal Commission
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string SellerId
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required] 
        public virtual string SellerWangWangName
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required] 
        public virtual string ShopName
        {
            get;
            set;
        }
    	
        [StringLength(32, ErrorMessage="最多可输入32个字符")]
        [Required] 
        public virtual string PlatformName
        {
            get;
            set;
        }
    	
        [StringLength(100, ErrorMessage="最多可输入100个字符")]
        [Required] 
        public virtual string CouponId
        {
            get;
            set;
        }
        [Required] 
        public virtual long CouponCount
        {
            get;
            set;
        }
        [Required] 
        public virtual long CouponLeft
        {
            get;
            set;
        }
    	
        [StringLength(100, ErrorMessage="最多可输入100个字符")]
        [Required] 
        public virtual string CouponDenomination
        {
            get;
            set;
        }
        [Required] 
        public virtual System.DateTime CouponBeginTime
        {
            get;
            set;
        }
        [Required] 
        public virtual System.DateTime CouponEndTime
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string CouponLink
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required] 
        public virtual string PromotionLink
        {
            get;
            set;
        }
    	
        [StringLength(250, ErrorMessage="最多可输入250个字符")]
        public virtual string Reserve
        {
            get;
            set;
        }
    	
        [StringLength(250, ErrorMessage="最多可输入250个字符")]
        public virtual string Remark
        {
            get;
            set;
        }
        [Required] 
        public virtual long Creator
        {
            get;
            set;
        }
        [Required] 
        public virtual System.DateTime CreateTime
        {
            get;
            set;
        }
        public virtual Nullable<long> Auditor
        {
            get;
            set;
        }
        public virtual Nullable<System.DateTime> AuditTime
        {
            get;
            set;
        }
        public virtual Nullable<long> Canceler
        {
            get;
            set;
        }
        public virtual Nullable<System.DateTime> CancelTime
        {
            get;
            set;
        }
        public virtual Nullable<decimal> CouponPrice
        {
            get;
            set;
        }
        public virtual Nullable<decimal> CouponCondition
        {
            get;
            set;
        }
        public virtual Nullable<long> PromotionType
        {
            get;
            set;
        }
    }
}
