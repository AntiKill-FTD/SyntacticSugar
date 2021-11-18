using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticSugar
{
    public class DefaultParameters
    {
        public DefaultParameters()
        {

        }

        public void MyFunc1(string name, string sex, string age, string country = "China")
        {

        }
    }
}
