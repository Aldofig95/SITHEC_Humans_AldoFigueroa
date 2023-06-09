using Entities;
using System.ComponentModel;

namespace Extensions
{
    public static class SithecExtensions
    {
        public static MathOperation GetMathOperation(this string operationCode)
        {
            return operationCode switch
            {
                "add" => MathOperation.Add,
                "sub" => MathOperation.Sub,
                "mul" => MathOperation.Mul,
                "div" => MathOperation.Div,
                _ => throw new InvalidEnumArgumentException(),
            };
        }
    }
}