namespace TP_Modul9.Models
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        // Parameterless constructor untuk deserialization Swagger
        public Mahasiswa() { }

        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            NIM = nim;
        }
    }
}
