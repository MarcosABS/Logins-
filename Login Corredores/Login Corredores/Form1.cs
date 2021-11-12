using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Corredores
{
    public partial class form1 : Form
    {
        SQLControl sqlControl = new SQLControl();
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtUsuario.Text, txtContraseña.Text);
            if (result == 1)
            {
                frmMenu menu = new frmMenu();
                this.Hide();   
                menu.ShowDialog();


            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o Contrasña incorrecta");
            }
                    
        }
    }
}
