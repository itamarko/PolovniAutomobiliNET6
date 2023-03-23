using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PolovniAutomobili.Core;
using PolovniAutomobili.Data;

namespace PolovniAutomobili.Pages.Automobili
{
    public class DeleteModel : PageModel
    {
        private readonly IAutomobiliData _automobiliData;
        public Automobil Car { get; set; }

        public DeleteModel(IAutomobiliData automobiliData)
        {
            _automobiliData = automobiliData;
        }
        public IActionResult OnGet(int carId)
        {
            Car = _automobiliData.GetById(carId);
            if (Car == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int carId)
        {
            var car = _automobiliData.Delete(carId);
            if (car == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{car.Name} ({car.Id}) je uspesno obrisan";
            return RedirectToPage("./List");
        }
    }
}
