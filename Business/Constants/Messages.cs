using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz. Araç ismi  iki karakterden daha fazla  olmalıdır.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";
        public static string CarDeleted = "Araçlar silindi";
        public static string CarUpdated = "Araçlar güncellendi";
        public static string CarDailyPriceInvalid = "Araç günlük kiralama bebeli geçersiz. 0 da büyük olmalıdır.";

        public static string BrandNameInvalid = "Araç marka ismi geçersiz";
        public static string BrandAdded = "Yeni araç markası eklendi";
        public static string BrandUpdated = "Araç markası güncellendi";
        public static string BrandDeleted = "Araç markası silindi";
        public static string BrandListed = "Araç markaları listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorLsted = "Renkler listelendi";
        public static string ResultSuccess = "sonuç Başarılı";
        public static string ResultError = "Sonuç Hatalı";
        public static string AddedCarImage = "Araç resmi eklendi";
        public static string DeletedCarImage ="Araç resmi silindi";
        public static string FailedCarImageAdd = "Hatalı araç resmi eklemesi";
        public static string FailAddedImageLimit = "Araç resmi limitinizi aştınız";
        public static string  AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı Kabul edildi";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "Şifreniz hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim Token ı Oluşturuldu";
    }
}
