using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWeb.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string FirstName = "";
        public string LastName = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            FirstName = Request.Form["FirstName"];
            LastName = Request.Form["LastName"];
            message = Request.Form["message"];
        }
    }    
}
