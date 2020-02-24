using MathNet.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 新冠病毒预测
{
    public partial class Form1 : Form
    {
        const string dataUrl = "https://view.inews.qq.com/g2/getOnsInfo?name=disease_h5";
        const string dataUr2 = "https://jackiezheng.github.io/2019-nCoV/Json/data.json?1581585448000";

        bool url2Flag = false;
        DataTable newData = new DataTable();
        DataTable predictnewData = new DataTable();
        List<DataRaw> chinaDayList = new List<DataRaw>();
        float width, height;//X表示窗体的宽度，Y表示窗体的高度
        float rateX, rateY;

        public Form1()
        {
            InitializeComponent();
            //this.SizeChanged += this.Form1_Resize;  //窗口自适应代码
            DataDownload();
            TypeComboInfomation();
            ChartData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            setTag(this);
        }

        /// <summary>
        /// 调整控件大小时
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            rateX = this.Width / width;//获取当前宽度与初始宽度的比例
            rateY = this.Height / height;//获取当前高度与初始高度的比例
            setControls(rateX, rateY, this);
            width = this.Width;
            height = this.Height;
        }

         /// <summary>
         /// 获取控件的width、height、left、top、字体大小的值
         /// </summary>
         /// <param name="cons">要获取信息的控件</param>
         private void setTag(System.Windows.Forms.Control cons)
         {//遍历窗体中的控件
             foreach (System.Windows.Forms.Control con in cons.Controls)
             {
                 con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
             }
         }
         /// <summary>
         /// 根据窗体大小调整控件大小
         /// </summary>
         private void setControls(float newX, float newY, System.Windows.Forms.Control cons)
         {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值
                if (this.WindowState == FormWindowState.Maximized)
                {
                    con.Width = (int)(Convert.ToSingle(mytag[0]) * newX);//根据窗体缩放比例确定控件的值
                    con.Height = (int)(Convert.ToSingle(mytag[1]) * newY);//根据窗体缩放比例确定控件的值)
                    con.Left = (int)(Convert.ToSingle(mytag[2]) * newX);//根据窗体缩放比例确定控件的值
                    con.Top = (int)(Convert.ToSingle(mytag[3]) * newY);//根据窗体缩放比例确定控件的值
                    //Single currentSize = Convert.ToSingle(mytag[4]) * newY;//根据窗体缩放比例确定控件的值
                    con.Font = new Font(con.Font.Name, 12, con.Font.Unit);//字体大小
                    if (con.Name.Equals("操作板"))
                    {
                        foreach (System.Windows.Forms.Control subCon in con.Controls)
                        {
                            subCon.Width = (int)(Convert.ToSingle(subCon.Width) * newX);
                            subCon.Height = (int)(Convert.ToSingle(subCon.Height) * newY);
                            subCon.Left = (int)(Convert.ToSingle(subCon.Left) * newX);
                            subCon.Top = (int)(Convert.ToSingle(subCon.Top) * newY);
                        }
                    }
                }
                if (this.WindowState == FormWindowState.Normal)
                {
                    con.Width = (int)(Convert.ToSingle(mytag[0]));
                    con.Height = (int)(Convert.ToSingle(mytag[1]));
                    con.Left = (int)(Convert.ToSingle(mytag[2]));
                    con.Top = (int)(Convert.ToSingle(mytag[3]));
                    con.Font = new Font(con.Font.Name, 12, con.Font.Unit);//字体大小
                    if (con.Name.Equals("操作板"))
                    {
                        foreach (System.Windows.Forms.Control subCon in con.Controls)
                        {
                            subCon.Width = (int)(Convert.ToSingle(subCon.Width) * newX);
                            subCon.Height = (int)(Convert.ToSingle(subCon.Height) * newY);
                            subCon.Left = (int)(Convert.ToSingle(subCon.Left) * newX);
                            subCon.Top = (int)(Convert.ToSingle(subCon.Top) * newY);
                        }
                    }
                }
            }
        }
        private void TypeComboInfomation()
        {
            this.typeComboBox.Items.Add("全部");
            this.typeComboBox.Items.Add("累计确诊人数");
            this.typeComboBox.Items.Add("确诊人数");
            this.typeComboBox.Items.Add("疑似人数");
            this.typeComboBox.Items.Add("治愈人数");
            this.typeComboBox.Items.Add("死亡人数");
            this.typeComboBox.Items.Add("新增确诊人数");
            this.typeComboBox.Items.Add("新增疑似死亡人数");
            this.typeComboBox.SelectedIndex = 0;
            this.predictTypeComboBox.Items.Add("预测累计确诊人数");
            this.predictTypeComboBox.Items.Add("预测确诊人数");
            this.predictTypeComboBox.Items.Add("预测疑似人数");
            this.predictTypeComboBox.Items.Add("预测治愈人数");
            this.predictTypeComboBox.Items.Add("预测死亡人数");
            this.predictTypeComboBox.Items.Add("预测新增确诊人数");
            this.predictTypeComboBox.Items.Add("预测新增疑似人数");
            this.predictTypeComboBox.SelectedIndex = 0;
        }

        private void nowtimer1_Tick(object sender, EventArgs e)
        {
            NowDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        private void DataDownload()
        {
            #region 列名
            newData.Columns.Add("日期");
            newData.Columns.Add("累计确诊人数");
            newData.Columns.Add("确诊人数");
            newData.Columns.Add("疑似人数");
            newData.Columns.Add("治愈人数");
            newData.Columns.Add("死亡人数");
            newData.Columns.Add("新增确诊人数");
            newData.Columns.Add("新增疑似人数");
            #endregion

            #region 下载数据
            WebClient webClient = new WebClient();
            byte[] _str1 = webClient.DownloadData(dataUrl);
            string str1 = UTF8Encoding.UTF8.GetString(_str1);
            JObject json1 = JsonConvert.DeserializeObject<JObject>(str1);
            JObject json2 = JsonConvert.DeserializeObject<JObject>(json1["data"].ToString());
            chinaDayList = json2["chinaDayList"].ToObject<List<DataRaw>>();
            if (chinaDayList.Count == 0)
            {
                url2Flag = true;
                byte[] _str2 = webClient.DownloadData(dataUr2);
                string str2 = UTF8Encoding.UTF8.GetString(_str2);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                object[] jsonUrl2 = (object[])serializer.DeserializeObject(str2);
                foreach (var item in jsonUrl2)
                {
                    Dictionary<string, object> jsondata = (Dictionary<string, object>)item;
                    DataRaw dd = new DataRaw();
                    dd.x = DateTime.Parse(jsondata["日期"].ToString()).DayOfYear;
                    dd.date = DateTime.Parse(jsondata["日期"].ToString()).ToString("yyyy/MM/dd");
                    dd.sum_confirm = jsondata["累计确诊"].ToString();
                    dd.confirm = jsondata["现有确诊（含重症）"].ToString();
                    dd.suspect = jsondata["现有疑似"].ToString();
                    dd.heal = jsondata["累计治愈"].ToString();
                    dd.dead = jsondata["累计死亡"].ToString();
                    dd.add_confirm = jsondata["新增确诊"].ToString();
                    dd.add_suspect = jsondata["新增疑似"].ToString();
                    chinaDayList.Add(dd);
                }
            }
            #endregion

            #region 读取数据
            foreach (var item in chinaDayList)
            {
                string date;
                DataRow dr = newData.NewRow();
                if (!url2Flag)
                {
                    item.x = DateTime.Parse("2020." + item.date).DayOfYear;
                    date = DateTime.Parse("2020." + item.date).ToString("yyyy/MM/dd");
                }
                else
                {
                    date = item.date;
                }
                // 2020.02.05之前没有计算 现有确诊人数 = 累计确诊人数 - 死亡人数 - 治愈人数 
                if ((date.CompareTo("2020/02/06") < 0))
                {
                    item.confirm = (int.Parse(item.sum_confirm) - int.Parse(item.dead) - int.Parse(item.heal)).ToString();
                }
                object[] drData = { date, int.Parse(item.sum_confirm),
                                        int.Parse(item.confirm),
                                        int.Parse(item.suspect), 
                                        int.Parse(item.heal), 
                                        int.Parse(item.dead), 
                                        int.Parse(item.add_confirm), 
                                        int.Parse(item.add_suspect) };
                dr.ItemArray = drData;
                newData.Rows.Add(dr);
            }
            #endregion
        }


        /// <summary>
        /// 当前数据绘图
        /// </summary>
        private void ChartData()
        {
            #region 绑定数据源
            // 实时数据显示
            DataTable dataTable = newData.Copy();
            dataTable.DefaultView.Sort = "日期 DESC";
            dataShow.DataSource = dataTable;
            this.currentDataChart.Series.Clear();
            this.currentDataChart.Titles.Add("实时数据趋势图");
            this.currentDataChart.DataSource = dataTable;
            // 预测数据显示
            this.PredictChart.Series.Clear();
            this.PredictChart.Titles.Add("预测模型分析图");
            #endregion
        }

        private void PredictData()
        {
            List<DataRaw> predictData = chinaDayList;
            predictData.Sort((a, b) => { return (int)(a.x - b.x); });
            double minValue = predictData[0].x;
            DateTime min_date, max_date;
            if (!url2Flag)
            {
                min_date = DateTime.Parse("2020." + predictData[0].date);
                max_date = DateTime.Parse("2020." + predictData[predictData.Count - 1].date + " 23:59");
            }
            else
            {
                min_date = DateTime.Parse(predictData[0].date);
                max_date = DateTime.Parse(predictData[predictData.Count - 1].date + " 23:59");
            }
            if (DateTime.Now < max_date)
                predictData.RemoveAt(predictData.Count - 1);
            // 更新X,Y值，计算相对差
            foreach (var item in predictData)
            {
                item.x -= minValue;
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测累计确诊人数"))
                {
                    item.y = int.Parse(item.sum_confirm);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测确诊人数"))
                {
                    item.y = int.Parse(item.confirm);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测疑似人数"))
                {
                    item.y = int.Parse(item.suspect);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测治愈人数"))
                {
                    item.y = int.Parse(item.heal);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测死亡人数"))
                {
                    item.y = int.Parse(item.dead);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增确诊人数"))
                {
                    item.y = int.Parse(item.add_confirm);
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增疑似人数"))
                {
                    item.y = int.Parse(item.add_suspect);
                }
            }
            //初始化数组
            double[] xx = new double[predictData.Count];
            double[] yy = new double[predictData.Count];
            for (int i = 0; i < predictData.Count; i++)
            {
                xx[i] = predictData[i].x;
                yy[i] = predictData[i].y;
            }
            // 最小二乘法拟合
            int modelLevel = int.Parse(this.modelnumericUpDown1.Value.ToString());
            double[] parameterFitFunc = Fit.Polynomial(xx, yy, modelLevel);
            string result = $"{parameterFitFunc[0].ToString("0.00")} + {parameterFitFunc[1].ToString("0.00")}*x + {parameterFitFunc[2].ToString("0.00")}*x^2 ";
            for (int i = 3; i < modelLevel; i++)
            {
                result += $"+ {parameterFitFunc[i].ToString("0.00")}" + $"*x^{i}";
            }
            result = result.Replace("+ -", "-");

            // 显示模型
            this.showModelrichTextBox.Text = result;
            this.showModelrichTextBox.ReadOnly = true;

            // 显示预测人数
            DateTime selectDate = this.monthCalendar1.SelectionStart.Date;
            double X = (selectDate - min_date).TotalDays;
            int res = this.PredictPerDays(X, parameterFitFunc, modelLevel);
            this.numPeopleText.Text = res.ToString();

            //添加预测数据
            predictnewData = newData.Copy();
            int count = predictnewData.Rows.Count;
            int differentX = (int)(selectDate - max_date).TotalDays;
            predictnewData.Columns.Add("预测累计确诊人数");
            predictnewData.Columns.Add("预测确诊人数");
            predictnewData.Columns.Add("预测疑似人数");
            predictnewData.Columns.Add("预测治愈人数");
            predictnewData.Columns.Add("预测死亡人数");
            predictnewData.Columns.Add("预测新增确诊人数");
            predictnewData.Columns.Add("预测新增疑似人数");
            for (int i = 0; i < differentX+1; i++)
            {
                DataRow dr = predictnewData.NewRow();
                object[] drData = { max_date.AddDays(i + 1).ToString("yyyy/MM/dd"),
                    predictnewData.Rows[count-1]["累计确诊人数"],predictnewData.Rows[count-1]["确诊人数"],
                    predictnewData.Rows[count-1]["疑似人数"], predictnewData.Rows[count-1]["治愈人数"],
                    predictnewData.Rows[count-1]["死亡人数"], predictnewData.Rows[count-1]["新增确诊人数"], predictnewData.Rows[count-1]["新增疑似人数"] };
                dr.ItemArray = drData;
                predictnewData.Rows.Add(dr);
            }
            for (int i = 0; i < (int)X+1; i++)
            {
                int resX = this.PredictPerDays((double)i, parameterFitFunc, modelLevel);
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测累计确诊人数"))
                {
                    predictnewData.Rows[i]["预测累计确诊人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测确诊人数"))
                {
                    predictnewData.Rows[i]["预测确诊人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测疑似人数"))
                {
                    predictnewData.Rows[i]["预测疑似人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测治愈人数"))
                {
                    predictnewData.Rows[i]["预测治愈人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测死亡人数"))
                {
                    predictnewData.Rows[i]["预测死亡人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增确诊人数"))
                {
                    predictnewData.Rows[i]["预测新增确诊人数"] = resX;
                }
                if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增疑似人数"))
                {
                    predictnewData.Rows[i]["预测新增疑似人数"] = resX;
                }
                this.PredictChart.DataSource = predictnewData;
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测累计确诊人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "累计确诊人数", "预测累计确诊人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测确诊人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "确诊人数", "预测确诊人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测疑似人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "疑似人数", "预测疑似人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测治愈人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "治愈人数", "预测治愈人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测死亡人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "死亡人数", "预测死亡人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增确诊人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "新增确诊人数", "预测新增确诊人数");
            }
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals("预测新增疑似人数"))
            {
                this.DrawTwoSerise(this.PredictChart, "新增疑似人数", "预测新增疑似人数");
            }
        }

        private void DrawTwoSerise(Chart DataChart, string colname, string predColname)
        {
            if (this.predictTypeComboBox.SelectedItem.ToString().Equals(predColname))
            {
                // 清空
                DataChart.Series.Clear();
                Series series_confirm = DataChart.Series.Add(colname);
                series_confirm.XValueMember = "日期";
                series_confirm.YValueMembers = colname;
                Series series_predconfirm = DataChart.Series.Add(predColname);
                series_predconfirm.XValueMember = "日期";
                series_predconfirm.YValueMembers = predColname;
                //折线图
                DataChart.Series[0].ChartType = SeriesChartType.Spline;
                DataChart.Series[0].Color = Color.Orange;
                DataChart.Series[1].ChartType = SeriesChartType.Spline;
                DataChart.Series[1].Color = Color.Red;
                DataChart.ChartAreas[0].AxisX.Interval = 1;
            }
        }

        private int PredictPerDays(Double X, double[] parameterFitFunc, int modelLevel)
        {
            double numPeople = parameterFitFunc[0];
            for (int i = 1; i < modelLevel; i++)
            {
                numPeople += parameterFitFunc[i] * Math.Pow(X, i);
            }
            return (int)numPeople;
        }

        private void dateSelectBtn_Click(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = true;
        }

        private void DrawSeries(Chart DataChart, string colname)
        {
            if (this.typeComboBox.SelectedItem.ToString().Equals(colname))
            {
                // 清空
                DataChart.Series.Clear();
                Series series_confirm = DataChart.Series.Add(colname);
                series_confirm.XValueMember = "日期";
                series_confirm.YValueMembers = colname;
                //折线图
                DataChart.Series[0].ChartType = SeriesChartType.Spline;
                DataChart.Series[0].Color = Color.Orange;
                //DataChart.Series[0].IsValueShownAsLabel = true;
                //DataChart.Series[0].CustomProperties = "LabelStyle=Top";
                DataChart.ChartAreas[0].AxisX.Interval = 1;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // 绘制累计确诊曲线
            this.DrawSeries(this.currentDataChart, "累计确诊人数");
            // 绘制确诊曲线
            this.DrawSeries(this.currentDataChart, "确诊人数");
            // 绘制疑似曲线
            this.DrawSeries(this.currentDataChart, "疑似人数");
            // 绘制治愈曲线
            this.DrawSeries(this.currentDataChart, "治愈人数");
            // 绘制死亡曲线
            this.DrawSeries(this.currentDataChart, "死亡人数");
            // 绘制新增确诊曲线
            this.DrawSeries(this.currentDataChart, "新增确诊人数");
            // 绘制新增疑似曲线
            this.DrawSeries(this.currentDataChart, "新增疑似人数");
            #region 绘制全部曲线
            if (this.typeComboBox.SelectedItem.ToString().Equals("全部"))
            {
                // 清空
                this.currentDataChart.Series.Clear();
                Series series_confirm = this.currentDataChart.Series.Add("确诊人数");
                series_confirm.XValueMember = "日期";
                series_confirm.YValueMembers = "确诊人数";
                //折线图
                this.currentDataChart.Series[0].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[0].Color = Color.Orange;

                Series series_suspected = this.currentDataChart.Series.Add("疑似人数");
                series_suspected.XValueMember = "日期";
                series_suspected.YValueMembers = "疑似人数";
                this.currentDataChart.Series[1].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[1].Color = Color.Blue;

                Series series_heal = this.currentDataChart.Series.Add("治愈人数");
                series_heal.XValueMember = "日期";
                series_heal.YValueMembers = "治愈人数";
                this.currentDataChart.Series[2].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[2].Color = Color.Red;

                Series series_dead = this.currentDataChart.Series.Add("死亡人数");
                series_dead.XValueMember = "日期";
                series_dead.YValueMembers = "死亡人数";
                this.currentDataChart.Series[3].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[3].Color = Color.Black;

                Series series_add_confirm = this.currentDataChart.Series.Add("新增确诊人数");
                series_add_confirm.XValueMember = "日期";
                series_add_confirm.YValueMembers = "新增确诊人数";
                this.currentDataChart.Series[4].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[4].Color = Color.Purple;

                Series series_add_suspected = this.currentDataChart.Series.Add("新增疑似人数");
                series_add_suspected.XValueMember = "日期";
                series_add_suspected.YValueMembers = "新增疑似人数";
                this.currentDataChart.Series[5].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[5].Color = Color.LightCoral;

                Series series_sum_confirm = this.currentDataChart.Series.Add("累计确诊人数");
                series_sum_confirm.XValueMember = "日期";
                series_sum_confirm.YValueMembers = "累计确诊人数";
                this.currentDataChart.Series[6].ChartType = SeriesChartType.Spline;
                this.currentDataChart.Series[6].Color = Color.SaddleBrown;
            }
            #endregion

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.dateSelectText.Text = this.monthCalendar1.SelectionStart.ToShortDateString();
            //隐藏日历控件
            monthCalendar1.Hide();
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            this.PredictData();
        }

        private void SEIRdatetext_MouseDown(object sender, MouseEventArgs e)
        {
            this.monthCalendar2.Visible = true;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.SEIRdatetext.Text = this.monthCalendar2.SelectionStart.ToShortDateString();
            //隐藏日历控件
            this.monthCalendar2.Hide();
        }

        private void modelnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.PredictData();
        }


        private void showModelrichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            
        }
    }

    /// <summary>
    /// 读取类
    /// </summary>
    class DataRaw
    {
        private double _x;
        private double _y;
        private string _date;
        private string _sum_confirm; // 现有确诊
        private string _confirm; // 现有确诊
        private string _suspect; // 现有疑似
        private string _dead; // 累计死亡
        private string _heal; // 累计治愈
        private string _add_confirm; // 新增确诊
        private string _add_suspect; // 新增疑似


        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        public string date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string sum_confirm
        {
            get { return _sum_confirm; }
            set { _sum_confirm = value; }
        }
        public string confirm
        {
            get { return _confirm; }
            set { _confirm = value; }
        }
        public string suspect
        {
            get { return _suspect; }
            set { _suspect = value; }
        }
        public string dead
        {
            get { return _dead; }
            set { _dead = value; }
        }
        public string heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public string add_confirm
        {
            get { return _add_confirm; }
            set { _add_confirm = value; }
        }
        public string add_suspect
        {
            get { return _add_suspect; }
            set { _add_suspect = value; }
        }
    }

    #region 窗体空间自适应方法2
    //class Resize
    //{
    //    private Form _form;

    //    public Resize(Form form)
    //    {
    //        int count = form.Controls.Count * 2 + 2;
    //        float[] factor = new float[count];
    //        int i = 0;
    //        factor[i++] = form.Size.Width;
    //        factor[i++] = form.Size.Height;
    //        foreach (System.Windows.Forms.Control ctrl in form.Controls)
    //        {
    //            factor[i++] = ctrl.Location.X / (float)form.Size.Width;
    //            factor[i++] = ctrl.Location.Y / (float)form.Size.Height;
    //            ctrl.Tag = ctrl.Size;
    //        }
    //        form.Tag = factor;
    //        this._form = form;
    //    }

    //    public void Form1_Resize(object sender, EventArgs e)
    //    {
    //        float[] scale = (float[])this._form.Tag;
    //        int i = 2;
    //        foreach (System.Windows.Forms.Control ctrl in this._form.Controls) 
    //        {
    //            ctrl.Left = (int)(this._form.Size.Width * scale[i++]);
    //            ctrl.Top = (int)(this._form.Size.Height * scale[i++]);
    //            ctrl.Width = (int)(this._form.Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);
    //            ctrl.Height = (int)(this._form.Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);
    //        }
    //    }
    //}
    #endregion
}
