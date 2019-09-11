using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace votes
{
   public class PartyDal
    {
        /// <summary>
        /// gets the code of a party and raises its vote counter by 1
        /// </summary>
        /// <param name="PCode">the code of a party</param>
        public static void AddVote(int PCode)
        {
            if (!IsExist(PCode))
                throw new Exception("InValid Party");
            string sql = "SELECT PVotes FROM PartyTBL WHERE PCode=" + PCode;
            DataSet ds = OleDbHelper.Fill(sql, "PartyTBL");
            int prevVotes = int.Parse(ds.Tables["PartyTBL"].Rows[0]["PVotes"].ToString());
            prevVotes++;
            sql = "UPDATE PartyTBL SET PVotes=" + prevVotes+" WHERE PCode="+PCode;
            OleDbHelper.DoQuery(sql);
        }
        private static bool IsExist(int PCode)
        {
            string sql = "SELECT * FROM PartyTBL WHERE PCode=" + PCode;
            DataSet ds = OleDbHelper.Fill(sql, "PartyTBL");
            return ds.Tables["PartyTBL"].Rows.Count > 0;
        }

        public static DataSet GetVotes()
        {
            string sql = "SELECT PCode,PVotes FROM PartyTBL";
            return OleDbHelper.Fill(sql, "PartyTBL");
        }

        public static string GetName(int id)
        {

            string sql = "SELECT PName FROM PartyTBL WHERE PCode = " + id;
            DataSet ds = OleDbHelper.Fill(sql, "PartyTBL");
            return ds.Tables["PartyTBL"].Rows[0]["PName"].ToString();

        }
    }
}
