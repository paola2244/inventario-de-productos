namespace InventarioFacturacion.vista
{
    partial class RegistrarEmpleadoVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarEmpleadoVista));
            panel1 = new Panel();
            btnGuardar = new Button();
            button2 = new Button();
            btnCancelar = new Button();
            dataGriedViewEmpleados = new DataGridView();
            cmbCargo = new ComboBox();
            pictureBox1 = new PictureBox();
            Correotxt = new TextBox();
            label6 = new Label();
            Direcciontxt = new TextBox();
            Ciudadtxt = new TextBox();
            telefonotxt = new TextBox();
            Cedulatxt = new TextBox();
            Apellidotxt = new TextBox();
            Nombretxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriedViewEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(dataGriedViewEmpleados);
            panel1.Controls.Add(cmbCargo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Correotxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Direcciontxt);
            panel1.Controls.Add(Ciudadtxt);
            panel1.Controls.Add(telefonotxt);
            panel1.Controls.Add(Cedulatxt);
            panel1.Controls.Add(Apellidotxt);
            panel1.Controls.Add(Nombretxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 925);
            panel1.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(644, 563);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 51);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(832, 563);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(136, 51);
            button2.TabIndex = 36;
            button2.Text = "Listar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.AliceBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.DodgerBlue;
            btnCancelar.Location = new Point(1022, 563);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 51);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Eliminar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnEliminar_Click;
            // 
            // dataGriedViewEmpleados
            // 
            dataGriedViewEmpleados.BackgroundColor = Color.White;
            dataGriedViewEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGriedViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriedViewEmpleados.Location = new Point(31, 673);
            dataGriedViewEmpleados.Margin = new Padding(3, 4, 3, 4);
            dataGriedViewEmpleados.Name = "dataGriedViewEmpleados";
            dataGriedViewEmpleados.RowHeadersWidth = 51;
            dataGriedViewEmpleados.Size = new Size(1249, 183);
            dataGriedViewEmpleados.TabIndex = 38;
            // 
            // cmbCargo
            // 
            cmbCargo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(777, 480);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(253, 36);
            cmbCargo.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(753, 149);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Correotxt
            // 
            Correotxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Correotxt.Location = new Point(175, 551);
            Correotxt.Margin = new Padding(3, 4, 3, 4);
            Correotxt.Name = "Correotxt";
            Correotxt.Size = new Size(379, 34);
            Correotxt.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 563);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 28;
            label6.Text = "Correo:";
            // 
            // Direcciontxt
            // 
            Direcciontxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direcciontxt.Location = new Point(175, 475);
            Direcciontxt.Margin = new Padding(3, 4, 3, 4);
            Direcciontxt.Name = "Direcciontxt";
            Direcciontxt.Size = new Size(379, 34);
            Direcciontxt.TabIndex = 27;
            // 
            // Ciudadtxt
            // 
            Ciudadtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ciudadtxt.Location = new Point(175, 399);
            Ciudadtxt.Margin = new Padding(3, 4, 3, 4);
            Ciudadtxt.Name = "Ciudadtxt";
            Ciudadtxt.Size = new Size(379, 34);
            Ciudadtxt.TabIndex = 26;
            // 
            // telefonotxt
            // 
            telefonotxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonotxt.Location = new Point(175, 327);
            telefonotxt.Margin = new Padding(3, 4, 3, 4);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(379, 34);
            telefonotxt.TabIndex = 25;
            // 
            // Cedulatxt
            // 
            Cedulatxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cedulatxt.Location = new Point(175, 249);
            Cedulatxt.Margin = new Padding(3, 4, 3, 4);
            Cedulatxt.Name = "Cedulatxt";
            Cedulatxt.Size = new Size(379, 34);
            Cedulatxt.TabIndex = 24;
            // 
            // Apellidotxt
            // 
            Apellidotxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Apellidotxt.Location = new Point(175, 179);
            Apellidotxt.Margin = new Padding(3, 4, 3, 4);
            Apellidotxt.Name = "Apellidotxt";
            Apellidotxt.Size = new Size(379, 34);
            Apellidotxt.TabIndex = 23;
            // 
            // Nombretxt
            // 
            Nombretxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombretxt.Location = new Point(175, 109);
            Nombretxt.Margin = new Padding(3, 4, 3, 4);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(379, 34);
            Nombretxt.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 179);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 21;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 480);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 20;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 399);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 19;
            label3.Text = "Ciudad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 327);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 17;
            label2.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 255);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 16;
            label1.Text = "Cedula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 115);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 15;
            label10.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(766, 36);
            label7.Name = "label7";
            label7.Size = new Size(299, 50);
            label7.TabIndex = 9;
            label7.Text = "Crear Empleado";
            // 
            // RegistrarEmpleadoVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 973);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarEmpleadoVista";
            Text = "RegistrarEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriedViewEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox Correotxt;
        private Label label6;
        private TextBox Direcciontxt;
        private TextBox Ciudadtxt;
        private TextBox telefonotxt;
        private TextBox Cedulatxt;
        private TextBox Apellidotxt;
        private TextBox Nombretxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button2;
        private ComboBox cmbCargo;
        private DataGridView dataGriedViewEmpleados;
    }
}