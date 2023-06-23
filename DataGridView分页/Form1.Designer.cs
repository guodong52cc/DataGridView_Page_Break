namespace DataGridView分页
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            buttonReadSql = new Button();
            listBox1 = new ListBox();
            buttonRefresh = new Button();
            buttonRead = new Button();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPrev = new Button();
            btnNext = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(933, 465);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(126, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 465);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 193);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 4;
            label1.Text = "未查询到相关数据";
            // 
            // buttonReadSql
            // 
            buttonReadSql.Location = new Point(12, 21);
            buttonReadSql.Name = "buttonReadSql";
            buttonReadSql.Size = new Size(94, 29);
            buttonReadSql.TabIndex = 2;
            buttonReadSql.Text = "读取文件";
            buttonReadSql.UseVisualStyleBackColor = true;
            buttonReadSql.Click += buttonReadSql_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(94, 264);
            listBox1.TabIndex = 3;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(12, 326);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "刷新表";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(12, 361);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(94, 29);
            buttonRead.TabIndex = 5;
            buttonRead.Text = "读取表";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 16);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "当前表：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 16);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "未选择";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(231, 0);
            flowLayoutPanel1.Margin = new Padding(8, 0, 8, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(8);
            flowLayoutPanel1.Size = new Size(16, 34);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnPrev
            // 
            btnPrev.AutoSize = true;
            btnPrev.Location = new Point(128, 3);
            btnPrev.Margin = new Padding(8, 3, 8, 0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(87, 30);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "上一页";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += BtnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.AutoSize = true;
            btnNext.Location = new Point(263, 3);
            btnNext.Margin = new Padding(8, 3, 8, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(82, 30);
            btnNext.TabIndex = 8;
            btnNext.Text = "下一页";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(comboBox2, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 5, 0);
            tableLayoutPanel1.Controls.Add(btnNext, 4, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 3, 0);
            tableLayoutPanel1.Controls.Add(btnPrev, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(540, 514);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(519, 34);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(416, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 28);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(356, 3);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 10;
            label5.Text = "跳转：";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 3);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 9;
            label4.Text = "每页：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.ItemHeight = 20;
            comboBox1.Items.AddRange(new object[] { "5", "10", "20", "30", "50" });
            comboBox1.Location = new Point(63, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(54, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "5";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 560);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonRead);
            Controls.Add(buttonRefresh);
            Controls.Add(listBox1);
            Controls.Add(buttonReadSql);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button buttonReadSql;
        private ListBox listBox1;
        private Button buttonRefresh;
        private Button buttonRead;
        private Label label2;
        private Label label3;
        private Label labelCurrent;
        private LinkLabel linkLabelDown;
        private LinkLabel linkLabelUp;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPrev;
        private Button btnNext;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
    }
}