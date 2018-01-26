/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using Easy.MetaData;
using ZKEACMS.Widget;
using ZKEACMS.MetaData;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZKEACMS.Product.Models
{
    [Table("ProductDetailWidget")]
    public class ProductDetailWidget : BasicWidget
    {
        public string CustomerClass { get; set; }
    }
    class ProductDetailWidgetMetaData : WidgetMetaData<ProductDetailWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.CustomerClass).AsHidden();
        }
    }
}