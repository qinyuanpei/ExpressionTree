using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree.Expressions
{
    public class BaseExpression
    {
        public virtual int Compile()
        {
            return -1;
        }
    }
}
