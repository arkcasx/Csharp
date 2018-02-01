using System;
using System.Collections.Generic;

namespace StackOverflow
{
    public class Post
    {
        private readonly Dictionary<string, string> _dictionary;
        public string Title { get; private set; } //create post

        public string Description { get; private set; } //view number of post and date of the post

        public DateTime Time { get; private set; } // date creation of the post 


        public int Votes { get; private set; }   // Vote

        public void Display()
        {
            Title = _dictionary["title"];
            Description = _dictionary["description"];
            Console.WriteLine("Title: " + Title );
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Date Created: " + Time );
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        public void DateCreated(DateTime time)
        {
            Time = time;
          
        }
        public Post()
        {
            _dictionary = new Dictionary<string, string>();
           
        }

        public void Voteupanddown(string text)
        {
            switch (text)
            {
                case "up":
                    Votes++;
                    Console.WriteLine(Votes);
                    break;
                case "down":
                    Votes--;
                    Console.WriteLine(Votes);
                    break;
            }
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }


    }
}