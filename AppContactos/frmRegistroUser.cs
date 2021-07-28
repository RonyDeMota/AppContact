using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace AppContactos
{
    public partial class frmRegistroUser : Form
    {
        public ServicioUsuario serviceUser;
        public frmRegistroUser()
        {
            InitializeComponent();
            serviceUser = new ServicioUsuario();
        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            Login login = Login.Instancia;
            login.Show();
            this.Hide();
        }
        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {
            registrar();
        }
        private void frmRegistroUser_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
        public void registrar()
        {
            if (txtRegNombre.Text != "" && TxtRegApellido.Text != "" && TxtRegUserName.Text != ""
              && TxtRegContra.Text != "" && TxtRegConfirmContra.Text != "")
               {  if (TxtRegContra.Text == TxtRegConfirmContra.Text)
                {
                Usuarios User = new Usuarios(txtRegNombre.Text, TxtRegApellido.Text, TxtRegUserName.Text, TxtRegContra.Text);
                serviceUser.Add(User);
                this.Close();
                    Login login = Login.Instancia;
                login.Show();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Alerta");
                }
           
            }
            else
            {
                MessageBox.Show("Faltan Campos Por llenar", "Alerta");
            }
          
        }

        private void frmRegistroUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Instancia.Show();
        }
    }
}
