using Data.Data.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.TestCreate
{
    public class Test
    {
        public Guid id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string InfoTestTaker { get; set; } = string.Empty;
        public string TestName { get; set; } = string.Empty;
        public string CreatedName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal MaxPoint { get; set; }
        public int CountQuestion { get; set; }
        public decimal Percent { get; set; }
        public List<ListTest> listTests { get; set; } = new List<ListTest>();
    }
}
