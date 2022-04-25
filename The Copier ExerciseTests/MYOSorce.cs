using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Copier_Exercise;

namespace The_Copier_ExerciseTests
{
    class MYOSorce : ISource
    {
        string sorce;
        private int x = 0;

        MYOSorce(string _sorce)
        {
            if (_sorce[_sorce.Length - 1] != '\n')
            {
                sorce = _sorce + '\n';
            }
            else
            {
                sorce = _sorce;
            }
            
        }
        public char GetChar()
        {
            return sorce[x++]; //returns sorce at index x befor incrementing
        }

        
    }
}
