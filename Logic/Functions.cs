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


        /// <summary>
        /// login function to use in ui
        /// </summary>
        /// <param name="id"> id number in string</param>
        /// <returns>true if if exists and didnt voted else false</returns>
        public static bool login(string id)
        {

            if (IdDal.Exists(id) && !IdDal.DidVote(id))
            {
                return true;
            }
            return false;


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
        public static int[] GetAllVotes()
        {

            int[] VotesArr = new int[31];
            for (int i = 1; i <= 31; i++)
            {
                VotesArr[i] = 0;
            }
            for (int i = 1; i <= 31; i++)
            {
                VotesArr[i] = GetVotesOfPartyByID(i);
            }

            return VotesArr;

        }

       




    }
}
