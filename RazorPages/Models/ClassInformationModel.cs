namespace RazorPages.Models
{
    public class ClassInformationModel
    {
        private static int _idCounter = 1;

        public int Id { get; set; }  // changed from private set to public set
        public string? ClassName { get; set; }
        public int? StudentCount { get; set; }
        public string? Description { get; set; }

        public static int GetNextId()
        {
            return _idCounter++;
        }

        public static void ResetIdCounter()
        {
            _idCounter = 1;
        }
    }
}