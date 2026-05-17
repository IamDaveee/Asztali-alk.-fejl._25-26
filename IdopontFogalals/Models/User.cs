using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdopontFogalals
{
    internal class User
    {
        public int id {  get; set; }
        public string username { get; set; }
        public string passwordHash { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
}
