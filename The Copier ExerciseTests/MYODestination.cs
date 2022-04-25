using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Copier_Exercise;


namespace The_Copier_ExerciseTests
{
    
    class MYODestination : IDestination
    {
        string destination = "";
        int x = 0;

        public void SetChar(char _char)
        {

            destination += _char;
            x++;
        }
    }
}
