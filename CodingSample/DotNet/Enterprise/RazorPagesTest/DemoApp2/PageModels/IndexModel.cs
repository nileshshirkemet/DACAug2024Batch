using System.Security.Claims;
using DemoApp.Data.Shopping;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.PageModels;

public class IndexModel(ShopDbContext shop) : PageModel
{
    [BindProperty]
    public Customer Input { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        if(ModelState.IsValid)
        {
            var customer = await shop.Customers.FindAsync(Input.Id);
            if(customer?.Password == Input.Password)
            {
                var identity = new ClaimsIdentity("Customer");
                identity.AddClaim(new Claim(ClaimTypes.Name, Input.Id));
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                return RedirectToPage("Detail");
            }
            else
            {
                ModelState.AddModelError("Login", "Invalid Customer ID or Password");
            }
        }
        return Page();
    }
}