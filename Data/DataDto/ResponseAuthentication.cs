using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ResponseDto
{
    public class ResponseAuthentication
    {
        public bool Success { get; set; }
        public string Name { get; set; }
        public Guid? UserId  { get; set; }

    }
}
