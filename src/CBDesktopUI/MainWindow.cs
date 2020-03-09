using CBDesktopUI.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CBDesktopUI
{
    public partial class MainWindow : Form
    {
        Person person = new Person();

        public MainWindow()
        {
            InitializeComponent();
            ShowData();

            person.OperationApprovedEvent += Person_OperationApprovedEvent;
        }

        private void Person_OperationApprovedEvent(object sender, EventArgs e)
        {
            ShowData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainPanel main = new MainPanel(person)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };

            contentPanel.Controls.Add(main);
            main.Show();
        }

        private void ShowContacts_Click(object sender, EventArgs e)
        {
            contactList.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int.TryParse(ContactId, out int id);

            person.DeleteContact(id);
        }

        private void ShowData()
        {
            contactList.DataSource = null;

            var personData = person.GetContacts();

            var contactListSource = from p in personData
                                    select new
                                    {
                                        Name = $"{p.FirstName} {p.LastName}",
                                        Id = p.Id
                                    };

            contactList.DataSource = contactListSource.ToList();
            contactList.DisplayMember = "Name";
            contactList.ValueMember = "Id";
        }

        private string _contactId;

        public string ContactId
        {
            get => _contactId;
            set { _contactId = value; }
        }

        private void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactId = contactList.GetItemText(contactList.SelectedValue);
        }
    }
}
