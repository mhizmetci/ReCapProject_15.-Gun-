using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public static string ResultSuccess;
        public static string ResultError;
        
    }
}
