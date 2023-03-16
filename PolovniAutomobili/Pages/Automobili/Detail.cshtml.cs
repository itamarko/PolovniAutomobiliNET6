using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PolovniAutomobili.Core;
using PolovniAutomobili.Data;

namespace PolovniAutomobili.Pages.Automobili
{
    public class DetailModel : PageModel
    {
        private readonly IAutomobiliData _data;
        public Automobil Car { get; set; }
        [TempData]
        public string Message { get; set; }
        public DetailModel(IAutomobiliData data)
        {
            _data = data;
        }
        public IActionResult OnGet(int carId)
        {
            Car = _data.GetById(carId);
            if (Car == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
