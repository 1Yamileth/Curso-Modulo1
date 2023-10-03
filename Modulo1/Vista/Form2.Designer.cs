namespace Vista
{
    partial class Form2
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
            SincronoButton = new Button();
            AsincronoButton = new Button();
            SumanButton = new Button();
            SuspendLayout();
            // 
            // SincronoButton
            // 
            SincronoButton.Location = new Point(138, 43);
            SincronoButton.Name = "SincronoButton";
            SincronoButton.Size = new Size(150, 104);
            SincronoButton.TabIndex = 0;
            SincronoButton.Text = "Hornear pollo";
            SincronoButton.UseVisualStyleBackColor = true;
            SincronoButton.Click += SincronoButton_Click;
            // 
            // AsincronoButton
            // 
            AsincronoButton.Location = new Point(410, 43);
            AsincronoButton.Name = "AsincronoButton";
            AsincronoButton.Size = new Size(150, 104);
            AsincronoButton.TabIndex = 1;
            AsincronoButton.Text = "Hornear Pollo";
            AsincronoButton.UseVisualStyleBackColor = true;
            AsincronoButton.Click += AsincronoButton_Click;
            // 
            // SumanButton
            // 
            SumanButton.Location = new Point(234, 246);
            SumanButton.Name = "SumanButton";
            SumanButton.Size = new Size(150, 104);
            SumanButton.TabIndex = 2;
            SumanButton.Text = "Sumar";
            SumanButton.UseVisualStyleBackColor = true;
            SumanButton.Click += SumanButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 526);
            Controls.Add(SumanButton);
            Controls.Add(AsincronoButton);
            Controls.Add(SincronoButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button SincronoButton;
        private Button AsincronoButton;
        private Button SumanButton;
    }
}