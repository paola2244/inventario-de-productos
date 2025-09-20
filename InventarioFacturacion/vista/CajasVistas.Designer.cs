namespace InventarioFacturacion.vista
{
    partial class CajasVistas
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
            cmbEmpresa = new ComboBox();
            cmbCajas = new ComboBox();
            TEXTO = new Label();
            TEXTO2 = new Label();
            CajasVista = new Panel();
            Bienvenido = new Label();
            button1 = new Button();
            Botoningresar = new Button();
            CajasVista.SuspendLayout();
            SuspendLayout();
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Items.AddRange(new object[] { "La feria del juguete" });
            cmbEmpresa.Location = new Point(113, 259);
            cmbEmpresa.Margin = new Padding(3, 4, 3, 4);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(435, 33);
            cmbEmpresa.TabIndex = 1;
            cmbEmpresa.Text = "Empresa *";
            // 
            // cmbCajas
            // 
            cmbCajas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCajas.FormattingEnabled = true;
            cmbCajas.Items.AddRange(new object[] { "CAJA 1", "CAJA 2" });
            cmbCajas.Location = new Point(113, 345);
            cmbCajas.Margin = new Padding(3, 4, 3, 4);
            cmbCajas.Name = "cmbCajas";
            cmbCajas.Size = new Size(435, 33);
            cmbCajas.TabIndex = 3;
            cmbCajas.Text = "Cajas *";
            // 
            // TEXTO
            // 
            TEXTO.AutoSize = true;
            TEXTO.Font = new Font("Segoe UI", 13F);
            TEXTO.Location = new Point(55, 108);
            TEXTO.Name = "TEXTO";
            TEXTO.Size = new Size(618, 30);
            TEXTO.TabIndex = 4;
            TEXTO.Text = "Para comenzar a utilizar la aplicación, es necesario que elijas la ";
            // 
            // TEXTO2
            // 
            TEXTO2.AutoSize = true;
            TEXTO2.Font = new Font("Segoe UI", 13F);
            TEXTO2.Location = new Point(98, 155);
            TEXTO2.Name = "TEXTO2";
            TEXTO2.Size = new Size(480, 30);
            TEXTO2.TabIndex = 5;
            TEXTO2.Text = "empresa y la caja que utilizarás en esta maquina.";
            // 
            // CajasVista
            // 
            CajasVista.BorderStyle = BorderStyle.FixedSingle;
            CajasVista.Controls.Add(Bienvenido);
            CajasVista.Controls.Add(button1);
            CajasVista.Controls.Add(Botoningresar);
            CajasVista.Controls.Add(cmbCajas);
            CajasVista.Controls.Add(TEXTO2);
            CajasVista.Controls.Add(cmbEmpresa);
            CajasVista.Controls.Add(TEXTO);
            CajasVista.Location = new Point(457, 201);
            CajasVista.Margin = new Padding(3, 4, 3, 4);
            CajasVista.Name = "CajasVista";
            CajasVista.Size = new Size(660, 590);
            CajasVista.TabIndex = 6;
            // 
            // Bienvenido
            // 
            Bienvenido.AutoSize = true;
            Bienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bienvenido.ForeColor = Color.DodgerBlue;
            Bienvenido.Location = new Point(256, 32);
            Bienvenido.Name = "Bienvenido";
            Bienvenido.Size = new Size(189, 41);
            Bienvenido.TabIndex = 8;
            Bienvenido.Text = "Bienvenidos";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(247, 497);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 53);
            button1.TabIndex = 7;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // Botoningresar
            // 
            Botoningresar.BackColor = Color.DodgerBlue;
            Botoningresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botoningresar.ForeColor = SystemColors.ControlLightLight;
            Botoningresar.Location = new Point(247, 423);
            Botoningresar.Margin = new Padding(3, 4, 3, 4);
            Botoningresar.Name = "Botoningresar";
            Botoningresar.Size = new Size(160, 53);
            Botoningresar.TabIndex = 6;
            Botoningresar.Text = "Ingresar";
            Botoningresar.UseVisualStyleBackColor = false;
            Botoningresar.Click += Botoningresar_Click;
            // 
            // CajasVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 871);
            Controls.Add(CajasVista);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CajasVistas";
            Text = "Cajas";
            CajasVista.ResumeLayout(false);
            CajasVista.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbEmpresa;
        private ComboBox cmbCajas;
        private Label TEXTO;
        private Label TEXTO2;
        private Button button1;
        private Button Botoningresar;
        public Panel CajasVista;
        private Label Bienvenido;
    }
}