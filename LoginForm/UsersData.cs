using LoginForm.Models;
using System.Collections.Generic;

namespace LoginForm
{   
    public class UsersData
    {
        public static List<UsersModel> Data = new List<UsersModel>()
        {
            new UsersModel() {Login="admin", Password="nimda", IsAdmin=true},
            new UsersModel() {Login="root",  Password="root",  IsAdmin=true},
            new UsersModel() {Login="user",  Password="user",  IsAdmin=false},
            new UsersModel() {Login="test",  Password="test",  IsAdmin=false}
        };
        public static UsersModel Auth(UsersModel model)
        {
            foreach (var record in Data)
            {
                if (record.Login == model.Login && record.Password == model.Password)
                {
                    model.IsAdmin = record.IsAdmin;
                    model.IsLogged = true;
                    break;
                }
            }
            return model;
        }
    }
}
