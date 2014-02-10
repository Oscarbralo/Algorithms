using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;
using System.Text.RegularExpressions;

namespace TwoStackAlgorithm
{
    public class TwoStackAlgo
    {
        private Stack<int> values;
        private Stack<string> operators;

        const string oper = "+-*/";
        Regex numbers = new Regex("[0-9]");

        public TwoStackAlgo()
        {
            values = new Stack<int>();
            operators = new Stack<string>();
        }

        public int EvaluateExpression(string expression)
        {
            
            expression = expression.Replace(" ", "");
            int result = 0;
            if (expression.Count(x => x == '(') != expression.Count(x => x == ')'))
                return -1;
            for (int i = 0; i < expression.Length; i++)
            {
                if (numbers.IsMatch(expression[i].ToString()))
                    values.Push(int.Parse(expression[i].ToString()));
                else if (oper.Contains(expression[i]))
                    operators.Push(expression[i].ToString());
                else if (expression[i] == ')')
                {
                    result = DoOperations();
                    values.Push(result);
                }
            }
            while (values.Count() > 1)
            {
                result = DoOperations();
                values.Push(result);
            }
            return values.Pop();
        }

        public int DoOperations()
        {
            int result = 0;
            int operandRight = values.Pop();
            int operandLeft = values.Pop();
            string tempOperator = operators.Pop();
            switch (tempOperator)
            {
                case "+":
                    result += operandLeft + operandRight;
                    break;
                case "-":
                    result += operandLeft - operandRight;
                    break;
                case "*":
                    result += operandLeft * operandRight;
                    break;
                case "/":
                    result += operandLeft / operandRight;
                    break;
            }
            return result;
        }
    }
}
