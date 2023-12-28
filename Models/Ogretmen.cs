using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BeltekFinalProject.Models
{
    public class Ogretmen
    {
        [Required(ErrorMessage ="Tc Kimlik No Alanı Boş Bırakılamaz!")]
        [DisplayName("Tc Kimlik No")]
        [Range(11111111111, 99999999999,ErrorMessage ="Lütfen Geçerli Bir Tc Kimlik Numarası Giriniz!")]
        public string TcKimlik { get; set; }
        [Required(ErrorMessage = "Ad Bölümü Boş Bırakılamaz!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad Bölümü Boş Bırakılamaz!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Alan Bölümü Boş Bırakılamaz!")]
        public string Alan { get; set; }

        public Ogretmen() { }

        public Ogretmen(string TcKimlik, string Ad, string Soyad, string Alan)
        {
            this.TcKimlik = TcKimlik;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Alan = Alan;

        }

        public override string ToString()
        {
            return $"Kimlik No:{this.TcKimlik}Ad:{this.Ad} Soyad:{this.Soyad} Alan: {this.Alan}";
        }
    }
}
