namespace Together_Culture
{
    partial class Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(818, 497);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(547, 333);
            button9.Name = "button9";
            button9.Size = new Size(268, 161);
            button9.TabIndex = 8;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += exit_clicked;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(275, 333);
            button8.Name = "button8";
            button8.Size = new Size(266, 161);
            button8.TabIndex = 7;
            button8.Text = "Ver Info.";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ver_info_click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 333);
            button7.Name = "button7";
            button7.Size = new Size(266, 161);
            button7.TabIndex = 6;
            button7.Text = "New Announcement";
            button7.UseVisualStyleBackColor = true;
            button7.Click += announce;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Crimson;
            button5.Location = new Point(275, 168);
            button5.Name = "button5";
            button5.Size = new Size(266, 159);
            button5.TabIndex = 4;
            button5.Text = "Together Culture";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(547, 3);
            button3.Name = "button3";
            button3.Size = new Size(268, 159);
            button3.TabIndex = 2;
            button3.Text = "Manage Shop";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(275, 3);
            button2.Name = "button2";
            button2.Size = new Size(266, 159);
            button2.TabIndex = 1;
            button2.Text = "Manage Events";
            button2.UseVisualStyleBackColor = true;
            button2.Click += manage_events_click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(266, 159);
            button1.TabIndex = 0;
            button1.Text = "Manage Members";
            button1.UseVisualStyleBackColor = true;
            button1.Click += mem_click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(tableLayoutPanel1);
            Name = "Admin";
            Size = new Size(818, 497);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
