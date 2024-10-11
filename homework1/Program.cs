using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. გადაიყვანეთ შემდეგი ათობითი რიცხვები ორობითში:
            // 17-10001
            // 34-100010
            // 255-11111111

            Console.WriteLine("atobitis orobitshi gadayvana");
            Console.WriteLine("17 - 10001");
            Console.WriteLine("34 - 100010");
            Console.WriteLine("255 - 11111111");

            Console.WriteLine();
            //2. გადაიყვანეთ შემდეგი ორობითი რიცხვები ათობითში:
            // 10101 - 21
            // 110011 - 51
            // 10000000 - 128

            Console.WriteLine("orobitis atobitshi gadayvana");
            Console.WriteLine("10101 - 21");
            Console.WriteLine("110011 - 51");
            Console.WriteLine("10000000 - 128");

            Console.WriteLine();

            //3. განმარტეთ რას ნიშნავს ცვლადი C# ში, როგორ შეგვიძლია მისი გამოცხადება
            // და ინიციალიზაცია. მოიყვანეთ რამდენიმე მაგალითი
            
            
            // C#-ში ცვლადი არის ადგილი მეხსიერებაში, სადაც შესაძლებელია
            // მონაცემების შენახვა, შეცვლა და მოძიება.
            // თითოეულ ცვლადს აქვს ტიპი, რომელიც განსაზღვრავს,
            // თუ რა სახის მონაცემების შენახვა შეუძლია მას.
            // მონაცემების სახეები: რიცხვები, ტექსტი ან უფრო რთული ობიექტები.

            int age;
            age = 20;
            Console.WriteLine("age" + " " + age);

            String name;
            name = "luka";
            Console.WriteLine("name" + " " + name);

            double salary;
            salary = 9999.99;
            Console.WriteLine("salary" + " " + salary);

            bool information;
            information = true;
            Console.WriteLine("information" + " " + information);


        }
    }
}
