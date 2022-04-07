namespace proysustiCliente
{
    partial class CompPagoUI
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgMov = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbmSubtipo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.dtpFechaAC = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.Label();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActa = new System.Windows.Forms.ComboBox();
            this.txtActaCom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMov)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Cambio";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(167, 107);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Moneda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtgMov
            // 
            this.dtgMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMov.Location = new System.Drawing.Point(35, 225);
            this.dtgMov.Name = "dtgMov";
            this.dtgMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMov.Size = new System.Drawing.Size(452, 125);
            this.dtgMov.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(35, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(377, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(296, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(215, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(134, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(53, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RUC";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Monto S/.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(167, 135);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 14;
            // 
            // cbmSubtipo
            // 
            this.cbmSubtipo.FormattingEnabled = true;
            this.cbmSubtipo.Items.AddRange(new object[] {
            "I",
            "G"});
            this.cbmSubtipo.Location = new System.Drawing.Point(167, 79);
            this.cbmSubtipo.Name = "cbmSubtipo";
            this.cbmSubtipo.Size = new System.Drawing.Size(121, 21);
            this.cbmSubtipo.TabIndex = 18;
            this.cbmSubtipo.SelectedIndexChanged += new System.EventHandler(this.cbmSubtipo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto $";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(399, 83);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Número";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(167, 53);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(100, 20);
            this.txtRUC.TabIndex = 22;
            // 
            // dtpFechaAC
            // 
            this.dtpFechaAC.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaAC.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFechaAC.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaAC.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAC.Location = new System.Drawing.Point(369, 56);
            this.dtpFechaAC.Name = "dtpFechaAC";
            this.dtpFechaAC.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaAC.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fec. Emision";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I",
            "G"});
            this.comboBox1.Location = new System.Drawing.Point(167, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Raz.Soc";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Fec. Tipo Cambio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tipo CP";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(107, 165);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(48, 13);
            this.Personal.TabIndex = 43;
            this.Personal.Text = "Personal";
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(279, 162);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(44, 20);
            this.txtIdPersonal.TabIndex = 42;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbPersonal.Location = new System.Drawing.Point(167, 161);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(100, 21);
            this.cmbPersonal.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Acta de Compromiso";
            // 
            // cmbActa
            // 
            this.cmbActa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActa.FormattingEnabled = true;
            this.cmbActa.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbActa.Location = new System.Drawing.Point(169, 188);
            this.cmbActa.Name = "cmbActa";
            this.cmbActa.Size = new System.Drawing.Size(100, 21);
            this.cmbActa.TabIndex = 45;
            // 
            // txtActaCom
            // 
            this.txtActaCom.Location = new System.Drawing.Point(281, 190);
            this.txtActaCom.Name = "txtActaCom";
            this.txtActaCom.Size = new System.Drawing.Size(44, 20);
            this.txtActaCom.TabIndex = 46;
            // 
            // CompPagoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 456);
            this.Controls.Add(this.txtActaCom);
            this.Controls.Add(this.cmbActa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaAC);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbmSubtipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgMov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Name = "CompPagoUI";
            this.Text = "Comprobante de Pago";
            this.Load += new System.EventHandler(this.CompPagoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMov)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgMov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbmSubtipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.DateTimePicker dtpFechaAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Personal;
        private System.Windows.Forms.TextBox txtIdPersonal;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActa;
        private System.Windows.Forms.TextBox txtActaCom;
    }
}