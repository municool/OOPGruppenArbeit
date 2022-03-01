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
        // User enteredLogin = null;

        public LoginView()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //// textBoxUsername und textBoxPassword in Login speichern
            //enteredLogin.Username = textBoxUsername.Text;
            //enteredLogin.Password = textBoxPassword.Text;

            //// Login-Methode aufrufen
            //business.Login(enteredLogin);
        }
    }
}
