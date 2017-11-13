using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var opCode = Console.ReadLine();

            while (opCode != "END")
            {
                var codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne++;
                            result = operandOne;
                        opCode = Console.ReadLine();

                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne--;
                            result = operandOne;
                        opCode = Console.ReadLine();

                            break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        opCode = Console.ReadLine();

                            break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);

                        result = operandOne * operandTwo;
                        opCode = Console.ReadLine();

                            break;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
