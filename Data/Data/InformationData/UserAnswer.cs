using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.InformationData
{
    public class UserAnswer
    {
        public string Question { get; set; } = string.Empty;
        public List<string> Answer { get; set; } = new List<string>();
        public List<bool> IsSelected { get; set; } = new List<bool>();
    }
}
