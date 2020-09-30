using System;
using System.Collections.Generic;
using System.Text;

namespace FoodMangementMobile.Models
{
    public class ProductDetailsDto
    {
        public int ItemId { get; set; }
        public int ParentItemId { get; set; }
        public double SalePrice { get; set; }
        public string CategoryPath { get; set; }
        public string CategoryNode { get; set; }
        public string ShortDescription { get; set; }
        public string BrandName { get; set; }
        public string RawSize { get; set; }
        public double NumericSize { get; set; }
        public string UnitOfMeasurementCode { get; set; }
        public string UnitOfMeasurementName { get; set; }
        public int UnitOfMeasurementId { get; set; }
        public string Upc { get; set; }
        public string ImgSmallUrl { get; set; }
        public string ImgMediumUrl { get; set; }
        public string ImgLargeUrl { get; set; }
    }
}
