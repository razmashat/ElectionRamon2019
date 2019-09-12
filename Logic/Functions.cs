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
                Parties[i] = new Party(i + 1);
            }
        }
        /// <summary>
        /// login function to use in ui, first check if admin using IsAdmin()
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



        public static void GetMandats()
        {
            int TotalVotes = AdminDal.GetTotalVotes();
            int Mandat = TotalVotes / 120;
            int[] LeftOverVotes = new int[31];
            int TotalMandats = 0;
            double BlockPrecents = TotalVotes / 100 * 3.25;
            for (int i = 0; i < 31; i++)
            {
                if (Parties[i].PartyVotes <= BlockPrecents)
                {
                    TotalVotes -= Parties[i].PartyVotes;
                    //Parties[i].PartyVotes = 0;
                }
            }
            Mandat = TotalVotes / 120;
            for (int i = 0; i < 31; i++)
            {
                if (Parties[i].PartyVotes > BlockPrecents)
                {
                    Parties[i].Mandats = Parties[i].PartyVotes / Mandat;
                    TotalMandats += Parties[i].Mandats;
                    LeftOverVotes[i] = Parties[i].PartyVotes - (Parties[i].Mandats * Mandat);
                }
             
            }

            for (int i = TotalMandats; i < 120; i++)
            {
                int MandatID = -1;
                int MandatVotes = -1;
                for (int j = 0; j < 31; j++)
                {
                    if (LeftOverVotes[j] > MandatVotes  )
                    {
                        MandatVotes = LeftOverVotes[j];
                        MandatID = j;
                    }
                }
                LeftOverVotes[MandatID] = 0;
                Parties[MandatID].Mandats++;
            }

        }

       public static bool IsAdmin(string id)
       {
            return AdminDal.IsAdmin(id);
       }

       public static bool DoVote(string id)
       {
            return IdDal.Vote(id);
       }
       
       public static bool DidVote(string id)
       {
            return IdDal.DidVote(id);
       }


    }
}
