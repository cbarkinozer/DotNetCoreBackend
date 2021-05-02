using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        internal static string SuccessfulLogin = "Giriş başarılı.";
        internal static string UserAlreadyExists="Kullanıcı zaten bulunmakta.";
        internal static string AccessTokenCreated="Erişim tokeni oluşturuldu.";
    }
}
