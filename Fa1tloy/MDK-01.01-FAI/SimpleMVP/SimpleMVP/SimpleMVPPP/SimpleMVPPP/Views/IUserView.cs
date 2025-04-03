using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVPPP.Views
{
    public interface IUserView
    {
        void Show(List<User> users);
        int GetSelectedUserIndex();
    }
}
