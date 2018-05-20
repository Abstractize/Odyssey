using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class User
    {
        private String UserName;
        private String Password;
        private int Age;
        private String FullName;
        private StringList Genres;

        public string userName
        {
            get { return this.UserName; }
            set => UserName = value;
        }
        
        public string password { get => Password; set => Password = value; }
        public int age { get => Age; set => Age = value; }
        public string fullName { get => FullName; set => FullName = value; }
        public StringList genres { get => Genres; set => Genres = value; }
        
        public String getUserName()
        {
            return this.UserName;
        }
        public String getFullName()
        {
            return this.FullName;
        }
        public String getPassword()
        {
            return this.Password;
        }
        public int getAge()
        {
            return this.Age;
        }
        public StringList GetGenres()
        {
            return this.genres;
        }
    }
}
