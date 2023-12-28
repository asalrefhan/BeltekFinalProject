using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BeltekFinalProject.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        [Required(ErrorMessage = "Ad Bölümü Boş Bırakılamaz!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad Bölümü Boş Bırakılamaz!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Numara Bölümü Boş Bırakılamaz!")]
        public string Numara { get; set; }

        [Required(ErrorMessage = "Bölüm Alanı Boş Bırakılamaz!")]
        [DisplayName("Bölüm")]
        public string Bolum { get; set; }

        public Ogrenci()
        {

        }

        public Ogrenci(int OgrenciId, string Ad, string Soyad, string Numara, string Bolum)
        {
            this.OgrenciId = OgrenciId;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Numara = Numara;
            this.Bolum = Bolum;


        }

        public override string ToString()
        {
            return $"Id:{this.OgrenciId} Ad:{this.Ad} Soyad:{this.Soyad} Numara: {this.Numara} Bolum:{this.Bolum}";
        }
    }
}
