using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7AprelTask
{
    internal class Comment
    {
        private static int _id;
        public int Id { get; set; } 
        public string Createdate { get; set; }
        private string _content;
        public string Content 
        {
            get
            {
                return _content;
            }
            set
            {
                if (value.Length <= 255)
                {
                    _content = value;
                }
                else { Console.WriteLine("Uzunlugu coxdur"); }

            }
        }
        public Comment[] Comments = new Comment[0];
        public Comment(string content)
        {
            _id++;
            Id = _id;
            Content = content;
            Createdate= DateTime.Now.ToString();

        }
        public void Arrin(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;
        }

    }
}
