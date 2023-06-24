using Microsoft.Data.Sqlite;
using System.Data;

namespace DataGridView分页
{
    public partial class Form1 : Form
    {
        private string? connectionString; // 数据库连接字符串
        private int totalRows; // 总行数
        private int pageSize = 5; // 每页行数
        private int totalPages; // 总页数
        private int currentPage = 1; // 当前页数
        private List<object[]>? chartData; // 数据集合

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("未选择表");
                comboBox2.Text = "未选择表";
            }

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
        }

        // 读取Sqlite文件
        private void buttonReadSql_Click(object sender, EventArgs e)
        {
            // 弹出对话框，读取Microsoft.EntityFrameworkCore.Sqlite文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "db文件|*.db";
            //openFileDialog.InitialDirectory = "";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "请选择db文件";

            // 将结果读取到dbPath中
            string? dbPath = openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;

            // 如果没有选择文件，弹出提示
            if (string.IsNullOrWhiteSpace(dbPath))
            {
                MessageBox.Show("请选择db文件");
                return;
            }

            // 读取Microsoft.EntityFrameworkCore.Sqlite文件
            connectionString = $"Data Source={dbPath}";

            // 触发buttonRefresh_Click事件
            buttonRefresh_Click(sender, e);
        }

        // 刷新表名
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                // 打开连接
                conn.Open();

                // 判断是否打开成功
                if (conn.State != ConnectionState.Open)
                {
                    // 打开失败，弹出提示
                    MessageBox.Show("打开失败");
                    return;
                }

                // 打开成功，执行查询
                string sql = "SELECT name FROM sqlite_master WHERE type='table'";

                using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                {
                    // 执行查询
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        // 清空listBox
                        listBox1.Items.Clear();

                        // 读取表名并添加到listBox中
                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0);
                            listBox1.Items.Add(tableName);
                        }
                    }
                }
            }
        }

        // 读取数据
        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择表");
                return;
            }

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                // 打开连接
                conn.Open();

                // 判断是否打开成功
                if (conn.State != ConnectionState.Open)
                {
                    // 打开失败，弹出提示
                    MessageBox.Show("打开失败");
                    return;
                }

                // 显示表名
                label1.Visible = false;
                label3.Text = listBox1.SelectedItem.ToString();

                // 获取表总行数
                string sqlCount = $"SELECT COUNT(*) FROM {listBox1.SelectedItem}";
                using (SqliteCommand cmd = new SqliteCommand(sqlCount, conn))
                {
                    totalRows = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // 计算总页数
                totalPages = (int)Math.Ceiling((double)totalRows / pageSize);

                // 如果跳转页数为空，将当前页重置为 1
                if (comboBox2.SelectedItem == null)
                {
                    currentPage = 1; // 将当前页设置为 1
                }

                // 打开成功，执行查询
                string sql = $"SELECT * FROM {listBox1.SelectedItem}";
                using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                {
                    // 执行查询
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        // 清空dataGridView
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        // 创建列
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }

                        chartData = new List<object[]>();

                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];
                            reader.GetValues(rowData);
                            chartData.Add(rowData);
                        }
                    }
                }
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                btnNext.Enabled = true;
                btnPrev.Enabled = true;

                LoadDataForPage(currentPage);
                UpdatePageControls();
                UpdateJump();
            }
        }

        // 双击表名，触发buttonRead_Click事件
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            buttonRead_Click(sender, e);
        }

        private void UpdatePageControls()
        {
            flowLayoutPanel1.Controls.Clear(); // 清空之前的分页控件

            btnPrev.Enabled = (currentPage > 1);
            btnNext.Enabled = (currentPage < totalPages);

            // 添加页码标签
            int startPage = Math.Max(currentPage - 2, 1);
            int endPage = Math.Min(currentPage + 2, totalPages);

            // 添加第一页标签
            if (startPage > 1)
            {
                Label lblFirst = new Label();
                lblFirst.Text = "1";
                lblFirst.Click += LblPage_Click;
                lblFirst.AutoSize = true;

                if (currentPage == 1)
                {
                    lblFirst.Font = new Font(lblFirst.Font, FontStyle.Bold | FontStyle.Underline);
                }

                flowLayoutPanel1.Controls.Add(lblFirst);
            }

            // 添加省略号
            if (startPage > 2)
            {
                Label lblEllipsis1 = new Label();
                lblEllipsis1.Text = "...";
                lblEllipsis1.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lblEllipsis1);
            }

            // 添加页码
            for (int i = startPage; i <= endPage; i++)
            {
                Label lblPage = new Label();
                lblPage.Text = i.ToString();
                lblPage.Click += LblPage_Click;
                lblPage.AutoSize = true;

                if (i == currentPage)
                {
                    lblPage.Font = new Font(lblPage.Font, FontStyle.Bold | FontStyle.Underline);
                }

                flowLayoutPanel1.Controls.Add(lblPage);
            }

            // 添加省略号
            if (endPage < totalPages - 1)
            {
                Label lblEllipsis2 = new Label();
                lblEllipsis2.Text = "...";
                lblEllipsis2.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lblEllipsis2);
            }

            // 添加最后一页标签
            if (endPage < totalPages)
            {
                Label lblLast = new Label();
                lblLast.Text = totalPages.ToString();
                lblLast.Click += LblPage_Click;
                lblLast.AutoSize = true;

                if (currentPage == totalPages)
                {
                    lblLast.Font = new Font(lblLast.Font, FontStyle.Bold | FontStyle.Underline);
                }
                flowLayoutPanel1.Controls.Add(lblLast);

            }
        }


        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataForPage(currentPage);
                UpdatePageControls();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataForPage(currentPage);
                UpdatePageControls();
            }
        }

        private void LblPage_Click(object sender, EventArgs e)
        {
            Label lblPage = (Label)sender;
            int page = int.Parse(lblPage.Text);

            if (currentPage != page)
            {
                currentPage = page;
                LoadDataForPage(currentPage);
                UpdatePageControls();
            }
        }


        private void LoadDataForPage(int page)
        {
            // 根据当前页加载数据
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize - 1, totalRows - 1);

            dataGridView1.Rows.Clear(); // 清空 dataGridView1 中的数据

            for (int i = startIndex; i <= endIndex; i++)
            {
                object[] rowData = chartData[i];
                dataGridView1.Rows.Add(rowData);
            }
        }

        private SqliteDataReader? ExecuteDataReader(string sql)
        {
            SqliteDataReader? reader = null;
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            reader = cmd.ExecuteReader();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行查询时出错: " + ex.Message);
            }
            return reader;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(comboBox1.SelectedItem.ToString());
            if (listBox1.SelectedItem != null)
            {
                buttonRead_Click(sender, e);
            }
        }

        private void UpdateJump()
        {
            comboBox2.Items.Clear();
            comboBox2.Text = string.Empty;
            if (listBox1.SelectedItem != null)
            {
                for (int i = 0; i < totalPages; i++)
                {
                    comboBox2.Items.Add(i + 1);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                currentPage = int.Parse(comboBox2.SelectedItem.ToString());
                if (listBox1.SelectedItem != null)
                {
                    buttonRead_Click(sender, e);
                }
            }
        }
    }
}
