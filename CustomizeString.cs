using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class CustomizeString
    {
        public void Customize()
        {
            string line = "Hello <<name>>, we have full name as <<full name>> in my system and your contact Number is 91-xxxxxxxxxx ";
            line = line.Replace("<<name>>", "Mukul");
            line = line.Replace("<<full name>>", "Mukul Dev Patel");
            line = line.Replace("91-xxxxxxxxxx", "91-5426795645");
            Console.WriteLine(line);
        }
    }
}
