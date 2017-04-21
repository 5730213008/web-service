﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        /*
         MakeFlag Flag:bit
         FinishedGoodsFlag Flag:bit
         Color nvarchar(15)
         SafetyStockLevel smallint
         ReorderPoint smallint
         StandardCost money
         ListPrice money
         Size nvarchar(5)
         SizeUnitMeasureCode nchar(3)
         WeightUnitMeasureCode nchar(3)
         Weight decimal(8, 2)
         DaysToManufacture int
         ProductLine nchar(2)
         Class nchar(2)
         Style nchar(2)
         ProductSubcategoryID int
         ProductModelID int
         SellStartDate datetime
         SellEndDate datetime 
         DiscontinuedDate datetime
         rowguid uniqueidentifier
         ModifiedDate datetime

         */
    }
}