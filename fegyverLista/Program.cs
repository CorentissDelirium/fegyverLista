using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverLista
{
    class Program
    {
        enum fegyverek {Apa_Ökle, UZI, BFG9000, M4A1, kézigránát, lángszóró};
        static void Main(string[] args)
        {
            fegyverek kézben = fegyverek.kézigránát;
            List<fegyverek> inventory = new List<fegyverek>();
            inventory.Add(fegyverek.UZI);
            inventory.Add(fegyverek.lángszóró);
            foreach (fegyverek item in inventory)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
