namespace InventarioFacturacion.vista
{
    partial class TurnosVista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BotonAbrirTurno = new Button();
            panel1 = new Panel();
            lblInfo = new Label();
            PanelCerrarTurno = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TotalCaja = new TextBox();
            label3 = new Label();
            VentasOtroMedio = new TextBox();
            VentasEfectivo = new TextBox();
            BaseCaja = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            FechaInicio = new DateTimePicker();
            NombreDelCajero = new Label();
            NumeroDelTurno = new Label();
            TextoDetalleTurno = new Label();
            BotonCerrarTurno = new Button();
            label1 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Cajero = new DataGridViewTextBoxColumn();
            FechaIncicial = new DataGridViewTextBoxColumn();
            FechaSalida = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            PanelCerrarTurno.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BotonAbrirTurno
            // 
            BotonAbrirTurno.BackColor = Color.DodgerBlue;
            BotonAbrirTurno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAbrirTurno.ForeColor = SystemColors.ControlLightLight;
            BotonAbrirTurno.Location = new Point(242, 417);
            BotonAbrirTurno.Margin = new Padding(3, 4, 3, 4);
            BotonAbrirTurno.Name = "BotonAbrirTurno";
            BotonAbrirTurno.Size = new Size(160, 53);
            BotonAbrirTurno.TabIndex = 7;
            BotonAbrirTurno.Text = "+ Abrir Turno";
            BotonAbrirTurno.UseVisualStyleBackColor = false;
            BotonAbrirTurno.Click += BotonAbrirTurno_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblInfo);
            panel1.Controls.Add(PanelCerrarTurno);
            panel1.Controls.Add(BotonCerrarTurno);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpFinal);
            panel1.Controls.Add(dtpInicio);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BotonAbrirTurno);
            panel1.Location = new Point(26, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 907);
            panel1.TabIndex = 8;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(613, 33);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(110, 20);
            lblInfo.TabIndex = 13;
            lblInfo.Text = "Caja y Empresa";
            // 
            // PanelCerrarTurno
            // 
            PanelCerrarTurno.AutoScroll = true;
            PanelCerrarTurno.BorderStyle = BorderStyle.Fixed3D;
            PanelCerrarTurno.Controls.Add(button1);
            PanelCerrarTurno.Controls.Add(panel4);
            PanelCerrarTurno.Controls.Add(label7);
            PanelCerrarTurno.Controls.Add(label6);
            PanelCerrarTurno.Controls.Add(label5);
            PanelCerrarTurno.Controls.Add(label4);
            PanelCerrarTurno.Controls.Add(TotalCaja);
            PanelCerrarTurno.Controls.Add(label3);
            PanelCerrarTurno.Controls.Add(VentasOtroMedio);
            PanelCerrarTurno.Controls.Add(VentasEfectivo);
            PanelCerrarTurno.Controls.Add(BaseCaja);
            PanelCerrarTurno.Controls.Add(label2);
            PanelCerrarTurno.Controls.Add(panel3);
            PanelCerrarTurno.Controls.Add(TextoDetalleTurno);
            PanelCerrarTurno.Location = new Point(955, 17);
            PanelCerrarTurno.Margin = new Padding(3, 4, 3, 4);
            PanelCerrarTurno.Name = "PanelCerrarTurno";
            PanelCerrarTurno.Size = new Size(363, 849);
            PanelCerrarTurno.TabIndex = 12;
            PanelCerrarTurno.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(90, 769);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 53);
            button1.TabIndex = 13;
            button1.Text = " - Cerrar Turno";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(30, 615);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(311, 133);
            panel4.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(21, 87);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 26);
            dateTimePicker1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 44);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 1;
            label8.Text = "Diferencia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 12);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 0;
            label9.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 520);
            label7.Name = "label7";
            label7.Size = new Size(116, 19);
            label7.TabIndex = 11;
            label7.Text = "Total Real En Caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 357);
            label6.Name = "label6";
            label6.Size = new Size(237, 19);
            label6.TabIndex = 10;
            label6.Text = "Total Ventas por otro Medio De Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 284);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 9;
            label5.Text = "Total Ventas En Efectivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 217);
            label4.Name = "label4";
            label4.Size = new Size(159, 19);
            label4.TabIndex = 8;
            label4.Text = "Total Base Inicial De Caja";
            // 
            // TotalCaja
            // 
            TotalCaja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCaja.Location = new Point(30, 541);
            TotalCaja.Margin = new Padding(3, 4, 3, 4);
            TotalCaja.Name = "TotalCaja";
            TotalCaja.Size = new Size(310, 34);
            TotalCaja.TabIndex = 7;
            TotalCaja.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 467);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 6;
            label3.Text = "Total En Caja";
            // 
            // VentasOtroMedio
            // 
            VentasOtroMedio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentasOtroMedio.Location = new Point(26, 379);
            VentasOtroMedio.Margin = new Padding(3, 4, 3, 4);
            VentasOtroMedio.Name = "VentasOtroMedio";
            VentasOtroMedio.Size = new Size(314, 34);
            VentasOtroMedio.TabIndex = 5;
            // 
            // VentasEfectivo
            // 
            VentasEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentasEfectivo.Location = new Point(26, 305);
            VentasEfectivo.Margin = new Padding(3, 4, 3, 4);
            VentasEfectivo.Name = "VentasEfectivo";
            VentasEfectivo.Size = new Size(314, 34);
            VentasEfectivo.TabIndex = 4;
            // 
            // BaseCaja
            // 
            BaseCaja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaseCaja.Location = new Point(26, 239);
            BaseCaja.Margin = new Padding(3, 4, 3, 4);
            BaseCaja.Name = "BaseCaja";
            BaseCaja.Size = new Size(314, 34);
            BaseCaja.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 181);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "Ventas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(FechaInicio);
            panel3.Controls.Add(NombreDelCajero);
            panel3.Controls.Add(NumeroDelTurno);
            panel3.Location = new Point(26, 64);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 99);
            panel3.TabIndex = 1;
            // 
            // FechaInicio
            // 
            FechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaInicio.Location = new Point(11, 52);
            FechaInicio.Margin = new Padding(3, 4, 3, 4);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(281, 27);
            FechaInicio.TabIndex = 9;
            // 
            // NombreDelCajero
            // 
            NombreDelCajero.AutoSize = true;
            NombreDelCajero.Location = new Point(98, 12);
            NombreDelCajero.Name = "NombreDelCajero";
            NombreDelCajero.Size = new Size(52, 20);
            NombreDelCajero.TabIndex = 1;
            NombreDelCajero.Text = "Cajero";
            // 
            // NumeroDelTurno
            // 
            NumeroDelTurno.AutoSize = true;
            NumeroDelTurno.Location = new Point(11, 12);
            NumeroDelTurno.Name = "NumeroDelTurno";
            NumeroDelTurno.Size = new Size(39, 20);
            NumeroDelTurno.TabIndex = 0;
            NumeroDelTurno.Text = "Item";
            // 
            // TextoDetalleTurno
            // 
            TextoDetalleTurno.AutoSize = true;
            TextoDetalleTurno.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextoDetalleTurno.Location = new Point(71, 15);
            TextoDetalleTurno.Name = "TextoDetalleTurno";
            TextoDetalleTurno.Size = new Size(227, 37);
            TextoDetalleTurno.TabIndex = 0;
            TextoDetalleTurno.Text = "Detalle Del Turno";
            // 
            // BotonCerrarTurno
            // 
            BotonCerrarTurno.BackColor = Color.DodgerBlue;
            BotonCerrarTurno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonCerrarTurno.ForeColor = SystemColors.ControlLightLight;
            BotonCerrarTurno.Location = new Point(579, 417);
            BotonCerrarTurno.Margin = new Padding(3, 4, 3, 4);
            BotonCerrarTurno.Name = "BotonCerrarTurno";
            BotonCerrarTurno.Size = new Size(160, 53);
            BotonCerrarTurno.TabIndex = 11;
            BotonCerrarTurno.Text = " - Cerrar Turno";
            BotonCerrarTurno.UseVisualStyleBackColor = false;
            BotonCerrarTurno.Click += BotonCerrarTurno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 35);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 10;
            label1.Text = "a";
            // 
            // dtpFinal
            // 
            dtpFinal.Location = new Point(325, 31);
            dtpFinal.Margin = new Padding(3, 4, 3, 4);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(228, 27);
            dtpFinal.TabIndex = 9;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(34, 31);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(228, 27);
            dtpInicio.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.MenuBar;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Cajero, FechaIncicial, FechaSalida, Estado });
            dataGridView1.Location = new Point(24, 135);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(907, 200);
            dataGridView1.TabIndex = 0;
            // 
            // Item
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            Item.DefaultCellStyle = dataGridViewCellStyle1;
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 80;
            // 
            // Cajero
            // 
            Cajero.HeaderText = "Cajero";
            Cajero.MinimumWidth = 20;
            Cajero.Name = "Cajero";
            Cajero.Width = 210;
            // 
            // FechaIncicial
            // 
            FechaIncicial.HeaderText = "Fecha De Inicio";
            FechaIncicial.MinimumWidth = 20;
            FechaIncicial.Name = "FechaIncicial";
            FechaIncicial.Width = 150;
            // 
            // FechaSalida
            // 
            FechaSalida.HeaderText = "Fecha De Salida";
            FechaSalida.MinimumWidth = 20;
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 20;
            Estado.Name = "Estado";
            Estado.Width = 160;
            // 
            // TurnosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 939);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TurnosVista";
            Text = "Turnos";
            Load += Turnos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelCerrarTurno.ResumeLayout(false);
            PanelCerrarTurno.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotonAbrirTurno;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private Label label1;
        private Button BotonCerrarTurno;
        private Panel PanelCerrarTurno;
        private Panel panel3;
        private Label NumeroDelTurno;
        private Label TextoDetalleTurno;
        private TextBox VentasOtroMedio;
        private TextBox VentasEfectivo;
        private TextBox BaseCaja;
        private Label label2;
        private DateTimePicker FechaInicio;
        private Label NombreDelCajero;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TotalCaja;
        private Label label3;
        private Label label7;
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label9;
        private Button button1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Cajero;
        private DataGridViewTextBoxColumn FechaIncicial;
        private DataGridViewTextBoxColumn FechaSalida;
        private DataGridViewTextBoxColumn Estado;
        private Label lblInfo;
    }
}