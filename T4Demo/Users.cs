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
    /// 用户表  
    /// </summary> 
    public partial class Users
    {
    /// <summary>  
    /// 主键id  
    /// </summary> 
        public int Id { get; set; }
    /// <summary>  
    /// 用户名称  
    /// </summary> 
        public string UserName { get; set; }
    /// <summary>  
    /// 密码  
    /// </summary> 
        public string Password { get; set; }
    /// <summary>  
    /// 真实姓名  
    /// </summary> 
        public string TrueName { get; set; }
    /// <summary>  
    /// 角色id  
    /// </summary> 
        public string Role { get; set; }
    /// <summary>  
    /// 创建时间  
    /// </summary> 
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
