using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTMS.App.Entity;
using MTMS.App.Data;
using System.Data;

namespace MTMS.App.Repository
{
    public class MemberRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "Me-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Member;");
            if (dt == null || dt.Rows.Count == 0)
            {
                int number = 100;
                return number;
            }
            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["memberId"].ToString();

                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                return number;
            }
        }

        public List<Member> GetAll(string query)
        {
            var memberList = new List<Member>();
            if (query == null)
            {
                query = "select * from Member;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Member member = ConvertToEntity(dt.Rows[index]);
                memberList.Add(member);
            }
            return memberList;
        }

        private Member ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var member = new Member();

            member.Id = Convert.ToInt32(row["id"].ToString());
            member.MemberId = row["memberId"].ToString();
            member.MemberName = row["memberName"].ToString();
            member.RewardPoint = Convert.ToInt32(row["rewardPoint"].ToString());
            member.MemberPhoneNo = row["memberPhoneNo"].ToString();
            member.MemberEmail = row["memberEmail"].ToString();


            return member;
        }

        public bool Save(Member member)
        {
            try
            {

                string query = "select * from Member where memberId = '" + member.MemberId + "'";
                var dtt = DataAccess.GetDataTable(query);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    query = "Insert into Member values ('" + member.MemberId + "','" + member.MemberName + "','" + member.MemberPhoneNo + "','" + member.RewardPoint + "','" + member.MemberEmail + "');";

                }
                else
                {
                    query = "Update Member set memberName = '" + member.MemberName + "',memberPhoneNo= '" + member.MemberPhoneNo + "', rewardPoint= '" + member.RewardPoint + "', memberEmail= '" + member.MemberEmail + "' where memberId = '" + member.MemberId + "';";
                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string memberid)
        {
            try
            {
                string query = "select * from Member where memberId = '" + memberid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Member where memberId = '" + memberid + "'";
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }

        public Member GetMember(string memberId)
        {
            var sql = "select * from Member where memberId='" + memberId + "'";
            var dt = DataAccess.GetDataTable(sql);
            var member = ConvertToEntity(dt.Rows[0]);
            return member;
        }

        public bool UpdateReward(string memberId,int rewardPoint)
        {
            try
            {
                var sql = "Update Member set rewardPoint = '" + rewardPoint + "' where memberId = '" + memberId + "'";
                int count = DataAccess.ExecuteUpdateQuery(sql);
                if (count >= 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
