// See https://aka.ms/new-console-template for more information

namespace Lykos
{
    class Program
    {

        static void MyMethod(){
            Console.WriteLine("It's a function");
        }


        static void Main(string[] args)
        {
            Book b1 = new Book("Lord knows","Meek",213);
            
            Console.WriteLine(b1.title);
            MyMethod();
        }
    }
}