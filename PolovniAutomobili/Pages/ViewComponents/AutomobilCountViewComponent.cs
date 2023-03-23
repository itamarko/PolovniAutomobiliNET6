using Microsoft.AspNetCore.Mvc;
using PolovniAutomobili.Data;

namespace PolovniAutomobili.Pages.ViewComponents
{
    public class AutomobilCountViewComponent : ViewComponent
    {
        private readonly IAutomobiliData _automobiliData;

        public AutomobilCountViewComponent(IAutomobiliData automobiliData)
        {
            _automobiliData = automobiliData;
        }

        public IViewComponentResult Invoke()
        {
            var count = _automobiliData.GetNumberOfCars();
            return View(count);
        }
    }
}
