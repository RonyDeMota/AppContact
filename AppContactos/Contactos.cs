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
    public partial class Contactos : Form
    {
        public int ex;
        public Usuarios usuario;
        ServicioContactos Servicio;
        public int IndexD;
        public Contactos(Usuarios usuarios)
        {
            InitializeComponent();
            Servicio = new ServicioContactos(usuarios.UserName);
            this.usuario = usuarios;

        }

        public Contactos()
        {
        }
        #region events

        Login login = Login.Instancia;
        private void Contactos_Load(object sender, EventArgs e)
        {
            VerNewContacto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void cerrarSeccionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarContactoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ex = 1;
            AddContacto Cont = new AddContacto(usuario);
            Cont.Show();
            this.Close();
        }
       
        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex = 1;
            login.Show();
            this.Close();
        }
        private void DataInfo_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }
        private void Contactos_FormClosed(object sender, FormClosedEventArgs e)
        {
           // DialogResult response = MessageBox.Show("Estas Seguro que quieres eliminar esta contacto",
             //       "Advertencia", MessageBoxButtons.OKCancel);
            //if(response == DialogResult.OK) {
           //ssageBox.Show("Cerrar Sección","Advertencia");
         // login.Show(); //  }
        }
        private void Contactos_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
          DeleteContact();
            VerNewContacto();
        }
        private void DataInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IndexD = e.RowIndex;
            }
           

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contactos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ex == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }

        }
        #endregion

        #region Methods

        public void Edit()
        {
            if (IndexD >= 0)
            {
                ex = 1;
                frmEditarContacto edit = new frmEditarContacto(usuario);
                edit.indexR = IndexD;
                edit.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("debe seleccionar el campo que desea editar");
            }

        }
        private void VerNewContacto()
        {
            DataInfo.Rows.Clear();
            List<Contacto> ListaContactos = Servicio.ListUser();
            foreach (Contacto Item in ListaContactos)
            {
                DataInfo.Rows.Add(Item.Name, Item.Lastname, Item.Adress, Item.CellPhone, Item.Phone);
                DataInfo.ClearSelection();
            }
        }

        private void DeleteContact()
        {
            if (IndexD >= 0)
            {
                MessageBox.Show("Selecciona el contacto que deseas eliminar");
            }
            else
            {
                DialogResult response = MessageBox.Show("Estas Seguro que quieres eliminar esta contacto",
                    "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    Servicio.Delete(IndexD);
                }
            }
            }

        #endregion

      
    } 

      
    }
