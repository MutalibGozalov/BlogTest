using Microsoft.AspNetCore.Mvc;
using RNET102.UI.Data;
using RNET102.UI.Models;

namespace RNET102.UI.ViewComponents;

public class ProductViewComponent : ViewComponent
{
    private RNET102DbContext _context;
    public ProductViewComponent(RNET102DbContext context)
    {
        _context = context;
    }
    public async Task<IViewComponentResult> InvokeAsync()
	{
		var product = _context.Products.ToList();
		return View(model: product);
	}
}
