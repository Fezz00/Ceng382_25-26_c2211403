using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using RazorPages.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RazorPages.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            var usersFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "users.json");
            var json = System.IO.File.ReadAllText(usersFile);
            var users = JsonSerializer.Deserialize<List<User>>(json);

            var user = users.FirstOrDefault(u => u.Username == Username && u.Password == Password && u.IsActive);

            if (user == null)
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }

            // Store session values
            HttpContext.Session.SetString("username", Username);
            HttpContext.Session.SetString("role", user.Role); 
            HttpContext.Session.SetString("isActive", user.IsActive.ToString()); 
            HttpContext.Session.SetString("createdAt", user.CreatedAt.ToString("yyyy-MM-dd"));
            HttpContext.Session.SetString("token", Guid.NewGuid().ToString());
            HttpContext.Session.SetString("session_id", HttpContext.Session.Id);

            return RedirectToPage("/Index");
        }
    }
}