namespace CRUDprueba
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
            tNombre = new TextBox();
            tApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tCorreo = new TextBox();
            btnAgregar = new Button();
            datosClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datosClientes).BeginInit();
            SuspendLayout();
            // 
            // tNombre
            // 
            tNombre.Location = new Point(162, 88);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(196, 23);
            tNombre.TabIndex = 0;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(162, 154);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(196, 23);
            tApellido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 88);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 162);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 225);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "correo";
            // 
            // tCorreo
            // 
            tCorreo.Location = new Point(162, 217);
            tCorreo.Name = "tCorreo";
            tCorreo.Size = new Size(196, 23);
            tCorreo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(414, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // datosClientes
            // 
            datosClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosClientes.Location = new Point(12, 278);
            datosClientes.Name = "datosClientes";
            datosClientes.RowTemplate.Height = 25;
            datosClientes.Size = new Size(776, 150);
            datosClientes.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datosClientes);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(tCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tApellido);
            Controls.Add(tNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)datosClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tNombre;
        private TextBox tApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tCorreo;
        private Button btnAgregar;
        private DataGridView datosClientes;
    }
}