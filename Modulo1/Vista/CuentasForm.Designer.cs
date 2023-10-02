namespace Vista
{
    partial class CuentasForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            NacimientoDateTimePicker = new DateTimePicker();
            label4 = new Label();
            GeneroComboBox = new ComboBox();
            label3 = new Label();
            NombreTxt = new TextBox();
            label2 = new Label();
            IdentidadTxt = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            SaldoTxt = new TextBox();
            label7 = new Label();
            CodigoCuentaTxt = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            TipoMovimientoComboBox = new ComboBox();
            MontoTxt = new TextBox();
            label10 = new Label();
            AperturarButton = new Button();
            AgregarButton = new Button();
            MovimientosListBox = new ListBox();
            NombreErrorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NombreErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NacimientoDateTimePicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(GeneroComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(NombreTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IdentidadTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 15);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(775, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Cliente";
            // 
            // NacimientoDateTimePicker
            // 
            NacimientoDateTimePicker.Format = DateTimePickerFormat.Short;
            NacimientoDateTimePicker.Location = new Point(599, 41);
            NacimientoDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            NacimientoDateTimePicker.Name = "NacimientoDateTimePicker";
            NacimientoDateTimePicker.Size = new Size(151, 35);
            NacimientoDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 44);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 6;
            label4.Text = "Fecha Nacimiento:";
            // 
            // GeneroComboBox
            // 
            GeneroComboBox.FormattingEnabled = true;
            GeneroComboBox.Items.AddRange(new object[] { "F", "M" });
            GeneroComboBox.Location = new Point(599, 92);
            GeneroComboBox.Margin = new Padding(3, 2, 3, 2);
            GeneroComboBox.Name = "GeneroComboBox";
            GeneroComboBox.Size = new Size(151, 33);
            GeneroComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 98);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Genero:";
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(160, 96);
            NombreTxt.Margin = new Padding(3, 2, 3, 2);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(151, 35);
            NombreTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // IdentidadTxt
            // 
            IdentidadTxt.Location = new Point(160, 42);
            IdentidadTxt.Margin = new Padding(3, 2, 3, 2);
            IdentidadTxt.Name = "IdentidadTxt";
            IdentidadTxt.Size = new Size(151, 35);
            IdentidadTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Identidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SaldoTxt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CodigoCuentaTxt);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(808, 22);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(340, 150);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos De La Cuenta";
            // 
            // SaldoTxt
            // 
            SaldoTxt.Location = new Point(160, 96);
            SaldoTxt.Margin = new Padding(3, 2, 3, 2);
            SaldoTxt.Name = "SaldoTxt";
            SaldoTxt.ReadOnly = true;
            SaldoTxt.Size = new Size(151, 35);
            SaldoTxt.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 96);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 2;
            label7.Text = "Saldo";
            // 
            // CodigoCuentaTxt
            // 
            CodigoCuentaTxt.Location = new Point(160, 42);
            CodigoCuentaTxt.Margin = new Padding(3, 2, 3, 2);
            CodigoCuentaTxt.Name = "CodigoCuentaTxt";
            CodigoCuentaTxt.Size = new Size(151, 35);
            CodigoCuentaTxt.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 42);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 0;
            label8.Text = "Codigo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TipoMovimientoComboBox);
            groupBox3.Controls.Add(MontoTxt);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(27, 203);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1121, 104);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 43);
            label5.Name = "label5";
            label5.Size = new Size(216, 25);
            label5.TabIndex = 6;
            label5.Text = "Tipo de Movimiento:";
            // 
            // TipoMovimientoComboBox
            // 
            TipoMovimientoComboBox.FormattingEnabled = true;
            TipoMovimientoComboBox.Items.AddRange(new object[] { "F", "M" });
            TipoMovimientoComboBox.Location = new Point(604, 40);
            TipoMovimientoComboBox.Margin = new Padding(3, 2, 3, 2);
            TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            TipoMovimientoComboBox.Size = new Size(146, 33);
            TipoMovimientoComboBox.TabIndex = 5;
            // 
            // MontoTxt
            // 
            MontoTxt.Location = new Point(160, 42);
            MontoTxt.Margin = new Padding(3, 2, 3, 2);
            MontoTxt.Name = "MontoTxt";
            MontoTxt.Size = new Size(151, 35);
            MontoTxt.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 41);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 0;
            label10.Text = "Monto:";
            // 
            // AperturarButton
            // 
            AperturarButton.Location = new Point(911, 336);
            AperturarButton.Name = "AperturarButton";
            AperturarButton.Size = new Size(237, 34);
            AperturarButton.TabIndex = 9;
            AperturarButton.Text = "Aperturar Cuenta";
            AperturarButton.UseVisualStyleBackColor = true;
            AperturarButton.Click += AperturarButton_Click;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(645, 336);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(237, 34);
            AgregarButton.TabIndex = 10;
            AgregarButton.Text = "Agregar Movimiento";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // MovimientosListBox
            // 
            MovimientosListBox.FormattingEnabled = true;
            MovimientosListBox.ItemHeight = 25;
            MovimientosListBox.Location = new Point(27, 411);
            MovimientosListBox.Name = "MovimientosListBox";
            MovimientosListBox.Size = new Size(1121, 229);
            MovimientosListBox.TabIndex = 11;
            // 
            // NombreErrorProvider
            // 
            NombreErrorProvider.ContainerControl = this;
            // 
            // CuentasForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 654);
            Controls.Add(MovimientosListBox);
            Controls.Add(AgregarButton);
            Controls.Add(AperturarButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CuentasForm";
            Text = "CuentasForm";
            Load += CuentasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NombreErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox NombreTxt;
        private Label label2;
        private TextBox IdentidadTxt;
        private Label label1;
        private Label label4;
        private ComboBox GeneroComboBox;
        private DateTimePicker NacimientoDateTimePicker;
        private GroupBox groupBox2;
        private TextBox SaldoTxt;
        private Label label7;
        private TextBox CodigoCuentaTxt;
        private Label label8;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox TipoMovimientoComboBox;
        private TextBox MontoTxt;
        private Label label10;
        private Button AperturarButton;
        private Button AgregarButton;
        private ListBox MovimientosListBox;
        private ErrorProvider NombreErrorProvider;
    }
}