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
        [Display( Name = "商品id")]
        public virtual string Code
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required]
        [Display(Name = "商品名称")]
        public virtual string Name
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "商品主图")]
        public virtual string Picture
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "详细页链接")]
        public virtual string DetailLink
        {
            get;
            set;
        }
    	
        [StringLength(50, ErrorMessage="最多可输入50个字符")]
        [Required]
        [Display(Name = "商品一级类目")]
        public virtual string Type
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "淘宝客链接")]
        public virtual string TBKLink
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "商品价格")]
        public virtual decimal Price
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "月销量")]
        public virtual long MonthOrder
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "收入比率")]
        public virtual decimal IncomeRate
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "佣金")]
        public virtual decimal Commission
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "卖家ID")]
        public virtual string SellerId
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required]
        [Display(Name = "卖家旺旺")]
        public virtual string SellerWangWangName
        {
            get;
            set;
        }
    	
        [StringLength(255, ErrorMessage="最多可输入255个字符")]
        [Required]
        [Display(Name = "店铺名称")]
        public virtual string ShopName
        {
            get;
            set;
        }
    	
        [StringLength(32, ErrorMessage="最多可输入32个字符")]
        [Required]
        [Display(Name = "平台名称")]
        public virtual string PlatformName
        {
            get;
            set;
        }
    	
        [StringLength(100, ErrorMessage="最多可输入100个字符")]
        [Required]
        [Display(Name = "优惠券Id")]
        public virtual string CouponId
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "优惠券总数")]
        public virtual long CouponCount
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "优惠券剩余量")]
        public virtual long CouponLeft
        {
            get;
            set;
        }
    	
        [StringLength(100, ErrorMessage="最多可输入100个字符")]
        [Required]
        [Display(Name = "优惠券面额")]
        public virtual string CouponDenomination
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "优惠券开始日期")]
        public virtual System.DateTime CouponBeginTime
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "优惠券结束日期")]
        public virtual System.DateTime CouponEndTime
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "优惠券链接")]
        public virtual string CouponLink
        {
            get;
            set;
        }
    	
        [StringLength(400, ErrorMessage="最多可输入400个字符")]
        [Required]
        [Display(Name = "推广链接")]
        public virtual string PromotionLink
        {
            get;
            set;
        }
    	
        [StringLength(250, ErrorMessage="最多可输入250个字符")]
        [Display(Name = "保留")]
        public virtual string Reserve
        {
            get;
            set;
        }
    	
        [StringLength(250, ErrorMessage="最多可输入250个字符")]
        [Display(Name = "备注")]
        public virtual string Remark
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "创建人")]
        public virtual long Creator
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "创建时间")]
        public virtual System.DateTime CreateTime
        {
            get;
            set;
        }
        [Display(Name = "审核人")]
        public virtual Nullable<long> Auditor
        {
            get;
            set;
        }
        [Display(Name = "审核时间")]
        public virtual Nullable<System.DateTime> AuditTime
        {
            get;
            set;
        }
        [Display(Name = "注销人")]
        public virtual Nullable<long> Canceler
        {
            get;
            set;
        }
        [Display(Name = "注销时间")]
        public virtual Nullable<System.DateTime> CancelTime
        {
            get;
            set;
        }
    }
}