using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVPPP.Models
{
   public  interface IUserModel
    {
        void LoadInfoUsers();
        List<User> ReturnUsers();
        List<User> GetUsers();
        void FiltrUserData(string NameFiltr, string input);
        void ChangeUser(User u);
        void DeleteUser(int del);

        event Action SuccessLoadedInfoUsers;
    }
}
