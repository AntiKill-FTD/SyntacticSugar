using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticSugar
{
    /// <summary>
    /// 隐式类型
    /// </summary>
    public class ImplicitType
    {
        //成员变量
        public string memberVariable = "成员变量字符串";

        //1.上下文关键字"var"只能出现在局部变量申明和脚本中
        //private var myVariable = 1;

        /// <summary>
        /// 构造函数
        /// </summary>
        public ImplicitType()
        {
            //2.隐式变量的类型必须必须已初始化
            //var myVariable;

            //3.无法将string隐式转换为int
            //var myVariable = 1;
            //myVariable = "123";

            var memberVariable = "局部变量字符串";
            this.memberVariable = memberVariable;
        }
    }
}
