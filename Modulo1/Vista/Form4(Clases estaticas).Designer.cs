namespace Vista
{
    partial class Form4_Clases_estaticas_
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
            button1 = new Button();
            Val1txt = new TextBox();
            Val2Txt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(364, 192);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Val1txt
            // 
            Val1txt.Location = new Point(218, 63);
            Val1txt.Name = "Val1txt";
            Val1txt.Size = new Size(150, 31);
            Val1txt.TabIndex = 1;
            // 
            // Val2Txt
            // 
            Val2Txt.Location = new Point(473, 63);
            Val2Txt.Name = "Val2Txt";
            Val2Txt.Size = new Size(150, 31);
            Val2Txt.TabIndex = 2;
            // 
            // Form4_Clases_estaticas_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Val2Txt);
            Controls.Add(Val1txt);
            Controls.Add(button1);
            Name = "Form4_Clases_estaticas_";
            Text = "Form4_Clases_estaticas_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Val1txt;
        private TextBox Val2Txt;
    }
}