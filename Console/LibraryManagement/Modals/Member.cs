using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Modals
{

    [Serializable]
    internal class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; } = string.Empty;
        
    }
}
