//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace T4Demo
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>  
    /// 公众号表  
    /// </summary> 
    public partial class WeiXinUserInfo
    {
    /// <summary>  
    /// 主键id  
    /// </summary> 
        public int Id { get; set; }
    /// <summary>  
    /// 公众号名称  
    /// </summary> 
        public string Name { get; set; }
    /// <summary>  
    /// 公众号Appid  
    /// </summary> 
        public string AppID { get; set; }
    /// <summary>  
    /// AppSecret  
    /// </summary> 
        public string AppSecret { get; set; }
    /// <summary>  
    /// 粉丝数量  
    /// </summary> 
        public int UserCount { get; set; }
    /// <summary>  
    /// 创建日期  
    /// </summary> 
        public Nullable<System.DateTime> CreateDate { get; set; }
    /// <summary>  
    /// token日期  
    /// </summary> 
        public Nullable<System.DateTime> LastTokenDate { get; set; }
    /// <summary>  
    /// token  
    /// </summary> 
        public string AccessToken { get; set; }
    }
}