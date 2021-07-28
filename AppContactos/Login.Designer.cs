
namespace AppContactos
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.BtnIniciarSeccion = new System.Windows.Forms.Button();
            this.btnRegiatrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Controls.Add(this.lblLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 24.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(159, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(462, 68);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.UseMnemonic = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.91775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.08225F));
            this.tableLayoutPanel2.Controls.Add(this.TxtUserName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtPass, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblContra, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnIniciarSeccion, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnRegiatrar, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 246);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUserName.Location = new System.Drawing.Point(229, 3);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(230, 27);
            this.TxtUserName.TabIndex = 1;
            // 
            // TxtPass
            // 
            this.TxtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPass.Location = new System.Drawing.Point(229, 81);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(230, 27);
            this.TxtPass.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(61, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(162, 78);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Nombre de usuario:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContra.Location = new System.Drawing.Point(128, 78);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(95, 64);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contaseña:";
            // 
            // BtnIniciarSeccion
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BtnIniciarSeccion, 2);
            this.BtnIniciarSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIniciarSeccion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciarSeccion.Location = new System.Drawing.Point(3, 145);
            this.BtnIniciarSeccion.Name = "BtnIniciarSeccion";
            this.BtnIniciarSeccion.Size = new System.Drawing.Size(456, 45);
            this.BtnIniciarSeccion.TabIndex = 4;
            this.BtnIniciarSeccion.Text = "Iniciar Seccion";
            this.BtnIniciarSeccion.UseVisualStyleBackColor = true;
            this.BtnIniciarSeccion.Click += new System.EventHandler(this.BtnIniciarSeccion_Click);
            // 
            // btnRegiatrar
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnRegiatrar, 2);
            this.btnRegiatrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegiatrar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegiatrar.Location = new System.Drawing.Point(3, 196);
            this.btnRegiatrar.Name = "btnRegiatrar";
            this.btnRegiatrar.Size = new System.Drawing.Size(456, 47);
            this.btnRegiatrar.TabIndex = 5;
            this.btnRegiatrar.Text = "Registrar";
            this.btnRegiatrar.UseVisualStyleBackColor = true;
            this.btnRegiatrar.Click += new System.EventHandler(this.btnRegiatrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button BtnIniciarSeccion;
        private System.Windows.Forms.Button btnRegiatrar;
    }
}