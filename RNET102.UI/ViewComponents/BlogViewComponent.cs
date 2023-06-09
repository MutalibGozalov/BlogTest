using Microsoft.AspNetCore.Mvc;
using RNET102.UI.Data;

namespace RNET102.UI.ViewComponents
{
	public class BlogViewComponent : ViewComponent
	{
		RNET102DbContext context;
        public BlogViewComponent(RNET102DbContext context)
        {
			this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
		{
			var blogs = context.Blogs.ToList();
			return View(model: blogs);
		}
	}
}
