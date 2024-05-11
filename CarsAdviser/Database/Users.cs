
using System.Collections.Generic;

namespace CarsAdviser.Database
{
    public class Users
    {
        public int ID { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; }
        public int IsYandex { get; set; }
        public virtual ICollection<Users_bookmarks> UserBookmarks { get; set; }
        public virtual ICollection<Users_hidden_auto> UserHiddenAutos { get; set; }
        public virtual ICollection<Users_preferences> UserPreferences { get; set; }
    }
}
