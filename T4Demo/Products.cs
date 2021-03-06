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
    /// 商品表  
    /// </summary> 
    public partial class Products
    {
        public Products()
        {
            this.Orders = new HashSet<Orders>();
            this.ProductImgs = new HashSet<ProductImgs>();
        }
    
    /// <summary>  
    /// 主键id  
    /// </summary> 
        public int Id { get; set; }
    /// <summary>  
    /// 商品名称  
    /// </summary> 
        public string ProductName { get; set; }
    /// <summary>  
    /// 商品描述  
    /// </summary> 
        public string Instruction { get; set; }
    /// <summary>  
    /// 分类id  
    /// </summary> 
        public Nullable<int> CategoryId { get; set; }
    /// <summary>  
    /// 价格  
    /// </summary> 
        public Nullable<decimal> Price { get; set; }
    /// <summary>  
    /// 创建日期  
    /// </summary> 
        public Nullable<System.DateTime> CreateDate { get; set; }
    /// <summary>  
    /// 创建者  
    /// </summary> 
        public Nullable<int> Creater { get; set; }
    /// <summary>  
    /// 库存  
    /// </summary> 
        public Nullable<int> Stock { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<ProductImgs> ProductImgs { get; set; }
    }
}
