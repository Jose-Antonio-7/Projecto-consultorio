namespace Consultorio.Presentacion.Formularios
{
    partial class FrmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbEdadCliente = new System.Windows.Forms.TextBox();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnConfirmarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(47, 97);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(100, 23);
            this.tbNombreCliente.TabIndex = 5;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(47, 168);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(100, 23);
            this.tbApellidoCliente.TabIndex = 6;
            // 
            // tbEdadCliente
            // 
            this.tbEdadCliente.Location = new System.Drawing.Point(47, 239);
            this.tbEdadCliente.Name = "tbEdadCliente";
            this.tbEdadCliente.Size = new System.Drawing.Size(100, 23);
            this.tbEdadCliente.TabIndex = 7;
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Location = new System.Drawing.Point(47, 305);
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(100, 23);
            this.tbDireccionCliente.TabIndex = 8;
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Location = new System.Drawing.Point(47, 379);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.Size = new System.Drawing.Size(100, 23);
            this.tbTelefonoCliente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(277, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Registro de clientes";
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(229, 97);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowTemplate.Height = 25;
            this.dtgClientes.Size = new System.Drawing.Size(526, 305);
            this.dtgClientes.TabIndex = 11;
            // 
            // btnConfirmarCliente
            // 
            this.btnConfirmarCliente.Location = new System.Drawing.Point(60, 415);
            this.btnConfirmarCliente.Name = "btnConfirmarCliente";
            this.btnConfirmarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarCliente.TabIndex = 12;
            this.btnConfirmarCliente.Text = "Confirmar";
            this.btnConfirmarCliente.UseVisualStyleBackColor = true;
            this.btnConfirmarCliente.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmarCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefonoCliente);
            this.Controls.Add(this.tbDireccionCliente);
            this.Controls.Add(this.tbEdadCliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombreCliente;
        private TextBox tbApellidoCliente;
        private TextBox tbEdadCliente;
        private TextBox tbDireccionCliente;
        private TextBox tbTelefonoCliente;
        private Label label6;
        private DataGridView dtgClientes;
        private Button btnConfirmarCliente;
    }
}