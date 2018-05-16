using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree.Expressions
{
    public class DivideExpression:BaseExpression
    {
        private BaseExpression exp1;
        private BaseExpression exp2;

        public DivideExpression(BaseExpression exp1,BaseExpression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override int Compile()
        {
            return exp1.Compile() / exp2.Compile();
        }
    }
}
