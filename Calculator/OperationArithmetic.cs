using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationArithmetic
    {
        public string Operation(string numA,string arith, string numB) 
        {
            float requite = 0;
            switch (arith) 
            {
                case "+":
                    requite = float.Parse(numA) + float.Parse(numB);
                    break;
                case "-":
                    requite = float.Parse(numA) - float.Parse(numB);
                    break;
                case "*":
                    requite = float.Parse(numA) * float.Parse(numB); 
                    break;
                case "/":
                    requite = float.Parse(numA) / float.Parse(numB); 
                    break;
            }
            return requite.ToString();
        }


    }
}
