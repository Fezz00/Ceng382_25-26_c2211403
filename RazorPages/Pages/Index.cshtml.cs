using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SchoolDbContext _context;

        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        [BindProperty(SupportsGet = true)]
        public string? FilterName { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public int TotalPages { get; set; }

        public List<Class> ClassList { get; set; } = new List<Class>();

        private static List<Class> _classList = new List<Class>();

        // OnGetAsync method should be correctly implemented
        public async Task OnGetAsync()
        {
            // Fetch the classes from the database asynchronously
            IListClass = await _context.Classes.ToListAsync();

            // Apply filtering based on FilterName
            var filtered = string.IsNullOrEmpty(FilterName) ? IListClass : IListClass.Where(c => c.ClassName.Contains(FilterName)).ToList();

            // Calculate the total number of pages
            TotalPages = (int)Math.Ceiling((double)filtered.Count / PageSize);

            // Apply pagination (skip and take)
            filtered = filtered
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            // Convert the data to the table model (ClassInformationTable)
            ClassList = filtered.Select(c => new Class
            {
                Id = c.Id,
                ClassName = c.ClassName,
                StudentCount = c.StudentCount,
                Description = c.Description,
                isActive = c.isActive
            }).ToList();
        }


        // OnPostAdd method remains the same
// In Index.cshtml.cs
        public async Task<IActionResult> OnPostAddAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();  // If the model is invalid, re-render the page with error messages
            }

            var newClass = new Class
            {
                ClassName = NewClass.ClassName,
                StudentCount = NewClass.StudentCount,
                Description = NewClass.Description
            };

            // Add the new class to the database
            _context.Classes.Add(newClass);

            // Save changes to the database
            await _context.SaveChangesAsync();

            return RedirectToPage();  // Redirect to refresh the page and show the updated list
        }


                // OnPostDelete method remains the same
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var classToDelete = await _context.Classes.FindAsync(id);
            if (classToDelete != null)
            {
                classToDelete.isActive = false;
                //_context.Classes.Remove(classToDelete);  // Remove the class from the database
                await _context.SaveChangesAsync();  // Save changes to the database
            }

            return RedirectToPage();  // Redirect to refresh the page
        }


        // OnPostEdit method remains the same
        public async Task<IActionResult> OnPostEditAsync(int id)
        {
            var classToEdit = await _context.Classes.FindAsync(id);
            if (classToEdit != null)
            {
                // Update the class properties
                classToEdit.ClassName = NewClass.ClassName;
                classToEdit.StudentCount = NewClass.StudentCount;
                classToEdit.Description = NewClass.Description;

                await _context.SaveChangesAsync();  // Save changes to the database
            }

            return RedirectToPage();  // Redirect to refresh the page
        }


        // Constructor (ensure correct constructor for dependency injection)
        public IndexModel(SchoolDbContext context)
        {
            _context = context;
        }

        // List of Classes fetched from the database
        public IList<Class> IListClass { get; set; }
    }
}
