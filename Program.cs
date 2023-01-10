// See https://aka.ms/new-console-template for more information
namespace LinkedList
{
public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList List = new LinkedList();


            List.Add(56);
            List.Add(70);
            List.toprint();

            int a = List.Search(56);
            Console.WriteLine("Index Position Of 56 is " + a);
            List.InsertParticularPosition(a + 1, 30);

            //List.Add(56);
            //List.Add(30);
            //List.Add(70);
            List.toprint();
        }
    }
}
