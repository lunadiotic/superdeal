// Mengimport namespace dan kelas DbInitializer dari proyek SearchService.Data
using SearchService.Data;

// Membuat objek builder menggunakan WebApplicationBuilder dan memberikan argumen dari command line
var builder = WebApplication.CreateBuilder(args);

// Menambahkan layanan Controllers ke dalam kontainer layanan (service container)
builder.Services.AddControllers();

// Membangun aplikasi web menggunakan konfigurasi yang telah didefinisikan
var app = builder.Build();

// Mengkonfigurasi pipeline HTTP request
app.UseAuthorization(); // Menggunakan mekanisme otorisasi yang telah diatur sebelumnya
app.MapControllers(); // Menetapkan controllers sebagai bagian dari pipeline

// Mencoba untuk menginisialisasi database dengan data awal (seeding)
try
{
    await DbInitializer.InitDb(app); // Panggil fungsi InitDb pada DbInitializer
}
catch (Exception e)
{
    Console.WriteLine(e); // Tangkap dan tampilkan exception jika terjadi kesalahan saat inisialisasi database
}

// Menjalankan aplikasi web
app.Run();
