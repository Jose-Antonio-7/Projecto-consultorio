namespace Consultorio.Presentacion.Formularios
{
    partial class FrmDoctores
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
            this.btnConfirmarDoctor = new System.Windows.Forms.Button();
            this.dtgDoctores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefonoDoctor = new System.Windows.Forms.TextBox();
            this.tbCedulaDoctor = new System.Windows.Forms.TextBox();
            this.tbApellidoDoctor = new System.Windows.Forms.TextBox();
            this.tbNombreDoctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarDoctor
            // 
            this.btnConfirmarDoctor.Location = new System.Drawing.Point(58, 350);
            this.btnConfirmarDoctor.Name = "btnConfirmarDoctor";
            this.btnConfirmarDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarDoctor.TabIndex = 25;
            this.btnConfirmarDoctor.Text = "Confirmar";
            this.btnConfirmarDoctor.UseVisualStyleBackColor = true;
            this.btnConfirmarDoctor.Click += new System.EventHandler(this.btnConfirmarDoctor_Click);
            // 
            // dtgDoctores
            // 
            this.dtgDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoctores.Location = new System.Drawing.Point(228, 99);
            this.dtgDoctores.Name = "dtgDoctores";
            this.dtgDoctores.RowTemplate.Height = 25;
            this.dtgDoctores.Size = new System.Drawing.Size(526, 305);
            this.dtgDoctores.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(276, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Registro de doctores";
            // 
            // tbTelefonoDoctor
            // 
            this.tbTelefonoDoctor.Location = new System.Drawing.Point(45, 314);
            this.tbTelefonoDoctor.Name = "tbTelefonoDoctor";
            this.tbTelefonoDoctor.Size = new System.Drawing.Size(100, 23);
            this.tbTelefonoDoctor.TabIndex = 22;
            // 
            // tbCedulaDoctor
            // 
            this.tbCedulaDoctor.Location = new System.Drawing.Point(46, 241);
            this.tbCedulaDoctor.Name = "tbCedulaDoctor";
            this.tbCedulaDoctor.Size = new System.Drawing.Size(100, 23);
            this.tbCedulaDoctor.TabIndex = 20;
            // 
            // tbApellidoDoctor
            // 
            this.tbApellidoDoctor.Location = new System.Drawing.Point(46, 170);
            this.tbApellidoDoctor.Name = "tbApellidoDoctor";
            this.tbApellidoDoctor.Size = new System.Drawing.Size(100, 23);
            this.tbApellidoDoctor.TabIndex = 19;
            // 
            // tbNombreDoctor
            // 
            this.tbNombreDoctor.Location = new System.Drawing.Point(46, 99);
            this.tbNombreDoctor.Name = "tbNombreDoctor";
            this.tbNombreDoctor.Size = new System.Drawing.Size(100, 23);
            this.tbNombreDoctor.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // FrmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmarDoctor);
            this.Controls.Add(this.dtgDoctores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefonoDoctor);
            this.Controls.Add(this.tbCedulaDoctor);
            this.Controls.Add(this.tbApellidoDoctor);
            this.Controls.Add(this.tbNombreDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoctores";
            this.Text = "Registro de doctores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConfirmarDoctor;
        private DataGridView dtgDoctores;
        private Label label6;
        private TextBox tbTelefonoDoctor;
        private TextBox tbCedulaDoctor;
        private TextBox tbApellidoDoctor;
        private TextBox tbNombreDoctor;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}