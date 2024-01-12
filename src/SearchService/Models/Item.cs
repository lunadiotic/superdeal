// Mengimport namespace MongoDB.Entities yang menyediakan Entity base class untuk kelas MongoDB
using MongoDB.Entities;

// Menyatakan namespace untuk kelas Item
namespace SearchService.Models
{
    // Deklarasi kelas Item yang mewarisi dari kelas Entity
    public class Item : Entity
    {
        // Properti ReservePrice untuk menetapkan dan mendapatkan nilai reserve price
        public int ReservePrice { get; set; }

        // Properti Seller untuk menetapkan dan mendapatkan nilai penjual
        public string Seller { get; set; }

        // Properti Winner untuk menetapkan dan mendapatkan nilai pemenang lelang
        public string Winner { get; set; }

        // Properti SoldAmount untuk menetapkan dan mendapatkan nilai jumlah terjual
        public int SoldAmount { get; set; }

        // Properti CurrentHighBid untuk menetapkan dan mendapatkan nilai tawaran tertinggi saat ini
        public int CurrentHighBid { get; set; }

        // Properti CreatedAt untuk menetapkan dan mendapatkan nilai waktu pembuatan
        public DateTime CreatedAt { get; set; }

        // Properti UpdatedAt untuk menetapkan dan mendapatkan nilai waktu terakhir diperbarui
        public DateTime UpdatedAt { get; set; }

        // Properti AuctionEnd untuk menetapkan dan mendapatkan nilai waktu akhir lelang
        public DateTime AuctionEnd { get; set; }

        // Properti Status untuk menetapkan dan mendapatkan nilai status item (misalnya, "Active" atau "Closed")
        public string Status { get; set; }

        // Properti Make untuk menetapkan dan mendapatkan nilai merek item
        public string Make { get; set; }

        // Properti Model untuk menetapkan dan mendapatkan nilai model item
        public string Model { get; set; }

        // Properti Year untuk menetapkan dan mendapatkan nilai tahun pembuatan item
        public int Year { get; set; }

        // Properti Color untuk menetapkan dan mendapatkan nilai warna item
        public string Color { get; set; }

        // Properti Mileage untuk menetapkan dan mendapatkan nilai jumlah mil item
        public int Mileage { get; set; }

        // Properti ImageUrl untuk menetapkan dan mendapatkan nilai URL gambar item
        public string ImageUrl { get; set; }
    }
}
