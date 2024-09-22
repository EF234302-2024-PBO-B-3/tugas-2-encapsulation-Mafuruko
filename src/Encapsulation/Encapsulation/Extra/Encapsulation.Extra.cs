namespace Encapsulation.Extra
{
    public class Member
    {
        private string nama = string.Empty;  // Inisialisasi default
        private string email = string.Empty; // Inisialisasi default
        private int usia;

        // Setter untuk Nama dengan validasi
        public void SetNama(string nama)
        {
            if (string.IsNullOrEmpty(nama))
            {
                throw new ArgumentException("Nama tidak boleh kosong.");
            }
            this.nama = nama;
        }

        // Setter untuk Usia dengan validasi
        public void SetUsia(int usia)
        {
            if (usia < 18)
            {
                throw new ArgumentException("Usia minimal harus 18 tahun.");
            }
            this.usia = usia;
        }

        // Setter untuk Email dengan validasi format
        public void SetEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("Email tidak valid.");
            }
            this.email = email;
        }

        // Getter untuk Nama
        public string GetNama()
        {
            return nama;
        }

        // Getter untuk Usia
        public int GetUsia()
        {
            return usia;
        }

        // Getter untuk Email
        public string GetEmail()
        {
            return email;
        }

        // Method ToString untuk menampilkan informasi lengkap anggota
        public override string ToString()
        {
            return $"Nama: {nama}, Usia: {usia}, Email: {email}";
        }
    }
}
