namespace Together_Culture
{
    partial class EventManager
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 2, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 2, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 3, 1);
            tableLayoutPanel1.Controls.Add(button2, 4, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker3, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
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
            tableLayoutPanel1.TabIndex = 2;
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
            textBox2.PlaceholderText = "Event Name";
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
            textBox3.PlaceholderText = "Event Info";
            textBox3.Size = new Size(148, 29);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(18, 270);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Event Description";
            textBox1.Size = new Size(148, 78);
            textBox1.TabIndex = 4;
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
            label1.Text = "Events";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            button5.Text = "Show All Events";
            button5.UseVisualStyleBackColor = false;
            button5.Click += show_all;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Bottom;
            dateTimePicker1.Location = new Point(326, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Bottom;
            dateTimePicker2.Location = new Point(480, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(148, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Dock = DockStyle.Bottom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(634, 151);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 14;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += filter_clicked;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(18, 354);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(148, 27);
            dateTimePicker3.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(172, 354);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += go_clicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 133);
            label2.Name = "label2";
            label2.Size = new Size(148, 50);
            label2.TabIndex = 16;
            label2.Text = "Add New Event";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "EventManager";
            Text = "EventManager";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker3;
        private Label label2;
    }
}