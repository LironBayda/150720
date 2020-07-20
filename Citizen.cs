using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150720
{
    class Citizen
    {
        public string _name;
         public  Citizen[] _children;
        public readonly int _fhatherID;
        public readonly int _ID;

        public static int _numberOfCurrentCitizens=0;
        public  const int _maximumNumberOfCurrentCitizens=10000000;

        public Citizen(string name, int fatherID)
        {
            _name = name;
            _children = null;
            _fhatherID = fatherID;
            _numberOfCurrentCitizens++;
            if (_numberOfCurrentCitizens == _maximumNumberOfCurrentCitizens)
                Console.WriteLine("nummber of citizens reach the maximum.you cant make anther one");
            _ID = 100000000 + _numberOfCurrentCitizens;

        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"number Of Current Citizens {_numberOfCurrentCitizens}");
        }

        public static bool ReachedHalfOfMaximumSize()
        {
            return _numberOfCurrentCitizens >= _maximumNumberOfCurrentCitizens;
        }

        public void PrintId()
        {
            Console.WriteLine($"ID: {_ID}");
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine($"the gap: {_ID - _fhatherID}"); 
        }

        public void setChildren(Citizen[] citizens)
        {
            if (_children == null)
            {
                _children = citizens;
            }
            else
            {
                Citizen[] temp =new Citizen[_children.Length+citizens.Length];
                for (int i = 0; i < _children.Length;i++)
                {
                    temp[i] = _children[i];
                }

                for (int i= _children.Length;i<temp.Length;i++)
                {
                    temp[i] = citizens[i- _children.Length];
                }

               
                _children =temp;
            }

        }
        public override string ToString()
        {
            return base.ToString()+$"_fhatherID: {_fhatherID} _ID: {_ID} _maximumNumberOfCurrentCitizens {_maximumNumberOfCurrentCitizens} _numberOfCurrentCitizens: {_numberOfCurrentCitizens} _name: {_name}";
        }
    }
}
