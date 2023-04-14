namespace Consultorio.Presentacion.Formularios
{
    partial class FrmUsers
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
            this.btnCrearUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearUser
            // 
            this.btnCrearUser.Location = new System.Drawing.Point(75, 181);
            this.btnCrearUser.Name = "btnCrearUser";
            this.btnCrearUser.Size = new System.Drawing.Size(75, 23);
            this.btnCrearUser.TabIndex = 0;
            this.btnCrearUser.Text = "Crear";
            this.btnCrearUser.UseVisualStyleBackColor = true;
            this.btnCrearUser.Click += new System.EventHandler(this.btnCrearUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(64, 69);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 23);
            this.txtLogin.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(64, 133);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 23);
            this.txtContraseña.TabIndex = 4;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 245);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearUser);
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrearUser;
        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtContraseña;
    }
}