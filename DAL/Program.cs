using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace votes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PartyDal.GetVotesByID(4));
            Console.ReadKey();

        }
    }
}
