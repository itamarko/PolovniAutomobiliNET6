using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PolovniAutomobili.Core;
using PolovniAutomobili.Data;

namespace PolovniAutomobili.Pages.Automobili
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IAutomobiliData _automobiliData;

        public string Message { get; set; }
        public IEnumerable<Automobil> Cars { get; set; }

        public ListModel(IConfiguration configuration, IAutomobiliData automobiliData)
        {
            _configuration = configuration;
            _automobiliData = automobiliData;
        }
        public void OnGet()
        {
            Message = _configuration["Message"];
            Cars = _automobiliData.GetAll();
        }
    }
}
