var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

    public class Program {
    
        public static void Main(string[] args) {

        ConcessionariaController controller = new ConcessionariaController();
        ConcessionariaView view = new ConcessionariaView();

        // Adicionando alguns carros ao sistema
        controller.AdicionarCarro(1, "Fiat", "Uno", 60000);
        controller.AdicionarCarro(2, "Honda", "Civic", 150000);
        controller.AdicionarCarro(3, "Chevrolet", "Onix", 120000);

        // Listando e exibindo os carros
        List<Carro> carrosDisponiveis = controller.ListarCarros();
        view.ExibirCarros(carrosDisponiveis);
    }
}
