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
    /// 商品图片  
    /// </summary> 
    public partial class ProductImgs
    {
    /// <summary>  
    /// 主键  
    /// </summary> 
        public int Id { get; set; }
    /// <summary>  
    /// 图片标题  
    /// </summary> 
        public string Title { get; set; }
    /// <summary>  
    /// 商品id  
    /// </summary> 
        public Nullable<int> PorductId { get; set; }
    /// <summary>  
    /// 图片路径  
    /// </summary> 
        public string FilePath { get; set; }
    /// <summary>  
    /// 创建日期  
    /// </summary> 
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
