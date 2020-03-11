using CBDesktopUI.Library.Models;
using CBDesktopUI.ViewAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CBDesktopUI
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler DeleteContact;
        public event EventHandler SelectedContact;
        public Action<IContactView> Contact { get; set; }

        public string ContactSelected
        {
            get => contactList.GetItemText(contactList.SelectedValue);
            set => contactList.SelectedItem = value;
        }

        public List<PersonDbModel> ContactsList
        {
            get => contactList.DataSource as List<PersonDbModel>;
            set
            {
                contactList.DisplayMember = "Name";
                contactList.ValueMember = "Id";
                contactList.DataSource = value.Select(x =>
                    new { Name = $"{x.FirstName} {x.LastName}", Id = x.Id }).ToList();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            IContactView contactView = new ContactForm();
            Contact?.Invoke(contactView);
        }

        private void ShowContacts_Click(object sender, EventArgs e)
        {
            contactList.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContact?.Invoke(sender, e);
        }
                
        private void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedContact?.Invoke(sender, e);
        }

        public void OpenView()
        {
            Application.Run(this);
        }
    }
}
