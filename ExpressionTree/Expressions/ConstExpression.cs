using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree.Expressions
{
    public class ConstExpression : BaseExpression
    {
        private int number;

        public ConstExpression(int number)
        {
            this.number = number;
        }

        public override int Compile()
        {
            return this.number;
        }
    }
}
