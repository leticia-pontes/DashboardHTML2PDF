using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Dashboard.Pages
{
    public class IndexModel : PageModel
    {
        public Conversao Conversao { get; private set; }

        public void OnGet()
        {
            // Define o caminho do arquivo JSON
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "dados.json");

            // Lê e deserializa o JSON
            using (var stream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read))
            {
                Conversao = JsonSerializer.Deserialize<Conversao>(stream);
            }
        }
    }
}
