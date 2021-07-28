using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BuisnessLayer;
using BusinessLayer;

namespace AppContactos
{
    public partial class Login : Form
    {

        public static Login Instancia { get; } = new Login();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnIniciarSeccion_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void btnRegiatrar_Click(object sender, EventArgs e)
        {
            frmRegistroUser reg = new frmRegistroUser();
            reg.Show();
            this.Hide();
        }

        #region Methods



        private void Ingresar()
        {
            ServicioUsuario servicioUsuarios = new ServicioUsuario();
            Usuarios item = servicioUsuarios.GetItemUser(TxtUserName.Text);

            if (item != null)
            {
                if (item.Contraseña == TxtPass.Text)
                {
                    this.Hide();
                    Contactos Princi = new Contactos(item);
                    Princi.Show();
                    Reset();

                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Alerta");
                }
            }
            else
            {
                MessageBox.Show("Este usuario no esta registrado", "Alerta");
            }
        }

        public void Reset()
        {
            TxtUserName.Clear();
            TxtPass.Clear();
        }



        #endregion

       
    }
}
