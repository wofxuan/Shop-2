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
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    [MetadataType(typeof(USP.Models.ViewModel.OpenPlatformAccessTokenMetaData))]
    public partial class OpenPlatformAccessToken
    {
        public long Corp { get; set; }
        public string PlatformType { get; set; }
        public string AccessToken { get; set; }
        public System.DateTime AccessTime { get; set; }
        public long ExpiresIn { get; set; }
        public long Expires { get; set; }
        public string Reserve { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}