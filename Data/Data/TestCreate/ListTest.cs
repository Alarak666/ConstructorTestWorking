using Data.CoreDefaults.Enum;
using static System.Net.Mime.MediaTypeNames;

namespace Data.Data.TestCreate
{
   public class ListTest
    {
        public string Question { get; set; } = string.Empty;
        public List<string> Answers { get; set; }
        public List<string> CorectAnswers { get; set; }
        public string? Photo { get; set; }
        public int Point { get; set; }
        public ListTest()
        {
            Answers = new List<string>();
            CorectAnswers = new List<string>();
        }
    }
}
