using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{

    public class Program
    {

        // ------ FUNCTIONS ----------
      

        // ------ END OF FUNCTIONS ------


        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();
        }   
    }
}
    