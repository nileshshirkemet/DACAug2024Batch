using DemoApp.Data.Shopping;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.PageModels;

[ResponseCache(NoStore = true)]
public class DetailModel(ShopDbContext shop) : PageModel
{
    public Customer Output { get; set; }

    public async Task OnGetAsync()
    {
        Output = await shop.Customers.FindAsync(User.Identity.Name);
        await shop.Entry(Output).Collection(p => p.Orders).LoadAsync();
    }

    public async Task<IActionResult> OnGetLogoutAsync()
    {
        await HttpContext.SignOutAsync();
        return RedirectToPage("Index");
    }
}
