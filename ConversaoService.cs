using System.IO;
using System.Text.Json;

namespace Dashboard
{
    public class ConversaoService
    {
        private readonly string _jsonFilePath;

        public ConversaoService(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }

        public Conversao ObterConversao()
        {
            using (var stream = new FileStream(_jsonFilePath, FileMode.Open, FileAccess.Read))
            {
                return JsonSerializer.Deserialize<Conversao>(stream);
            }
        }
    }
}
