using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace votes
{
    class IdDal
    {
        /// <summary>
        /// checks if someone voted already
        /// </summary>
        /// possible exeption: if the id is not in the data base. need to run Exists before this method 
        /// <param name="id">the id of the person</param>
        /// <returns>true: the person voted already, else false</returns>
        public static bool DidVote(string id)
        {
            string sql = "SELECT * FROM IdTBL WHERE IId='" + id + "'";
            DataSet ds = OleDbHelper.Fill(sql, "IdTBL");
            return bool.Parse(ds.Tables["IdTBL"].Rows[0]["IVoted"].ToString());
        }
        
        /// <summary>
        /// checks if an id exists in the data base
        /// </summary>
        /// <param name="id">the id</param>
        /// <returns>true: the id exists in the data base, else false</returns>
        private static bool Exists(string id)
        {
            string sql = "SELECT * FROM IdTBL WHERE IId='" + id + "'";
            DataSet ds = OleDbHelper.Fill(sql, "IdTBL");
            return ds.Tables["IdTBL"].Rows.Count > 0;
        }

        /// <summary>
        /// make it that a person voted in the data base
        /// </summary>
        /// <param name="id">the id of the person</param>
        public static void Vote(string id)
        {
            if (!Exists(id))
                throw new Exception("InValid ID");
            string sql = "UPDATE IdTBL SET IVoted=TRUE WHERE IId='" + id + "'";
            OleDbHelper.DoQuery(sql);
        }
    }
}
