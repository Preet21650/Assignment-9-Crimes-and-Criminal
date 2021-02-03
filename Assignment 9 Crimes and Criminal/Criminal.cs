using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Criminal
    {
        private string Name;
        private int Age;
        private Crime[] CrimesComitted;

        public Criminal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            CrimesComitted = new Crime[10];
        }

        //Accessors
        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }

        public Crime GetCrime(int i)
        {
            if (i <= CountCrime())
            {
                return CrimesComitted[i];
            }
            else
            {
                return null;
            }
        }

        //Mutator
        public bool AddCrime(Crime CrimesToAdd)
        {
            int CrimesCount = CountCrime();
            if (CrimesCount < CrimesComitted.Length)
            {
                CrimesComitted[CrimesCount] = CrimesToAdd;
                return true;
            }
            return false;
        }

        public int CountCrime()
        {
            for (int i = 0; i < CrimesComitted.Length; i += 1)
            {
                if (CrimesComitted[i] == null)
                {
                    return i;
                }
            }
            return CrimesComitted.Length;
        }
    }
}