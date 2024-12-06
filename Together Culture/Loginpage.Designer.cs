namespace Together_Culture
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            linkLabel2 = new LinkLabel();
            errorlabel = new Label();
            label1 = new Label();
            emaillabel = new Label();
            emailbox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            passbox = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1180, 730);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(590, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 730);
            panel1.TabIndex = 0;
            
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(errorlabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(emaillabel);
            panel2.Controls.Add(emailbox);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(passbox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 730);
            panel2.TabIndex = 3;
            
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.Font = new Font("Verdana", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(242, 243, 244);
            linkLabel2.Location = new Point(148, 567);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(296, 37);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login as a visitor→";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += visitorLink_clicked;
            // 
            // errorlabel
            // 
            errorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorlabel.ForeColor = Color.Yellow;
            errorlabel.Location = new Point(148, 496);
            errorlabel.Name = "errorlabel";
            errorlabel.Size = new Size(286, 51);
            errorlabel.TabIndex = 6;
            errorlabel.Text = "Error Text";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 243, 244);
            label1.Location = new Point(148, 340);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 5;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emaillabel
            // 
            emaillabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emaillabel.AutoSize = true;
            emaillabel.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emaillabel.ForeColor = Color.FromArgb(242, 243, 244);
            emaillabel.Location = new Point(148, 268);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(285, 22);
            emaillabel.TabIndex = 4;
            emaillabel.Text = "Email ID or Membership ID";
            emaillabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailbox
            // 
            emailbox.AllowDrop = true;
            emailbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailbox.BackColor = Color.FromArgb(252, 218, 225);
            emailbox.BorderStyle = BorderStyle.None;
            emailbox.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.ForeColor = Color.FromArgb(23, 23, 23);
            emailbox.Location = new Point(148, 293);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "xyz@mail.com OR XXXXXXX";
            emailbox.Size = new Size(296, 22);
            emailbox.TabIndex = 0;
            emailbox.WordWrap = false;
            emailbox.KeyPress += enter_pressed_email;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(197, 18, 54);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(242, 243, 244);
            button1.Location = new Point(148, 440);
            button1.Name = "button1";
            button1.Size = new Size(293, 53);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(242, 243, 244);
            linkLabel1.Location = new Point(148, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // passbox
            // 
            passbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passbox.BackColor = Color.FromArgb(252, 218, 225);
            passbox.BorderStyle = BorderStyle.None;
            passbox.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.ForeColor = Color.FromArgb(23, 23, 23);
            passbox.Location = new Point(148, 365);
            passbox.Name = "passbox";
            passbox.PlaceholderText = "Password";
            passbox.Size = new Size(293, 22);
            passbox.TabIndex = 1;
            passbox.UseSystemPasswordChar = true;
            passbox.KeyPress += enter_pressed;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 724);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 12F);
            button2.ForeColor = Color.FromArgb(23, 23, 23);
            button2.Location = new Point(3, 684);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += exit_clicked;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1200, 750);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loginpage";
            Padding = new Padding(10);
            Text = "Loginpage";
            Load += Loginpage_Load;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox emailbox;
        private LinkLabel linkLabel1;
        private TextBox passbox;
        private Label emaillabel;
        private Label label1;
        private Label errorlabel;
        private LinkLabel linkLabel2;
        private Button button2;
        private Panel panel3;
    }
}