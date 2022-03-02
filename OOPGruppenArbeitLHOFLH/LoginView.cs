using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGruppenArbeitLHOFLH
{
    public partial class LoginView : Form
    {
        IBusiness business = new DiaryBusiness();
        
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // textBoxUsername und textBoxPassword in Login speichern
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            // Login-Methode aufrufen
            bool validLogin = business.Login(username, password);

            if (!validLogin)
            {
                labelErrorMessage.Text = "Login failed"; // gleiches Vorgehen im DiaryEntryView für IsValidEntry?
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
