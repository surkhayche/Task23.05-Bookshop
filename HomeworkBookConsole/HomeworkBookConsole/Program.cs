namespace HomeworkBookConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book1 = new Book(1, "Elekecmez yaguar", 19.99, "Dedektiv");
           Book book2 = new Book(2, "Cehennemden gelen ses", 15.99, "Dedektiv,Triller");
           Book book3 = new Book(3, "En yaxin planet", 10, "Dedektiv,Kriminal");
           Book book4 = new Book(4, "Qan lekesi", 19.99, "Dedektiv,Dram");
           Book book5 = new Book(5, "Bakidan gelen xefiyye", 19.99, "Dedektiv");

            Console.WriteLine(book4.Genre);
        }
    }
}
