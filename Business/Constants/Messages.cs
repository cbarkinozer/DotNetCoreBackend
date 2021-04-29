using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //It is static because we see no reason it to newed
   public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        internal static string MaintenanceTime ="System on maintenance";
        internal static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "Bir kategoride maksimum 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
