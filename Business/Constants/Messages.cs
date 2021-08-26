using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed="Ürünler listelendi";


        public static string ProductCountOfCategoryError = "bir kategoride 10 dan fazla ürün olamaz";
        public static string ProductNameAlreadyExists = "bu ürün isminmde zaten başka ürün var";
        public static string CategoryLimitExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "token oluştruldu";
    }
}
