﻿using Microsoft.eShopWeb.ApplicationCore.Entities;
using System.Collections.Generic;

namespace Microsoft.eShopWeb.ViewModels
{
    public class Catalog
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<CatalogItem> Data { get; set; }
    }
}
