namespace RazorPages.Models
{
    public class ClassInformationModel
    {
        private static int _idCounter = 1; // Static counter for generating unique IDs.

        public int Id { get; private set; } // ID property.
        public string? ClassName { get; set; } // Class name property.
        public int? StudentCount { get; set; } // Student count property.
        public string? Description { get; set; } // Description property.

        // Parameterless constructor
        public ClassInformationModel()
        {
            // Assign ID on creation, and increment it.
            Id = _idCounter++;
        }
    }
}
