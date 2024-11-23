namespace Together_Culture
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            tableLayoutPanel1 = new TableLayoutPanel();
            title = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            navbar = new Panel();
            navlist = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            navbar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(navbar, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1200, 750);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Dock = DockStyle.Fill;
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(253, 253, 253);
            title.Location = new Point(8, 5);
            title.Name = "title";
            title.Size = new Size(172, 111);
            title.TabIndex = 0;
            title.Text = "Together\r\nCulture.";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(186, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 105);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F);
            button1.ForeColor = Color.FromArgb(249, 249, 249);
            button1.Location = new Point(891, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += quit_clicked;
            // 
            // panel2
            // 
            panel2.AccessibleName = "Searchbox";
            panel2.AccessibleRole = AccessibleRole.None;
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(253, 253, 253);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(38, 30);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(227, 43);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(253, 253, 253);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(42, 7);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(174, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // navbar
            // 
            navbar.BackColor = Color.Transparent;
            navbar.Controls.Add(navlist);
            navbar.Dock = DockStyle.Fill;
            navbar.Location = new Point(8, 119);
            navbar.Name = "navbar";
            navbar.Size = new Size(172, 623);
            navbar.TabIndex = 2;
            // 
            // navlist
            // 
            navlist.BackColor = Color.FromArgb(23, 23, 23);
            navlist.BorderStyle = BorderStyle.None;
            navlist.Dock = DockStyle.Top;
            navlist.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navlist.ForeColor = Color.FromArgb(253, 253, 253);
            navlist.FormattingEnabled = true;
            navlist.ItemHeight = 25;
            navlist.Items.AddRange(new object[] { "Home", "Events", "Membership", "About", "Admin" });
            navlist.Location = new Point(0, 0);
            navlist.Name = "navlist";
            navlist.Size = new Size(172, 600);
            navlist.TabIndex = 0;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(1200, 750);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            navbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label title;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel navbar;
        private ListBox navlist;
        private Button button1;
    }
}