namespace 新冠病毒预测
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataShow = new System.Windows.Forms.DataGridView();
            this.currentDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PredictChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.操作板 = new System.Windows.Forms.GroupBox();
            this.showModellabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.predictButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.showModelrichTextBox = new System.Windows.Forms.RichTextBox();
            this.dateSelectText = new System.Windows.Forms.TextBox();
            this.modelnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numPeopleText = new System.Windows.Forms.TextBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.predictTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateSelectBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SEIRdatetext = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NowDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.nowtimer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDataChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictChart)).BeginInit();
            this.操作板.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelnumericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataShow);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新冠病毒实时数据显示";
            // 
            // dataShow
            // 
            this.dataShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataShow.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataShow.Location = new System.Drawing.Point(3, 29);
            this.dataShow.Name = "dataShow";
            this.dataShow.ReadOnly = true;
            this.dataShow.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataShow.RowTemplate.Height = 23;
            this.dataShow.Size = new System.Drawing.Size(391, 224);
            this.dataShow.TabIndex = 0;
            // 
            // currentDataChart
            // 
            this.currentDataChart.BackColor = System.Drawing.Color.LightYellow;
            this.currentDataChart.BorderlineWidth = 2;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("华文宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.MaximumAutoSize = 80F;
            chartArea1.BackColor = System.Drawing.Color.LightYellow;
            chartArea1.Name = "ChartArea1";
            this.currentDataChart.ChartAreas.Add(chartArea1);
            this.currentDataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.currentDataChart.Legends.Add(legend1);
            this.currentDataChart.Location = new System.Drawing.Point(3, 29);
            this.currentDataChart.Name = "currentDataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.currentDataChart.Series.Add(series1);
            this.currentDataChart.Size = new System.Drawing.Size(509, 220);
            this.currentDataChart.TabIndex = 1;
            this.currentDataChart.Text = "趋势图";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PredictChart);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(17, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 103, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新冠病毒预测";
            // 
            // PredictChart
            // 
            this.PredictChart.BackColor = System.Drawing.Color.LemonChiffon;
            chartArea2.BackColor = System.Drawing.Color.LemonChiffon;
            chartArea2.Name = "ChartArea1";
            this.PredictChart.ChartAreas.Add(chartArea2);
            this.PredictChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.PredictChart.Legends.Add(legend2);
            this.PredictChart.Location = new System.Drawing.Point(3, 29);
            this.PredictChart.Name = "PredictChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PredictChart.Series.Add(series2);
            this.PredictChart.Size = new System.Drawing.Size(427, 273);
            this.PredictChart.TabIndex = 0;
            this.PredictChart.Text = "chart2";
            // 
            // 操作板
            // 
            this.操作板.Controls.Add(this.showModellabel);
            this.操作板.Controls.Add(this.tabControl1);
            this.操作板.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.操作板.Location = new System.Drawing.Point(464, 273);
            this.操作板.Name = "操作板";
            this.操作板.Size = new System.Drawing.Size(471, 305);
            this.操作板.TabIndex = 3;
            this.操作板.TabStop = false;
            this.操作板.Text = "操作板";
            // 
            // showModellabel
            // 
            this.showModellabel.AutoSize = true;
            this.showModellabel.BackColor = System.Drawing.Color.GhostWhite;
            this.showModellabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showModellabel.Location = new System.Drawing.Point(166, 274);
            this.showModellabel.Name = "showModellabel";
            this.showModellabel.Size = new System.Drawing.Size(0, 21);
            this.showModellabel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(3, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 273);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.predictButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.showModelrichTextBox);
            this.tabPage1.Controls.Add(this.dateSelectText);
            this.tabPage1.Controls.Add(this.modelnumericUpDown1);
            this.tabPage1.Controls.Add(this.numPeopleText);
            this.tabPage1.Controls.Add(this.provinceComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.predictTypeComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.typeComboBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.showButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dateSelectBtn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "多项式拟合模型";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.LemonChiffon;
            this.monthCalendar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthCalendar1.Location = new System.Drawing.Point(318, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(307, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "人";
            // 
            // predictButton
            // 
            this.predictButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.predictButton.Location = new System.Drawing.Point(399, 97);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(55, 28);
            this.predictButton.TabIndex = 5;
            this.predictButton.Text = "预测";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "实时数据显示类型：";
            // 
            // showModelrichTextBox
            // 
            this.showModelrichTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.showModelrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showModelrichTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showModelrichTextBox.Location = new System.Drawing.Point(179, 251);
            this.showModelrichTextBox.Name = "showModelrichTextBox";
            this.showModelrichTextBox.Size = new System.Drawing.Size(302, 25);
            this.showModelrichTextBox.TabIndex = 9;
            this.showModelrichTextBox.Text = "";
            // 
            // dateSelectText
            // 
            this.dateSelectText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateSelectText.Location = new System.Drawing.Point(179, 96);
            this.dateSelectText.Name = "dateSelectText";
            this.dateSelectText.Size = new System.Drawing.Size(121, 29);
            this.dateSelectText.TabIndex = 2;
            // 
            // modelnumericUpDown1
            // 
            this.modelnumericUpDown1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modelnumericUpDown1.Location = new System.Drawing.Point(180, 136);
            this.modelnumericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.modelnumericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.modelnumericUpDown1.Name = "modelnumericUpDown1";
            this.modelnumericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.modelnumericUpDown1.TabIndex = 8;
            this.modelnumericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.modelnumericUpDown1.ValueChanged += new System.EventHandler(this.modelnumericUpDown1_ValueChanged);
            // 
            // numPeopleText
            // 
            this.numPeopleText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPeopleText.Location = new System.Drawing.Point(180, 214);
            this.numPeopleText.Name = "numPeopleText";
            this.numPeopleText.Size = new System.Drawing.Size(121, 29);
            this.numPeopleText.TabIndex = 2;
            this.numPeopleText.Text = "0";
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(179, 55);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(121, 29);
            this.provinceComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "预测日期：";
            // 
            // predictTypeComboBox
            // 
            this.predictTypeComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.predictTypeComboBox.FormattingEnabled = true;
            this.predictTypeComboBox.Location = new System.Drawing.Point(179, 177);
            this.predictTypeComboBox.Name = "predictTypeComboBox";
            this.predictTypeComboBox.Size = new System.Drawing.Size(121, 29);
            this.predictTypeComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(83, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "预测人数：";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(179, 11);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 29);
            this.typeComboBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(83, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "模型显示：";
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showButton.Location = new System.Drawing.Point(309, 11);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(61, 28);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "显示";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(52, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "预测类型显示：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(84, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "预测模型：";
            // 
            // dateSelectBtn
            // 
            this.dateSelectBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateSelectBtn.Location = new System.Drawing.Point(306, 97);
            this.dateSelectBtn.Name = "dateSelectBtn";
            this.dateSelectBtn.Size = new System.Drawing.Size(87, 28);
            this.dateSelectBtn.TabIndex = 5;
            this.dateSelectBtn.Text = "选择日期";
            this.dateSelectBtn.UseVisualStyleBackColor = true;
            this.dateSelectBtn.Click += new System.EventHandler(this.dateSelectBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(305, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "阶多项式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(83, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "显示省份：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.SEIRdatetext);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SEIR传染病模型";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(351, 198);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(351, 163);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 1;
            // 
            // SEIRdatetext
            // 
            this.SEIRdatetext.Location = new System.Drawing.Point(115, 198);
            this.SEIRdatetext.Name = "SEIRdatetext";
            this.SEIRdatetext.Size = new System.Drawing.Size(100, 26);
            this.SEIRdatetext.TabIndex = 1;
            this.SEIRdatetext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SEIRdatetext_MouseDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(351, 126);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(351, 94);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 26);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(351, 59);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(351, 26);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "康复概率：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "潜伏者传染率：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "潜伏者转化率：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "传染概率：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "感染者接触人数：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(229, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "预测感染人数：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "预测日期：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "康复者：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "传染者：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "易感染者：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "潜伏者：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "人口总数：";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(130, 48);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 2;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NowDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NowDateTime
            // 
            this.NowDateTime.Name = "NowDateTime";
            this.NowDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NowDateTime.Size = new System.Drawing.Size(932, 17);
            this.NowDateTime.Spring = true;
            this.NowDateTime.Text = "2020/2/21 19:40";
            this.NowDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nowtimer1
            // 
            this.nowtimer1.Enabled = true;
            this.nowtimer1.Interval = 1000;
            this.nowtimer1.Tick += new System.EventHandler(this.nowtimer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.currentDataChart);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(420, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 252);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "实时数据趋势图";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(947, 603);
            this.Controls.Add(this.操作板);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "新冠病毒预测";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDataChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredictChart)).EndInit();
            this.操作板.ResumeLayout(false);
            this.操作板.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelnumericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart currentDataChart;
        private System.Windows.Forms.DataGridView dataShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox 操作板;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button dateSelectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateSelectText;
        private System.Windows.Forms.DataVisualization.Charting.Chart PredictChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NowDateTime;
        private System.Windows.Forms.Timer nowtimer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown modelnumericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numPeopleText;
        private System.Windows.Forms.ComboBox predictTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label showModellabel;
        private System.Windows.Forms.RichTextBox showModelrichTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SEIRdatetext;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}

