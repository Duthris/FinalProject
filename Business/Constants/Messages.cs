using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Bakım zamanı!";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountError = "Kategoride bulunan ürün sayısı limiti aşıyor!";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductNameAlreadyExists = "Ürün adı zaten mevcut!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "Doğrulama Reddedildi. YETKİNİZ YOK!";
        public static string UserRegistered = "Başarıyla kayıt olundu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Geçersiz şifre!";
        public static string SuccessfulLogin = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        public static string AccessTokenCreated = "Access Token Oluşturuldu.";
    }
}
