using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik Dosyaların Kullanımı
app.UseStaticFiles();

// Routing Konfigürasyonu
app.UseRouting();

// Varsayılan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



/*
Controller: Tarayıcıdan gelen istekleri yöneten ve iş mantığını sağlayan sınıflardır. 
Örneğin, HomeController gelen isteklere göre belirli bir View döndürür.

Action: Controller içinde yer alan, gelen isteklere yanıt veren metotlardır. 
Örneğin, Index action'ı tarayıcıdan gelen `/Home/Index` isteğine yanıt verir.

Model: Uygulamanın veri katmanını temsil eder. 
Verilerle ilgili işlemler (örneğin bir veritabanı tablosu) burada tanımlanır.

View: Uygulamanın kullanıcı arayüzünü oluşturan dosyalardır. 
Controller'dan gelen veriyi görselleştirir.

Razor: HTML ile C# kodunun bir arada yazılabildiği sayfaları oluşturmak için kullanılan motorudur.

RazorView: Razor motoru tarafından oluşturulan dinamik HTML dosyalarıdır.

wwwroot: Uygulamanın statik dosyalarını (CSS, JavaScript, görseller) barındıran klasördür.

builder.Build(): Uygulamayı yapılandırıp çalıştırılmaya hazır hale getirir. 
Bu metot uygulamayı başlatmadan önce servisler ve middleware'leri hazırlar.

app.Run(): Uygulamanın çalışmasını başlatır ve gelen istekleri dinler.
*/
