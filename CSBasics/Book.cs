using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Book
    {

        public string Title { get; private set; }
        public int Pages { get; private set; }
        public int CurrentPage {get; private set;}
        public Book(string title, int pages)
        {
            CurrentPage = 1;
            Title = title;
            Pages = pages; 
        }

        public bool TurnPage()
        {
            if(CurrentPage < Pages)
            {
                CurrentPage++;
                Console.WriteLine("Page turned. Current page: " + CurrentPage);
                return true;
            }
            Console.WriteLine("Can't turn page. Current page: " + CurrentPage);
            return false;
        }
    }
}
