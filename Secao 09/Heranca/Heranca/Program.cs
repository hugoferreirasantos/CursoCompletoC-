using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount acount = new BusinessAccount(8025,"Hugo", 100.0,500.0);

            //acount.Balance = 200.0; não vai funcionar porque o atributo Balance é PROTECTED:

            Console.WriteLine(acount.Balance);


        }
    }
}