namespace Together_Culture
{
    partial class AddTag
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Add New Tag Name";
            textBox1.Size = new Size(265, 29);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(35, 57);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += fo_clicked;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(135, 57);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancel_clicked;
            // 
            // AddTag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(338, 109);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddTag";
            Text = "AddTag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}