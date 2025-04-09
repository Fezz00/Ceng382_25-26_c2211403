using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using RazorPages.Models;
using System.Linq;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        private static List<ClassInformationModel> _classList = new List<ClassInformationModel>();

        public List<ClassInformationModel> ClassList => _classList;

        public void OnGet()
        {
        }

        public IActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newEntry = new ClassInformationModel
            {
                Id = ClassInformationModel.GetNextId(),
                ClassName = NewClass.ClassName,
                StudentCount = NewClass.StudentCount,
                Description = NewClass.Description
            };

            _classList.Add(newEntry);

            return RedirectToPage();
        }


        public IActionResult OnPostDelete(int id)
        {
            var item = _classList.Find(c => c.Id == id);
            if (item != null)
            {
                _classList.Remove(item);
            }

            return RedirectToPage();
        }

        public IActionResult OnPostEdit(int id, string ClassName, int StudentCount, string Description)
        {
            var item = _classList.FirstOrDefault(c => c.Id == id);
            if (item != null)
            {
                item.ClassName = ClassName;
                item.StudentCount = StudentCount;
                item.Description = Description;
            }

            return RedirectToPage();
        }
    }
}
