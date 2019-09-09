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
            DataSet ds = PartyDal.GetVotes();
            Console.ReadKey();
        }
    }
}
