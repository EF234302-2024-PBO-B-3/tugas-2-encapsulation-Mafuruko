using System;

namespace Encapsulation.Calendar
{
    public class Date
    {
        // Properti publik dengan metode get dan private set
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        // Konstruktor dengan validasi
        public Date(int month, int day, int year)
        {
            if (IsValidDate(month, day, year))
            {
                Month = month;
                Day = day;
                Year = year;
            }
            else
            {
                Month = 1; // Set default ke 1
                Day = 1;   // Set default ke 1
                Year = 1970; // Set default ke tahun 1970
            }
        }

        // Metode untuk memvalidasi tanggal
        private bool IsValidDate(int month, int day, int year)
        {
            return (month >= 1 && month <= 12) && (day >= 1 && day <= 31);
        }

        // Metode untuk menampilkan tanggal dengan format bulan/hari/tahun
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}