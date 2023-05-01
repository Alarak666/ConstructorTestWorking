using Data.CoreDefaults.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDto
{
    public class UserInServer
    {
       public  List<string> UserInServers = new List<string>();
        public TypeRequest typeRequest = TypeRequest.GetUserInServer;
    }
}
