using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace votes
{
    public class AdminDal
    {
        /// <summary>
        /// check if a given id is an admin
        /// </summary>
        /// <param name="id">the id of the person</param>
        /// <returns>true: the id is an admin, else false</returns>
        public static bool IsAdmin(string id)
        {
            string sql = "SELECT * FROM AdminTBL WHERE AId='"+id+"'";
            DataSet ds = OleDbHelper.Fill(sql, "AdminTBL");
            return ds.Tables["AdminTBL"].Rows.Count > 0;               
        }

        public static int GetTotalVotes()
        {
            string sql = "SELECT SUM(PVotes) FROM PartyTBL";
            DataSet ds = OleDbHelper.Fill(sql, "PartyTBL");
            return int.Parse(ds.Tables["PartyTBL"].Rows[0]["Sum(PVotes)"].ToString());
        }

        
    }
}
