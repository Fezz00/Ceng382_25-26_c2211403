using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        [BindProperty(SupportsGet = true)]
        public string? FilterName { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public int TotalPages { get; set; }

        public List<ClassInformationTable> ClassList { get; set; } = new List<ClassInformationTable>();

        private static List<ClassInformationModel> _classList = new List<ClassInformationModel>();

        public void OnGet()
        {
            if (_classList.Count == 0)
            {
                for (int i = 1; i <= 100; i++)
                {
                    _classList.Add(new ClassInformationModel
                    {
                        Id = ClassInformationModel.GetNextId(),
                        ClassName = $"Class {i}",
                        StudentCount = 10 + (i % 5),
                        Description = $"Description for Class {i}"
                    });
                }
            }

            var filtered = string.IsNullOrEmpty(FilterName) ? _classList : _classList.Where(c => c.ClassName != null && c.ClassName.Contains(FilterName)).ToList();

            TotalPages = (int)System.Math.Ceiling((double)filtered.Count / PageSize);

            filtered = filtered
                        .Skip((CurrentPage - 1) * PageSize)
                        .Take(PageSize)
                        .ToList();

            ClassList = filtered.Select(c => new ClassInformationTable
            {
                Id = c.Id,
                ClassName = c.ClassName,
                StudentCount = c.StudentCount,
                Description = c.Description
            }).ToList();
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
            
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddMinutes(30),
                HttpOnly = true,
                Secure = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict
            };

            Response.Cookies.Append("username", "sampleUser", cookieOptions);
            Response.Cookies.Append("role", "admin", cookieOptions);
            Response.Cookies.Append("isActive", "true", cookieOptions);
            Response.Cookies.Append("createdAt", DateTime.UtcNow.ToString("o"), cookieOptions);
            
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
