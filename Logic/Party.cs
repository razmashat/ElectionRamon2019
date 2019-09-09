using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votes
{
    class Party
    {

        public int PartyID { get; private set; }
        public string name { get; private set; }

        public int PartyVotes { get; set; }

        public int Mandats { get; set; }


        public Party(int ID,string Name)
        {
            this.PartyID = ID;
            this.name = Name;
            this.PartyVotes = 0;
            this.Mandats = 0;

        }




    }
}
