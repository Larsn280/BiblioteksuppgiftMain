using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BiblioteksuppgiftMain
{
    internal class MainMenu
    {
        public static void Menu()
        {
            string welcome = "Välkommen till Biblioteket!";
            string what = "Vad vill du göra?";
            string författare = "Lägg till författare och bok tryck 1";
            string input = "Input : ";
            SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
            WriteLine(welcome);
            SetCursorPosition((WindowWidth - what.Length) / 2, CursorTop = 4);
            WriteLine(what);
            SetCursorPosition((WindowWidth - författare.Length) / 2, CursorTop = 6);
            WriteLine(författare);
            SetCursorPosition((WindowWidth - input.Length) / 2, CursorTop = 10);
            Write(input);


            string option = ReadLine();

            switch (option)
            {
                case "1":
                    Clear();
                    InputFörfattareOchBöcker.InputAuthorAndBooks();
                    break;

                default:
                    Clear();
                    MainMenu.Menu();
                    break;
                    
            }
        }
    }
}
