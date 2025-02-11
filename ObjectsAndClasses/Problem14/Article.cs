﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem14
{
    public class Article
    {

        public string Title { get; set; }


        public string Content { get; set; }


        public string Author { get; set; }


        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
