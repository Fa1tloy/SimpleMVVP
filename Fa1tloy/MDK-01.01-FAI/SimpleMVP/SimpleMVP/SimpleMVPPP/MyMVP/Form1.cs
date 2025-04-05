using SimpleMVPPP.Models;
using SimpleMVPPP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleMVPPP.Presenters;
using SimpleMVPPP.Views;

namespace MyMVP
{
    public partial class Form1 : Form, IUserView

    {
        private UserPresenter presenter_;

        public Form1(IUserCard userCard)
        {
            InitializeComponent();
            presenter_ = new UserPresenter(new MemoryUsersModel(), this, userCard);
        }

        public void Show(List<User> users)
        {
            UsersList.DataSource = null;
            UsersList.DataSource = users;
        }

        void NameFiltr_Click(object sender, EventArgs e)
        {
            presenter_.View__FiltrEvent(NameTextBox.Text, ComboBoxFiltr.Text);

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            presenter_.Model__RefreshLoadedInfoUsers();
            UsersList.Rows[0].Selected = true;

        }

        private void UsersList_SelectionChanged(object sender, EventArgs e)
        {
            presenter_.View__SelectedUser(GetSelectedUserIndex());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены в удалении данного пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                presenter_.Model__DeleteUser();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        public int GetSelectedUserIndex()
        {
            return UsersList.CurrentCell.RowIndex;
        }
    }
}
