using static System.Math;

namespace CIDM3312Exam2.Models
{



       public class MathOperation
    {
        public decimal LeftOperand {get; set;}

        public decimal RightOperand {get; set;}

        public List<T> Operator {get; set;}
       

        public decimal Result {get; set;}

         public static string Addition(decimal LeftOperand, decimal RightOperand)
        {
            return $"The sum of {LeftOperand} and {RightOperand} is: {LeftOperand + RightOperand}";
        }

        public static string Subtraction (decimal LeftOperand, decimal RightOperand)
        {
            return $"The difference of {LeftOperand} and {RightOperand} is: {LeftOperand - RightOperand}";
        }

        public static string Multiplication (decimal LeftOperand, decimal RightOperand)
        {
            return $"The product of {LeftOperand} and {RightOperand} is {LeftOperand * RightOperand}";
        }

        public static string Division (decimal LeftOperand, decimal RightOperand)
        {
            return $"The quotient of {LeftOperand} and {RightOperand} is {LeftOperand / RightOperand}";
        }
    }

         
        
    }

    


