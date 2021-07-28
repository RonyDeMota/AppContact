
namespace AppContactos
{
    partial class frmEditarContacto
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
            this.btnGuardarNewCont = new System.Windows.Forms.Button();
            this.btnCancelarNewCont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEditNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEditApellido = new System.Windows.Forms.TextBox();
            this.TxtEditDirction = new System.Windows.Forms.TextBox();
            this.TxtEditCelular = new System.Windows.Forms.TextBox();
            this.TxtEditTelefono = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.07629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.92371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardarNewCont, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelarNewCont, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(123, 370);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 77);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnGuardarNewCont
            // 
            this.btnGuardarNewCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardarNewCont.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarNewCont.Name = "btnGuardarNewCont";
            this.btnGuardarNewCont.Size = new System.Drawing.Size(543, 32);
            this.btnGuardarNewCont.TabIndex = 0;
            this.btnGuardarNewCont.Text = "Guardar";
            this.btnGuardarNewCont.UseVisualStyleBackColor = true;
            this.btnGuardarNewCont.Click += new System.EventHandler(this.btnGuardarNewCont_Click);
            // 
            // btnCancelarNewCont
            // 
            this.btnCancelarNewCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarNewCont.Location = new System.Drawing.Point(3, 41);
            this.btnCancelarNewCont.Name = "btnCancelarNewCont";
            this.btnCancelarNewCont.Size = new System.Drawing.Size(543, 33);
            this.btnCancelarNewCont.TabIndex = 0;
            this.btnCancelarNewCont.Text = "Cancelar";
            this.btnCancelarNewCont.UseVisualStyleBackColor = true;
            this.btnCancelarNewCont.Click += new System.EventHandler(this.btnCancelarNewCont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar Contacto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtEditNombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TxtEditApellido, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtEditDirction, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtEditCelular, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.TxtEditTelefono, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(123, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(549, 302);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtEditNombre
            // 
            this.txtEditNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditNombre.Location = new System.Drawing.Point(277, 3);
            this.txtEditNombre.Name = "txtEditNombre";
            this.txtEditNombre.Size = new System.Drawing.Size(269, 27);
            this.txtEditNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(204, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(202, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(196, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 59);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(213, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 66);
            this.label5.TabIndex = 1;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(201, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 65);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefono:";
            // 
            // TxtEditApellido
            // 
            this.TxtEditApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEditApellido.Location = new System.Drawing.Point(277, 59);
            this.TxtEditApellido.Name = "TxtEditApellido";
            this.TxtEditApellido.Size = new System.Drawing.Size(269, 27);
            this.TxtEditApellido.TabIndex = 0;
            // 
            // TxtEditDirction
            // 
            this.TxtEditDirction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEditDirction.Location = new System.Drawing.Point(277, 115);
            this.TxtEditDirction.Name = "TxtEditDirction";
            this.TxtEditDirction.Size = new System.Drawing.Size(269, 27);
            this.TxtEditDirction.TabIndex = 0;
            // 
            // TxtEditCelular
            // 
            this.TxtEditCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEditCelular.Location = new System.Drawing.Point(277, 174);
            this.TxtEditCelular.Name = "TxtEditCelular";
            this.TxtEditCelular.Size = new System.Drawing.Size(269, 27);
            this.TxtEditCelular.TabIndex = 0;
            // 
            // TxtEditTelefono
            // 
            this.TxtEditTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEditTelefono.Location = new System.Drawing.Point(277, 240);
            this.TxtEditTelefono.Name = "TxtEditTelefono";
            this.TxtEditTelefono.Size = new System.Drawing.Size(269, 27);
            this.TxtEditTelefono.TabIndex = 0;
            // 
            // frmEditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditarContacto";
            this.Text = "frmEditarContacto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditarContacto_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarContacto_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarContacto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGuardarNewCont;
        private System.Windows.Forms.Button btnCancelarNewCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtEditNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEditApellido;
        private System.Windows.Forms.TextBox TxtEditDirction;
        private System.Windows.Forms.TextBox TxtEditCelular;
        private System.Windows.Forms.TextBox TxtEditTelefono;
    }
}