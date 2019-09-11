using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using votes;
using System.Data;

namespace Logic
{
    public class Functions
    {


        public static Party[] Parties = new Party[31];

        public static void InitArr()
        {
            for (int i = 0; i < Parties.Length; i++)
            {
                Parties[i] = new Party(i + 1, PartyDal.GetName(i));
            }
        }
        /// <summary>
        /// login function to use in ui
        /// </summary>
        /// <param name="id"> id number in string</param>
        /// <returns>true if exists and didnt voted else false</returns>
        public static bool Login(string id)
        {

            if (IdDal.Exists(id) && !IdDal.DidVote(id))
            {
                return true;
            }
            return false;


        }
        public static int GetTotalVotes()
        {
            return AdminDal.GetTotalVotes();
        }
        /// <summary>
        /// get party total votes
        /// </summary>
        /// <param name="id"> the id of the party</param>
        /// <returns>return the total num of votes by party id</returns>
        public static int GetVotesOfPartyByID(int id)
        {

            return Parties[id].PartyVotes;
        }

        /// <summary>
        /// get total votes of all praties
        /// </summary>
        /// <returns>total votes of all parties</returns>
        public static void GetAllVotes()
        {
            for (int i = 1; i <= 31; i++)
            {
                Parties[i].PartyVotes = GetVotesOfPartyByID(i);
            }
        }


        public static void GetMandats()
        {

            for (int i = 1; i <= 31; i++)
            {

            }

        }

       




    }
}
