using Microsoft.AspNetCore.Hosting;

namespace HekimogluWebPortal.Services
{
    public abstract class BaseService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        internal string JSONPath { get; set; }

        public BaseService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
    }
}
