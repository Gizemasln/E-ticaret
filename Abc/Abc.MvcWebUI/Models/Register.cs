using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("E-posta Adresiniz")]
        [EmailAddress(ErrorMessage ="Geçerli bir e-posta adresi değil.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}