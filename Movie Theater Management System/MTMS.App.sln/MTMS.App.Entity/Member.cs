using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Member
    {
        public int Id { set; get; }
        public string MemberId { set; get; }
        public string MemberName { set; get; }
        public string MemberPhoneNo { set; get; }
        public int RewardPoint { set; get; }
        public string MemberEmail { set; get; }
    }
}
