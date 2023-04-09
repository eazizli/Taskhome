using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7AprelTask
{
    enum PostType 
    {
        News,
        Blog,
        Product
    }


    internal class Post
    {
        private static int _id;
        public int Id { get; set; }
        public string CreatDate { get; set; }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Length <= 255)
                {
                    _description = value;
                }
                else
                {
                    Console.WriteLine("Uzunlugu duzgun elave edin");
                }
            }
        }
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length <= 50)
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Uzunlugu duzgun elave edin");
                }
            }
        }
        public string Comments { get; set; }
        public Post[] Posts = new Post[0];
        

        public Post(  string description,  string title,  string comments)
        {
            _id++;
            Id = _id;
            CreatDate = DateTime.Now.ToString();


            Description = description;
            Description = _description;
            Title = title;
            Title = _title;
            
            Comments = comments;
        }
        public void Arrayin(Post post)
        {
            Array.Resize(ref Posts, Posts.Length+1);
            Posts[Posts.Length-1] = post;

        }
    }
}
