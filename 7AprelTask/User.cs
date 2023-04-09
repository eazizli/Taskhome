using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace _7AprelTask
{
    interface Iaccount
    {
        public void PaswordChecker()
        {

        }
    }


    internal class User:Iaccount
    {
        

        private static int _id = 0; 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CreatedDate { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }



        public User[] Users = new User[0];
        public User(string name,string surname,string pasword) {

            _id++;
            Id = _id;
            Name = name;    
            Surname = surname;
            UserName = Name + Surname;
            CreatedDate = DateTime.Now.ToString();
            Password = pasword;
            UserName =
                $"{Name}{Surname}"
                .Replace("ə", "e")
                .Replace("İ", "I")
                .Replace("ı", "i").
                 Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .ToLower();



        }
        public void ArrCheck(User user)
        {
            Array.Resize(ref Users, Users.Length+1);
            Users[Users.Length - 1] = user;       
        }
       
        
    }
}
