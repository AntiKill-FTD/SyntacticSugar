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

        /// <summary>
        /// 默认参数测
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        /// <param name="country"></param>
        public void MyFunc1(string name, string sex, string age, string country = "China")
        {

        }
    }
}
