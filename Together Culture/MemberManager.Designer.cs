namespace Together_Culture
{
    partial class MemberManager
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(480, 151);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Member";
            textBox1.Size = new Size(148, 29);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += Enter_Down_mem;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(textBox4, 4, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 2, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 1, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 4);
            tableLayoutPanel1.Controls.Add(button3, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Dock = DockStyle.Bottom;
            textBox4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(634, 151);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search Tag";
            textBox4.Size = new Size(148, 29);
            textBox4.TabIndex = 8;
            textBox4.KeyDown += Enter_down_tag;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(326, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(456, 246);
            dataGridView1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 186);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(148, 78);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Assign Tag ";
            textBox2.Size = new Size(148, 29);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(3, 38);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "To Member";
            textBox3.Size = new Size(148, 29);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(172, 186);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += on_go_click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(18, 354);
            button2.Name = "button2";
            button2.Size = new Size(148, 78);
            button2.TabIndex = 6;
            button2.Text = "New Member";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new_mem_click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(172, 354);
            button3.Name = "button3";
            button3.Size = new Size(148, 78);
            button3.TabIndex = 7;
            button3.Text = "New Tag";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new_tag_clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(148, 84);
            label1.TabIndex = 9;
            label1.Text = "Members";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(480, 18);
            button4.Name = "button4";
            button4.Size = new Size(148, 78);
            button4.TabIndex = 10;
            button4.Text = "Show All Members";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(634, 18);
            button5.Name = "button5";
            button5.Size = new Size(148, 78);
            button5.TabIndex = 11;
            button5.Text = "Show All Tags";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // MemberManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MemberManager";
            Text = "MemberManager";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}