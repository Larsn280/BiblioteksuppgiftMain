using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace BiblioteksuppgiftMain
{
    internal class Program
    {
        static DataAccess dataAccess = new DataAccess();
        static void Main(string[] args)
        {
            //dataAccess.RecreateDatabase();
            //dataAccess.AddItemsToLibrary();

            MainMenu.Menu();

        }
    }
}
