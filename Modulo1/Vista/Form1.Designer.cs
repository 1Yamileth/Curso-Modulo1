namespace Vista
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NombreTextBox = new TextBox();
            EstaturaTextBox = new TextBox();
            EdadTextBox = new TextBox();
            GeneroTextBox = new TextBox();
            NacimientoDateTimePicker = new DateTimePicker();
            CrearButton = new Button();
            MostrarButton = new Button();
            PersonasDataGridView = new DataGridView();
            PersonaBindingSource = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 102);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Estatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 239);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 3;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 304);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha De Nacimiento:";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(424, 32);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(158, 31);
            NombreTextBox.TabIndex = 5;
            // 
            // EstaturaTextBox
            // 
            EstaturaTextBox.Location = new Point(424, 100);
            EstaturaTextBox.Name = "EstaturaTextBox";
            EstaturaTextBox.Size = new Size(158, 31);
            EstaturaTextBox.TabIndex = 6;
            // 
            // EdadTextBox
            // 
            EdadTextBox.Location = new Point(424, 168);
            EdadTextBox.Name = "EdadTextBox";
            EdadTextBox.ReadOnly = true;
            EdadTextBox.Size = new Size(158, 31);
            EdadTextBox.TabIndex = 7;
            // 
            // GeneroTextBox
            // 
            GeneroTextBox.Location = new Point(424, 236);
            GeneroTextBox.Name = "GeneroTextBox";
            GeneroTextBox.Size = new Size(158, 31);
            GeneroTextBox.TabIndex = 8;
            // 
            // NacimientoDateTimePicker
            // 
            NacimientoDateTimePicker.Format = DateTimePickerFormat.Short;
            NacimientoDateTimePicker.Location = new Point(424, 304);
            NacimientoDateTimePicker.Name = "NacimientoDateTimePicker";
            NacimientoDateTimePicker.Size = new Size(158, 31);
            NacimientoDateTimePicker.TabIndex = 10;
            // 
            // CrearButton
            // 
            CrearButton.Location = new Point(424, 367);
            CrearButton.Name = "CrearButton";
            CrearButton.Size = new Size(112, 34);
            CrearButton.TabIndex = 11;
            CrearButton.Text = "Agregar";
            CrearButton.UseVisualStyleBackColor = true;
            CrearButton.Click += CrearButton_Click;
            // 
            // MostrarButton
            // 
            MostrarButton.Location = new Point(248, 367);
            MostrarButton.Name = "MostrarButton";
            MostrarButton.Size = new Size(112, 34);
            MostrarButton.TabIndex = 12;
            MostrarButton.Text = "Mostrar";
            MostrarButton.UseVisualStyleBackColor = true;
            MostrarButton.Click += MostrarButton_Click;
            // 
            // PersonasDataGridView
            // 
            PersonasDataGridView.AutoGenerateColumns = false;
            PersonasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonasDataGridView.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, estaturaDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            PersonasDataGridView.DataSource = PersonaBindingSource;
            PersonasDataGridView.Location = new Point(0, 432);
            PersonasDataGridView.Name = "PersonasDataGridView";
            PersonasDataGridView.RowHeadersWidth = 62;
            PersonasDataGridView.RowTemplate.Height = 33;
            PersonasDataGridView.Size = new Size(1331, 283);
            PersonasDataGridView.TabIndex = 13;
            // 
            // PersonaBindingSource
            // 
            PersonaBindingSource.DataSource = typeof(Entidades_Clases.Persona);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // estaturaDataGridViewTextBoxColumn
            // 
            estaturaDataGridViewTextBoxColumn.DataPropertyName = "Estatura";
            estaturaDataGridViewTextBoxColumn.HeaderText = "Estatura";
            estaturaDataGridViewTextBoxColumn.MinimumWidth = 8;
            estaturaDataGridViewTextBoxColumn.Name = "estaturaDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.MinimumWidth = 8;
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.MinimumWidth = 8;
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 715);
            Controls.Add(PersonasDataGridView);
            Controls.Add(MostrarButton);
            Controls.Add(CrearButton);
            Controls.Add(NacimientoDateTimePicker);
            Controls.Add(GeneroTextBox);
            Controls.Add(EdadTextBox);
            Controls.Add(EstaturaTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NombreTextBox;
        private TextBox EstaturaTextBox;
        private TextBox EdadTextBox;
        private TextBox GeneroTextBox;
        private DateTimePicker NacimientoDateTimePicker;
        private Button CrearButton;
        private Button MostrarButton;
        private DataGridView PersonasDataGridView;
        private BindingSource PersonaBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
    }
}