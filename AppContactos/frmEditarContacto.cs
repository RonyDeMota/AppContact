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
    public partial class frmEditarContacto : Form
    {
        ServicioContactos Servicio;
        public Usuarios usuario;
        public int indexR;
        public frmEditarContacto(Usuarios usuarios)
        {
            InitializeComponent();
            Servicio = new ServicioContactos(usuarios.UserName);
            this.usuario = usuarios;
        }
        #region events

        private void btnCancelarNewCont_Click(object sender, EventArgs e)
        {
            Contactos inicio = new Contactos(usuario);
            inicio.Show();
            this.Hide();
        }

        private void frmEditarContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void frmEditarContacto_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void EditLoad()
        {


        }

        private void btnGuardarNewCont_Click(object sender, EventArgs e)
        {
            EditContact();
            Contactos inicio = new Contactos(usuario);
            inicio.Show();
            this.Hide();
        }

        private void frmEditarContacto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Instancia.Show();
        }

        #endregion

        #region Methods

        public void LoadEdit()
        {
           Contacto eas = Servicio.GetItem(indexR);

            txtEditNombre.Text = eas.Name;
            TxtEditApellido.Text = eas.Lastname;
            TxtEditDirction.Text = eas.Adress;
            TxtEditCelular.Text = eas.CellPhone;
            TxtEditTelefono.Text = eas.Phone;
        }
        public void EditContact()
        {
            Contacto eass = new Contacto(txtEditNombre.Text, TxtEditApellido.Text, TxtEditDirction.Text,
               TxtEditCelular.Text, TxtEditTelefono.Text);

            Servicio.Edit(indexR, eass);

            eass.Name = txtEditNombre.Text;
            eass.Lastname = TxtEditApellido.Text;
            eass.Adress = TxtEditDirction.Text;
            eass.CellPhone = TxtEditCelular.Text;
            eass.Phone = TxtEditTelefono.Text;
        }



            #endregion

        
    }
}
