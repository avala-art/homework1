using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) შექმენით კონსოლური აპლიკაცია, რომელიც შეასრულებს მარტივ არითმეტიკულ ოპერაციებს რიცხვებზე.
            // * გამოაცხადეთ ორი ცვლადი
            // * შეასრულეთ მიმატების, გამოკლების, გამრავლების, გაყოფისა და ნაშთის ოპერაციები.
            // * შედეგები დაბეჭდეთ კონსოლში
            
            int num1 = 33;
            int num2 = 11;
            int PlusOperation;
            int MinusOperation;
            int MultipleOperation;
            int DivisionOperation;
            int DivisionDivisionOperation;
            PlusOperation = num1 + num2;
            MinusOperation = num1 - num2;
            MultipleOperation = num1 * num2;
            DivisionOperation = num1 / num2;
            DivisionDivisionOperation = num1 % num2;

            Console.WriteLine("PIRVELI DAVALEBIS PASUXEBI");
            Console.WriteLine("Mimatebis operiacia -" + " " + PlusOperation);
            Console.WriteLine("Gamoklebis operiacia -" + " " + MinusOperation);
            Console.WriteLine("Gamravlebis operiacia -" + " " + MultipleOperation);
            Console.WriteLine("Gayopis operiacia -" + " " + DivisionOperation);
            Console.WriteLine("Ganashtvis operiacia -" + " " + DivisionDivisionOperation);

            Console.WriteLine();
            //2) წარმოაჩინეთ float, double და decimal შორის სიზუსტის სხვაობა:
            // * შექმენით სამი ცვლადი float, double და decimal ტიპებით.
            // თითოეულს მიანიჭეთ მნიშვნელობად 1.0/7.0 ზე
            // * თითოეული ცვლადი გაამრავლეთ 7 ზე
            // * დაბეჭდეთ თითოეული შედეგი და შეადარეთ

            double value1 = 1.0 / 7.0;
            float value2 =(float)( 1.0 / 7.0);
            decimal value3 =(decimal)( 1.0 / 7.0);

            value1 *= 7;
            value2 *= 7;
            value3 *= 7;

            Console.WriteLine("MEORE DAVALEBIS PASUXEBI");
            Console.WriteLine("double result -" + " " + value1);
            Console.WriteLine("float result -" + " " + value2);
            Console.WriteLine("decimal result -" + " " + value3);
            Console.WriteLine();


            //3) გადაიყვანეთ სხვადასხვა მონაცემთა ტიპები განსხვავებულ ტიპებში
            // * გამოაცხადეთ int, double, float და decimal ტიპის ცვლადები
            // * მიანიჭეთ თითეულ მათგანს მნიშვნელობები
            // * შეასრულეთ explicit და implicit კონვერტაციებით ამ ტიპებს შორის (სადაც რომელია შესაძლებელი)

            int intValue = 10;
            double doubleValue = 4.5;
            float floatValue = 7.5f;
            decimal decimalValue = 15.25m;

            double fromIntToDouble = intValue;
            float fromDoubleToFloat = (float)doubleValue;
            int fromDoubleToInt = (int)doubleValue;
            int fromFloatToInt = (int)floatValue;
            decimal fromFloatToDecimal = (decimal)floatValue;

            Console.WriteLine("MESAME DAVALEBIS PASUXEBI");
            Console.WriteLine("Int to Double -" + " " + fromIntToDouble);
            Console.WriteLine("Double to Float -" + " " + fromDoubleToFloat);
            Console.WriteLine("Double to Int -" + " " + fromDoubleToInt);
            Console.WriteLine("Float to Int -" + " " + fromFloatToInt);
            Console.WriteLine("Float to Decimal -" + " " + fromFloatToDecimal);
            Console.WriteLine();


            //4) შექმენით კონსოლური აპლიკაცია, როკმელიც ორ ცვლადს მნიშვნელობას გაუცვლის.
            // მაგ.:
            // before:
            // int x = 5;
            // int b = 10;
            // 
            // after:
            // int x = 10;
            // int b - 5;

            int x = 5;
            int b = 10;
            int a;

            a = x;
            x = b;
            b = a;

            Console.WriteLine("MEOTXE DAVALEBIS PASUXEBI");
            Console.WriteLine("X udris -" + " " + x);
            Console.WriteLine("B udris -" + " " + b);

        }
    }
}
