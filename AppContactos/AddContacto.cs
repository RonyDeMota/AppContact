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

    public partial class AddContacto : Form
    {
        public Usuarios usuario;
        ServicioContactos Servicio;
        
        public AddContacto(Usuarios usuarios)
        {
            InitializeComponent();
            Servicio = new ServicioContactos(usuarios.UserName);
            this.usuario = usuarios;
        }
        #region events
        private void TxtNombreNewCont_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddContacto_Load(object sender, EventArgs e)
        {

        }

        private void AddContacto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Instancia.Show();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardarNewCont_Click(object sender, EventArgs e)
        {
            Validacion();
        }
        private void btnCancelarNewCont_Click(object sender, EventArgs e)
        {

            Contactos Inicio = new Contactos(usuario);
            Inicio.Show();
            this.Hide();

        }
        private void AddContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        #endregion

        #region Methods

        public void Validacion()
        {
            if (TxtNombreNewCont.Text != "" && TxtApellidoNewCont.Text != "" && TxtDirecNewCont.Text != ""
               && TxtCelNewCont.Text != "" && TxtTelNewCont.Text != "")
            {
                Contacto Item = new Contacto(TxtNombreNewCont.Text, TxtApellidoNewCont.Text, TxtDirecNewCont.Text, TxtCelNewCont.Text, TxtTelNewCont.Text);
            Servicio.Add(Item);

                Contactos Inicio = new Contactos(usuario);
                Inicio.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Faltan Campos Por llenar", "Alerta");
            }
        }








        #endregion

  
    }
}
