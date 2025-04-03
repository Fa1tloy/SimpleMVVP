using SimpleMVPPP.Models;
using SimpleMVPPP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVPPP.Presenters
{
    public class UserPresenter
    {
        private IUserModel model_;
        private IUserView view_;
        private IUserCard card_;


        public UserPresenter(IUserModel model, IUserView view, IUserCard card)
        {
            model_ = model;
            view_ = view;
            card_ = card;

            model_.SuccessLoadedInfoUsers += Model__SuccessLoadedInfoUsers;
            model_.LoadInfoUsers();
            card_.UserChange += Card__UserChange;
        }

        private void Card__UserChange(User obj)
        {
            Model__ChangedUser(obj);
        }

        public void View__FiltrEvent(string FiltrOrder, string input)
        {

            model_.FiltrUserData(FiltrOrder, input);
        }

        public void Model__RefreshLoadedInfoUsers()
        {
            view_.Show(model_.ReturnUsers());
        }

        private void Model__SuccessLoadedInfoUsers()
        {
            view_.Show(model_.GetUsers());
        }

        public void View__SelectedUser(int number)
        {
            if (number < 0 || number >= model_.GetUsers().Count)
            {
                return;
            }
            User u = model_.GetUsers()[number];
            card_.Show(u);
        }

        public void Model__ChangedUser(User u)
        {
            model_.ChangeUser(u);

        }

        public void Model__DeleteUser()
        {
            int delIndex = view_.GetSelectedUserIndex();
            if (delIndex < 0 || delIndex >= model_.GetUsers().Count)
            {
                return;
            }
            User u = model_.GetUsers()[delIndex];
            model_.DeleteUser(u.Id);
        }
    }
}
