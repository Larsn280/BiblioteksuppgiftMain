using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BiblioteksuppgiftMain
{
    internal class DataAccess
    {
        Context context = new Context();

        // Metod som tar bort och återskapar databasen utifrån hur Context.cs ser ut
        public void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        public void AddItemsToLibrary()
        {
            Book book = new Book();

            book.Isbn = "UN100";
            book._BokTitle = "Sista Färden";
            book.UtgivningsÅr = 1968;
            book.Betyg = 5;
            book.AntalILager = 1;

            Book book1 = new Book();

            book1.Isbn = "UN101";
            book1._BokTitle = "Sista Resan";
            book1.UtgivningsÅr = 1965;
            book1.Betyg = 5;
            book1.AntalILager = 1;

            Book book2 = new Book();

            book2.Isbn = "UN102";
            book2._BokTitle = "Sista Drinken";
            book2.UtgivningsÅr = 1960;
            book2.Betyg = 5;
            book2.AntalILager = 1;

            List<Book> allaBöcker = new List<Book>();
            allaBöcker.Add(book);
            allaBöcker.Add(book1);
            allaBöcker.Add(book2);

            Författare författare = new Författare();

            författare._Författare = "Göran";
            författare.FödelseÅr = 1948;

            Författare författare1 = new Författare();

            författare1._Författare = "Sven";
            författare1.FödelseÅr = 1945;

            Författare författare2 = new Författare();

            författare2._Författare = "Ingvar";
            författare2.FödelseÅr = 1940;

            List<Författare> allaFörfattare = new List<Författare>();
            allaFörfattare.Add(författare);
            allaFörfattare.Add(författare1);
            allaFörfattare.Add(författare2);

            BöckerOchFörfattare böckerOchFörfattare = new BöckerOchFörfattare();

            böckerOchFörfattare.Isbn = book.Isbn;
            böckerOchFörfattare._Författare = författare._Författare;

            BöckerOchFörfattare böckerOchFörfattare1 = new BöckerOchFörfattare();

            böckerOchFörfattare1.Isbn = book1.Isbn;
            böckerOchFörfattare1._Författare = författare1._Författare;

            BöckerOchFörfattare böckerOchFörfattare2 = new BöckerOchFörfattare();

            böckerOchFörfattare2.Isbn = book2.Isbn;
            böckerOchFörfattare2._Författare = författare2._Författare;

            List<BöckerOchFörfattare> allaBöckerOchFörfattare = new List<BöckerOchFörfattare>();
            allaBöckerOchFörfattare.Add(böckerOchFörfattare);
            allaBöckerOchFörfattare.Add(böckerOchFörfattare1);
            allaBöckerOchFörfattare.Add(böckerOchFörfattare2);

            Boklånare boklånare = new Boklånare();
            boklånare.LåneKort = "LK100";
            boklånare.FörNamn = "Sven";
            boklånare.EfterNamn = "Gustavsson";

            List<Boklånare> allaBoklånare = new List<Boklånare>();
            allaBoklånare.Add(boklånare);

            Utlåningar nyUtlåning = new Utlåningar();

            nyUtlåning.Lånekort = "LK100";
            nyUtlåning.Isbn = book.Isbn;
            nyUtlåning.Returdatum = "1234";

            List<Utlåningar> allaUtlåningar = new List<Utlåningar>();
            allaUtlåningar.Add(nyUtlåning);
           

            context.Böcker.Add(book);
            context.Böcker.Add(book1);
            context.Böcker.Add(book2);

            context.Författare.Add(författare);
            context.Författare.Add(författare1);
            context.Författare.Add(författare2);

            context.BöckerOchFörfattare.Add(böckerOchFörfattare);
            context.BöckerOchFörfattare.Add(böckerOchFörfattare1);
            context.BöckerOchFörfattare.Add(böckerOchFörfattare2);

            context.Boklånare.Add(boklånare);

            context.Utlåningar.Add(nyUtlåning);

            context.SaveChanges();

        }

       
    }
}
