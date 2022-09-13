using System.Collections.Generic;

namespace LoginForm
{   
    public class Record
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class UsersData
    {
        public static List<Record> Data = new List<Record>()
        {
            new Record() {Login="admin", Password="nimda", IsAdmin=true},
            new Record() {Login="root",  Password="root",  IsAdmin=true},
            new Record() {Login="user",  Password="user",  IsAdmin=false},
            new Record() {Login="test",  Password="test",  IsAdmin=false}
        };
    }
}
