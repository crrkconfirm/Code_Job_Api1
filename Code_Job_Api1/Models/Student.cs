using System.Xml.Linq;

namespace Code_Job_Api1.Models
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();
    }
}
