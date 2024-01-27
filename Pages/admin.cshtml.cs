using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IDentityDemo.Pages;

[Authorize(Roles = "admin")]
public class AdminModel : PageModel
{
    public AdminModel()
    {

    }

    public void OnGet()
    {

    }
}