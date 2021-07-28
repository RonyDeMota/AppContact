
namespace AppContactos
{
    partial class frmRegistroUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.lblContraRegis = new System.Windows.Forms.Label();
            this.lblconfimPass = new System.Windows.Forms.Label();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.TxtRegApellido = new System.Windows.Forms.TextBox();
            this.TxtRegUserName = new System.Windows.Forms.TextBox();
            this.TxtRegContra = new System.Windows.Forms.TextBox();
            this.TxtRegConfirmContra = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegGuardar = new System.Windows.Forms.Button();
            this.BtnRegCancelar = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.69347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRegister, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.9887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblUserName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblContraRegis, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblconfimPass, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtRegNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegApellido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegUserName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegContra, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegConfirmContra, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 263);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Location = new System.Drawing.Point(183, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 54);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(181, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 54);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserName.Location = new System.Drawing.Point(108, 108);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(142, 57);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Nombre de Usuario:";
            this.LblUserName.Click += new System.EventHandler(this.LblUserName_Click);
            // 
            // lblContraRegis
            // 
            this.lblContraRegis.AutoSize = true;
            this.lblContraRegis.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContraRegis.Location = new System.Drawing.Point(164, 165);
            this.lblContraRegis.Name = "lblContraRegis";
            this.lblContraRegis.Size = new System.Drawing.Size(86, 54);
            this.lblContraRegis.TabIndex = 2;
            this.lblContraRegis.Text = "Contraseña:";
            // 
            // lblconfimPass
            // 
            this.lblconfimPass.AutoSize = true;
            this.lblconfimPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblconfimPass.Location = new System.Drawing.Point(96, 219);
            this.lblconfimPass.Name = "lblconfimPass";
            this.lblconfimPass.Size = new System.Drawing.Size(154, 44);
            this.lblconfimPass.TabIndex = 2;
            this.lblconfimPass.Text = "Confirmar contraseña:";
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegNombre.Location = new System.Drawing.Point(256, 3);
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(247, 27);
            this.txtRegNombre.TabIndex = 3;
            // 
            // TxtRegApellido
            // 
            this.TxtRegApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegApellido.Location = new System.Drawing.Point(256, 57);
            this.TxtRegApellido.Name = "TxtRegApellido";
            this.TxtRegApellido.Size = new System.Drawing.Size(247, 27);
            this.TxtRegApellido.TabIndex = 3;
            // 
            // TxtRegUserName
            // 
            this.TxtRegUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegUserName.Location = new System.Drawing.Point(256, 111);
            this.TxtRegUserName.Name = "TxtRegUserName";
            this.TxtRegUserName.Size = new System.Drawing.Size(247, 27);
            this.TxtRegUserName.TabIndex = 3;
            // 
            // TxtRegContra
            // 
            this.TxtRegContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegContra.Location = new System.Drawing.Point(256, 168);
            this.TxtRegContra.Name = "TxtRegContra";
            this.TxtRegContra.Size = new System.Drawing.Size(247, 27);
            this.TxtRegContra.TabIndex = 3;
            // 
            // TxtRegConfirmContra
            // 
            this.TxtRegConfirmContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegConfirmContra.Location = new System.Drawing.Point(256, 222);
            this.TxtRegConfirmContra.Name = "TxtRegConfirmContra";
            this.TxtRegConfirmContra.Size = new System.Drawing.Size(247, 27);
            this.TxtRegConfirmContra.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRegGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnRegCancelar, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(150, 357);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 90);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnRegGuardar
            // 
            this.BtnRegGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegGuardar.Location = new System.Drawing.Point(3, 3);
            this.BtnRegGuardar.Name = "BtnRegGuardar";
            this.BtnRegGuardar.Size = new System.Drawing.Size(500, 39);
            this.BtnRegGuardar.TabIndex = 0;
            this.BtnRegGuardar.Text = "Guardar";
            this.BtnRegGuardar.UseVisualStyleBackColor = true;
            this.BtnRegGuardar.Click += new System.EventHandler(this.BtnRegGuardar_Click);
            // 
            // BtnRegCancelar
            // 
            this.BtnRegCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegCancelar.Location = new System.Drawing.Point(3, 48);
            this.BtnRegCancelar.Name = "BtnRegCancelar";
            this.BtnRegCancelar.Size = new System.Drawing.Size(500, 39);
            this.BtnRegCancelar.TabIndex = 0;
            this.BtnRegCancelar.Text = "Cancelar";
            this.BtnRegCancelar.UseVisualStyleBackColor = true;
            this.BtnRegCancelar.Click += new System.EventHandler(this.BtnRegCancelar_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 24.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(150, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(506, 85);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.Text = "Registro de Usuario";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmRegistroUser";
            this.Text = "frmRegistroUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroUser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegistroUser_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label lblContraRegis;
        private System.Windows.Forms.Label lblconfimPass;
        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.TextBox TxtRegApellido;
        private System.Windows.Forms.TextBox TxtRegUserName;
        private System.Windows.Forms.TextBox TxtRegContra;
        private System.Windows.Forms.TextBox TxtRegConfirmContra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnRegGuardar;
        private System.Windows.Forms.Button BtnRegCancelar;
        private System.Windows.Forms.Label lblRegister;
    }
}