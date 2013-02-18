using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class ArithmeticalExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //string ss = "33.0 4 /";
        //string ss = "3 4 - 5 +";
        //string ss = Console.ReadLine();
        //Console.WriteLine(Solve(ss));

        Console.WriteLine("Currently not working for functions.");

        Console.WriteLine("Enter an expression.");
        string expr = Console.ReadLine();

        Console.WriteLine(Solve(ParseToRPN(expr)));
    }

    static string ParseToRPN(string input)
    {
        StringBuilder output = new StringBuilder();
        Stack<string> stack = new Stack<string>();

        string[] tokens = input.Split(' ');

        foreach (var token in tokens)
        {
            double num = 0;
            if (double.TryParse(token, out num))
            {
                output.Append(num + " ");
            }
            else if (IsFunction(token))
            {
                stack.Push(token);
            }
            else if (token == ",")
            {
                bool pe = false;
                while (stack.Count > 0)
                {
                    if (stack.Peek() == "(")
                    {
                        pe = true;
                        break;
                    }
                    else
                    {
                        output.Append(stack.Pop() + " ");
                    }
                }

                if (!pe)
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (IsOperator(token))
            {
                while (stack.Count > 0)
                {
                    string o2 = stack.Peek();

                    if (IsOperator(o2) &&
                        (GetOperatorPrecedence(token) <= GetOperatorPrecedence(o2)) ||
                        (GetOperatorPrecedence(token) < GetOperatorPrecedence(o2)))
                    {
                        output.Append(stack.Pop() + " ");
                    }
                    else
                    {
                        break;
                    }
                }

                stack.Push(token);
            }
            else if (token == "(")
            {
                stack.Push(token);
            }
            else if (token == ")")
            {
                bool pe = false;

                while (stack.Count > 0)
                {
                    if (stack.Peek() == "(")
                    {
                        pe = true;
                        break;
                    }
                    else
                    {
                        output.Append(stack.Pop() + " ");
                    }
                }

                if (!pe)
                {
                    Console.WriteLine("Error!");
                }

                stack.Pop();

                if (stack.Count > 0)
                {
                    if (IsFunction(stack.Peek()))
                    {
                        output.Append(stack.Pop() + " ");
                    }
                }
            }
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == "(" || stack.Peek() == ")")
            {
                throw new Exception();
            }

            output.Append(stack.Pop());
        }

        return output.ToString();
    }

    private static int GetOperatorPrecedence(string oprToken)
    {
        if (oprToken == "*" || oprToken == "/")
            return 1;
        return 0;
    }

    private static bool IsFunction(string token)
    {
        return false;
    }

    private static bool IsOperator(string token)
    {
        string[] operators = 
        {
            "+", "-", "*", "/", "%"
        };

        foreach (var s in operators)
        {
            if (token == s)
            {
                return true;
            }
        }

        return false;
    }

    static double Solve(string rpnString)
    {
        string[] tokens = rpnString.Split(' ');

        Stack<double> values = new Stack<double>();

        foreach (var token in tokens)
        {
            double value = 0;
            if (double.TryParse(token, out value))
            {
                values.Push(value);
            }
            else
            {
                List<double> ls = new List<double>();
                while (values.Count > 0)
                {
                    ls.Add(values.Pop());
                }

                double res = ExecuteOperation(ls.ToArray(), token);
                values.Push(res);

            }
        }

        if (values.Count == 1)
        {
            return values.Pop();
        }
        else
        {
            throw new ArgumentException(
                "Wrong arguments");
        }
    }

    static double ExecuteOperation(double[] operands, string operation)
    {
        int n = operands.Length;

        double result = operands[n - 1];

        for (int i = n - 2; i >= 0; i--)
        {
            switch (operation)
            {
                case "+":
                    result += operands[i];
                    break;
                case "-":
                    result -= operands[i];
                    break;
                case "*":
                    result *= operands[i];
                    break;
                case "/":
                    result /= operands[i];
                    break;
                case "%":
                    result %= operands[i];
                    break;
            }
        }

        return result;
    }
}

