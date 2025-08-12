using LibCommons.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FriendThingsFinder.Pages.LogIn
{
    public class LogInModel : PageModel
    {
        private LogInClient _client;

        [BindProperty]
        public string Username { get; set; } = "";
        [BindProperty]
        public string Password { get; set; } = "";

        public string Message { get; set; }

        public LogInModel(LogInClient client)
        {
            _client = client;
        }

        public void OnGet()
        {
        }
    }
}
