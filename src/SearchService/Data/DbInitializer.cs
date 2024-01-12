using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Data
{
    public class DbInitializer
    {
        public static async Task InitDb(WebApplication app)
        {
            // Inisialisasi koneksi database MongoDB menggunakan nama database "SearchDb"
            await DB.InitAsync("SearchDb", MongoClientSettings.FromConnectionString(
                    app.Configuration.GetConnectionString("MongoDbConnection")
                )
            );

            // Membuat indeks teks pada properti Make, Model, dan Color pada kelas Item
            await DB.Index<Item>()
                .Key(x => x.Make, KeyType.Text)
                .Key(x => x.Model, KeyType.Text)
                .Key(x => x.Color, KeyType.Text)
                .CreateAsync();

            // Menghitung jumlah dokumen dalam koleksi Item
            var count = await DB.CountAsync<Item>();

            // Jika tidak ada dokumen dalam koleksi Item, lakukan seeding data
            if (count == 0)
            {
                Console.WriteLine("Seeding data...");

                // Membaca data dari file JSON ("Data/auctions.json")
                var itemData = await File.ReadAllTextAsync("Data/auctions.json");

                // Menggunakan System.Text.Json untuk menguraikan data JSON ke dalam objek List<Item>
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var items = JsonSerializer.Deserialize<List<Item>>(itemData, options);

                // Menyimpan item ke koleksi Item dalam database MongoDB
                await DB.SaveAsync(items);
            }
        }
    }
}
