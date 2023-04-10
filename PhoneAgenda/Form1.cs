namespace PhoneAgenda
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\_PROJETOS\\ESTUDOS\\PhoneAgenda\\PhoneAgenda\\myContactsList.csv";
            string name = name_box.Text;
            string phone = phone_box.Text;

            StreamWriter phone_list = File.AppendText(path);
            phone_list.WriteLine(name + "," + phone);
            phone_list.Close();

            load_Contacts();
        }

        private void load_Contacts()
        {

            contactListView.DataSource = GetContacts();
        }

        private List<Contact> GetContacts()
        {
            string path = "C:\\_PROJETOS\\ESTUDOS\\PhoneAgenda\\PhoneAgenda\\myContactsList.csv";
            var contacts = File.ReadAllLines(path);
            var list = new List<Contact>();
            foreach (var contact in contacts)
            {
                var values = contact.Split(',');
                list.Add(new Contact() { Name = values[0], Phone = values[1] });
            }

            return list;
        }


        private void search(object sender, KeyEventArgs e)
        {
            var contactList = GetContacts();

            contactListView.DataSource = contactList.Where(contact => contact.Name == searchBoxText.Text
            || contact.Name.StartsWith(searchBoxText.Text)
            || contact.Phone == searchBoxText.Text
            || contact.Phone.StartsWith(searchBoxText.Text)).ToList();
        }
    }
}