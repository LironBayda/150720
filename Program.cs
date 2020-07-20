using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150720
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen = new Citizen("Gabi", 100000000);
            Citizen citizenkid1 = new Citizen("Dana", 100000001);
            Citizen citizenkid2 = new Citizen("mor", 100000001);
            Citizen citizenkid3 = new Citizen("Dan", 100000001);
            Citizen[] kids = { citizenkid1, citizenkid2 };
            citizen.setChildren(kids);
            Citizen[] kid3 = { citizenkid3 };
            citizen.setChildren(kid3);
        



        }

        private static bool CheckValidity(Citizen citizen)
        {
            if (HasChildren(citizen))
            {
                for (int i = 0; i < citizen._children.Length; i++)
                {
                    Console.WriteLine($"citizen._children[i]._fhatherID:{citizen._children[i]._fhatherID} citizen._ID { citizen._ID}");

                    if (citizen._children[i]._fhatherID != citizen._ID)
                        return false;
                }
            }
            return true;
        }

        private static bool HasChildren(Citizen citizen)
        {
            return citizen._children != null;
        }
    }
}
