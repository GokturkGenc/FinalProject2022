using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Şu anda hizmet verilmemektedir.";
        public static string ProductCountOfCategoryError = "Kategorideki ürün limiti aşıldı.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün zaten mevcut.";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı. Yeni ürün eklenemez.";
        public static string AuthorizationDenied = "Yetkilendirme onaylanmadı.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı parola.";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu mail zaten kullanılmaktadır.";
        public static string AccessTokenCreated = "Access Token Üretildi.";
    }
}
