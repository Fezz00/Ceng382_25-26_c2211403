using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        // Bind property to handle new class data
        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        // Static list to store classes and persist data across page reloads
        private static List<ClassInformationModel> _classList = new List<ClassInformationModel>();

        // Property to access the static class list in the view
        public List<ClassInformationModel> ClassList => _classList;

        // Handler for displaying the page
        public void OnGet()
        {
            // Data is already populated from the static list
        }

        // Handler for adding a new class
        public IActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add a new class to the list with a unique ID generated in the model's constructor
            _classList.Add(new ClassInformationModel
            {
                ClassName = NewClass.ClassName,
                StudentCount = NewClass.StudentCount,
                Description = NewClass.Description
            });

            // Redirect to refresh the page and show updated list
            return RedirectToPage();
        }

        // Handler for deleting a class by Id
        public IActionResult OnPostDelete(int id)
        {
            var item = _classList.Find(c => c.Id == id);
            if (item != null)
            {
                _classList.Remove(item);
            }

            return RedirectToPage();
        }
    }
}
