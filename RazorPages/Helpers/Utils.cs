/*using RazorPages.Models;
using System.Text.Json;

namespace RazorPages.Helpers
{
    public class Utils
    {
        private static Utils _instance;
        private List<ClassInformationTable> _data;

        public static Utils Instance => _instance ??= new Utils();

        private Utils()
        {
            _data = new List<ClassInformationTable>();

            for (int i = 1; i <= 100; i++)
            {
                _data.Add(new ClassInformationTable
                {
                    Id = i,
                    ClassName = $"Class {i}",
                    StudentCount = i * 2,
                    Description = $"Description {i}"
                });
            }
        }

        public List<ClassInformationTable> GetData() => _data;

        public void AddData(ClassInformationTable item)
        {
            item.Id = _data.Max(x => x.Id) + 1;
            _data.Add(item);
        }

        public void EditData(int id, string className, int studentCount, string description)
        {
            var item = _data.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.ClassName = className;
                item.StudentCount = studentCount;
                item.Description = description;
            }
        }

        public void DeleteData(int id)
        {
            var item = _data.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _data.Remove(item);
            }
        }

        public string ExportToJson(List<ClassInformationTable> list)
        {
            return JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
*/