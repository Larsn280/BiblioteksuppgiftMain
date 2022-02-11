using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BiblioteksuppgiftMain
{
    internal class InputFörfattareOchBöcker
    {

        public static Context context = new Context();

        public static List<Book> books = new List<Book>();


        public static void InputAuthorAndBooks()
        {

            string welcome = "Mata in information om författaren!";
            string welcome1 = "Eller tryck b för att återgå till huvudmenyn";
            string welcome2 = "Författarens namn : ";
            string welcome3 = "Författarens födelseår : ";
            string welcome4 = "Bokens Isbn : ";
            string welcome5 = "Bokens Titel : ";
            string welcome6 = "Utgivningsår : ";
            string welcome7 = "Bokens betyg : ";
            string welcome8 = "Input antal : ";
            string authorname = "";
            int authorbirthday = 0;
            string bookisbn = "";
            string booktitle = "";
            int bookyyear = 0;
            int bookgrade = 0;
            int bookamount = 0;

            bool mybool = true;
            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                WriteLine(welcome);

                SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                WriteLine(welcome1);

                SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                Write(welcome2);

                string name = ReadLine().Trim();
                if (name == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(name) || name.Length > 20 || name.Length < 6)
                {
                    Clear();
                    continue;
                }
                else
                {
                    authorname = name;
                    break;
                }
            }

            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                Write(welcome3);
                string birthdate = ReadLine().Trim();

                if (birthdate == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(birthdate) || birthdate.Length > 20 || birthdate.Length < 6 || !int.TryParse(birthdate, out authorbirthday))
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);
                    continue;

                }
                else
                {
                    int.TryParse(birthdate, out authorbirthday);
                    break;
                }
            }

            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                Write(welcome4);
                string isbn = ReadLine().Trim();

                if (isbn == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(isbn) || isbn.Length > 20 || isbn.Length < 6)
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);

                    SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                    WriteLine(welcome3 + authorbirthday);

                    continue;

                }
                else
                {
                    bookisbn = isbn;
                    break;
                }
            }

            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome5.Length) / 2, CursorTop = 17);
                Write(welcome5);
                string boktitel = ReadLine().Trim();

                if (boktitel == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(boktitel) || boktitel.Length > 20 || boktitel.Length < 6)
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);

                    SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                    WriteLine(welcome3 + authorbirthday);

                    SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                    WriteLine(welcome4 + bookisbn);

                    continue;

                }
                else
                {
                    booktitle = boktitel;
                    break;
                }
            }


            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome6.Length) / 2, CursorTop = 20);
                Write(welcome6);
                string utgivningsår = ReadLine().Trim();

                if (utgivningsår == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(utgivningsår) || utgivningsår.Length > 20 || utgivningsår.Length < 6 || !int.TryParse(utgivningsår, out bookyyear))
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);

                    SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                    WriteLine(welcome3 + authorbirthday);

                    SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                    WriteLine(welcome4 + bookisbn);

                    SetCursorPosition((WindowWidth - welcome5.Length) / 2, CursorTop = 17);
                    Write(welcome5 + booktitle);

                    continue;

                }
                else
                {
                    int.TryParse(utgivningsår, out bookyyear);
                    break;
                }

            }

            while (mybool)
            {

                SetCursorPosition((WindowWidth - welcome7.Length) / 2, CursorTop = 23);
                Write(welcome7);
                string betyg = ReadLine().Trim();

                if (betyg == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(betyg) || betyg.Length > 20 || betyg.Length < 6 || !int.TryParse(betyg, out bookgrade))
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);

                    SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                    WriteLine(welcome3 + authorbirthday);

                    SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                    WriteLine(welcome4 + bookisbn);

                    SetCursorPosition((WindowWidth - welcome5.Length) / 2, CursorTop = 17);
                    Write(welcome5 + booktitle);

                    SetCursorPosition((WindowWidth - welcome6.Length) / 2, CursorTop = 20);
                    Write(welcome6 + bookyyear);

                    continue;

                }
                else
                {
                    int.TryParse(betyg, out bookgrade);
                    break;
                }

            }
            while (mybool)
            {
                SetCursorPosition((WindowWidth - welcome8.Length) / 2, CursorTop = 26);
                Write(welcome8);
                string antal = ReadLine().Trim();

                if (antal == "b")
                {
                    Clear();
                    MainMenu.Menu();
                }
                else if (string.IsNullOrEmpty(antal) || antal.Length > 20 || antal.Length < 6 || !int.TryParse(antal, out bookamount))
                {
                    Clear();

                    SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                    WriteLine(welcome);

                    SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                    WriteLine(welcome1);

                    SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                    WriteLine(welcome2 + authorname);

                    SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                    WriteLine(welcome3 + authorbirthday);

                    SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                    WriteLine(welcome4 + bookisbn);

                    SetCursorPosition((WindowWidth - welcome5.Length) / 2, CursorTop = 17);
                    Write(welcome5 + booktitle);

                    SetCursorPosition((WindowWidth - welcome6.Length) / 2, CursorTop = 20);
                    Write(welcome6 + bookyyear);

                    SetCursorPosition((WindowWidth - welcome7.Length) / 2, CursorTop = 23);
                    Write(welcome7 + bookgrade);

                    continue;

                }
                else
                {
                    int.TryParse(antal, out bookamount);
                    break;
                }
            }
            while (mybool)
            {
                string welcome11 = "Input 1 to confirm!";
                string welcome12 = "Input 2 for canceling";
                string welcome13 = "Or b to return to MainMenu";
                SetCursorPosition((WindowWidth - welcome11.Length) / 2, CursorTop = 29);
                WriteLine(welcome11);
                SetCursorPosition((WindowWidth - welcome12.Length) / 2, CursorTop = 31);
                WriteLine(welcome12);
                SetCursorPosition((WindowWidth - welcome13.Length) / 2, CursorTop = 33);
                WriteLine(welcome13);
                string option = ReadLine();

                switch (option)
                {
                    case "b":
                    Clear();
                    MainMenu.Menu();
                    break;

                    case "1":
                        Book book = new Book();

                        book.Isbn = bookisbn;
                        book._BokTitle = booktitle;
                        book.UtgivningsÅr = bookyyear;
                        book.Betyg = bookgrade;
                        book.AntalILager = bookamount;

                        books.Add(book);

                        context.Böcker.Add(book);

                        //Författare författare = new Författare();

                        //författare._Författare = authorname;
                        //författare.FödelseÅr = authorbirthday;

                        //BöckerOchFörfattare böckerOchFörfattare = new BöckerOchFörfattare();
                        //böckerOchFörfattare.Isbn = bookisbn;
                        //böckerOchFörfattare._Författare = authorname;

                        context.SaveChanges();
                        Clear();
                        string welcome9 = "You have Succesfully added items to Library";
                        SetCursorPosition((WindowWidth - welcome9.Length) / 2, CursorTop = 4);
                        WriteLine(welcome9);
                        string welcome10 = "Redirecting you back to MainMenu";
                        SetCursorPosition((WindowWidth - welcome10.Length) / 2, CursorTop = 6);
                        WriteLine(welcome10);
                        System.Threading.Thread.Sleep(6000);
                        MainMenu.Menu();
                        break;

                    case "2":
                        Clear();
                        InputAuthorAndBooks();
                        break;

                        default:
                        Clear();

                        SetCursorPosition((WindowWidth - welcome.Length) / 2, CursorTop = 2);
                        WriteLine(welcome);

                        SetCursorPosition((WindowWidth - welcome1.Length) / 2, CursorTop = 4);
                        WriteLine(welcome1);

                        SetCursorPosition((WindowWidth - welcome2.Length) / 2, CursorTop = 8);
                        WriteLine(welcome2 + authorname);

                        SetCursorPosition((WindowWidth - welcome3.Length) / 2, CursorTop = 11);
                        WriteLine(welcome3 + authorbirthday);

                        SetCursorPosition((WindowWidth - welcome4.Length) / 2, CursorTop = 14);
                        WriteLine(welcome4 + bookisbn);

                        SetCursorPosition((WindowWidth - welcome5.Length) / 2, CursorTop = 17);
                        Write(welcome5 + booktitle);

                        SetCursorPosition((WindowWidth - welcome6.Length) / 2, CursorTop = 20);
                        Write(welcome6 + bookyyear);

                        SetCursorPosition((WindowWidth - welcome7.Length) / 2, CursorTop = 23);
                        Write(welcome7 + bookgrade);

                        SetCursorPosition((WindowWidth - welcome8.Length) / 2, CursorTop = 26);
                        Write(welcome8 + bookamount);

                        SetCursorPosition((WindowWidth - welcome11.Length) / 2, CursorTop = 29);
                        WriteLine(welcome11);
                        SetCursorPosition((WindowWidth - welcome12.Length) / 2, CursorTop = 31);
                        WriteLine(welcome12);
                        SetCursorPosition((WindowWidth - welcome13.Length) / 2, CursorTop = 33);
                        WriteLine(welcome13);
                        break;
                }
            }
        }
    }
}

