using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votes
{
    public class Party
    {
        public int PartyID { get; private set; }
        public string name
        {
            get
            { return PartyDal.GetName(PartyID); }
        }

        public int PartyVotes
        {
            get { return PartyDal.GetVotesByID(PartyID); }
        }

        public int Mandats { get; set; }


        public Party(int ID)
        {
            this.PartyID = ID;
            this.Mandats = 0;

        }

        public void AddVote()
        {
            PartyDal.AddVote(PartyID);
        }




    }
}
