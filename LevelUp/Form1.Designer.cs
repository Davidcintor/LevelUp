namespace LevelUp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrar = new Button();
            dgvClientes = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 12);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(99, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 73);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(837, 218);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 318);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 315);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(780, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 347);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 344);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(780, 23);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 376);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(69, 373);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(780, 23);
            txtTelefono.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(774, 409);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(693, 409);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(612, 409);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 444);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Controls.Add(btnMostrar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private DataGridView dgvClientes;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnBorrar;
    }
}
