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
        public event EventHandler DeleteContact;
        public Action<IContactView, bool> Contact { get; set; }
        public Action<IContactView, string, bool> EditContact { get; set; }

        public IContactView contactView;

        public MainForm()
        {
            InitializeComponent();
        }

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
            contactView = new ContactForm();
            Contact?.Invoke(contactView, true);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            contactView = new ContactForm();
            EditContact?.Invoke(contactView, ContactSelected, true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContact?.Invoke(sender, e);
        }

        private void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();

            ContactForm contactForm = new ContactForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };

            contentPanel.Controls.Add(contactForm);
            contactView = contactForm;

            EditContact?.Invoke(contactView, ContactSelected, false);
        }

        public void OpenView()
        {
            Application.Run(this);
        }

        public void CloseView()
        {
            Close();
        }
    }
}
