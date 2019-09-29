using HekimogluWebPortal.Model.Family;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text.Json;

namespace HekimogluWebPortal.Services
{
    public class FamilyService : BaseService
    {
        public FamilyService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment)
        {
            JSONPath = Path.Combine(WebHostEnvironment.WebRootPath, "data", "Family.json");
        }

        public Family GetFamily()
        {
            using (var fileReader = File.OpenText(JSONPath))
            {
                return JsonSerializer.Deserialize<Family>(fileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}
