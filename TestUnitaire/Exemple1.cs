using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    public class Exemple1
    {
        public int GetMaxNumber(string pathFolder)
        {
            string[] lines = System.IO.File.ReadAllLines(pathFolder);

            int result = 0;
            foreach (string line in lines)
            {
                if (result < Convert.ToInt32(line))
                {
                    result = Convert.ToInt32(line);
                }
            }
            
            return result;
        }
    }
}
