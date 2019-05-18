using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TaskManager
{
    public partial class Login : UserControl
    {
        Form1 form1;
        string id;
        public Login()
        {
            InitializeComponent();
        }

        public void initializ(Form1 form1)
        {
            this.form1 = form1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("employees.xml");
            XmlNodeList passwords = doc.GetElementsByTagName("password");
            XmlNodeList IDs = doc.GetElementsByTagName("id");
            XmlNodeList statuss = doc.GetElementsByTagName("role");
            string status = "";
            for (int i = 0; i < passwords.Count; i++)
            {
                string passwordValue = passwords[i].InnerText;
                string idValue = IDs[i].InnerText;
                if (idValue == ID.Text && passwordValue == password.Text)
                {
                    isExist = true;
                    status = statuss[i].InnerText;
                    GlobalVariableClass.Temp = idValue;
                }
            }
            if (isExist)
            {
                id = ID.Text.ToString();
                if (status == "Admin")
                {
                    AdminActionForm adminActionForm = new AdminActionForm(form1);
                    adminActionForm.Show();
                }
                else
                {
                    //user form will appear
                 //   UserActionForm userActionsForm = new UserActionForm(form1);
                    //id = int.Parse(ID.Text.ToString());
                    UserActionForm userActionsForm1 = new UserActionForm(form1,id);
                    userActionsForm1.Show();
                }
                form1.Hide();
            }
            else
            {
                MessageBox.Show("ID or password does not exist");
            }
            
        }
    }
}
