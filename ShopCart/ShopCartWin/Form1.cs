using OrderUtil;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCartWin
{
    public partial class Form1 : Form
    {

        DataSourceManager<_Account> dsm = new DataSourceManager<_Account>();
        _Account account = new _Account();
        BindingList<Member> members = new BindingList<Member>();
        int id = 0;
        public Form1()
        {
            int threadId = AppDomain.GetCurrentThreadId();
            InitializeComponent();
            this.progressBar1.Value = 0;
            this.progressBar1.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;

            dsm.OnDataAdded += new Action<_Account>(Dsm_OnDataAdded);
            dsm.OnReady += dsm_OnReady;
            dsm.OnError += dsm_OnError;

        }

        void dsm_OnError(string obj)
        {
            MessageBox.Show("账号全部导入成功！");
        }

        void dsm_OnReady()
        {
            this.progressBar1.Value = 0;
            this.progressBar1.Visible = true;
            this.progressBar1.Maximum = dsm.RecordCount;
        }

        void Dsm_OnDataAdded(_Account obj)
        {
            int threadId = AppDomain.GetCurrentThreadId();
            account = dsm.GetAccount();
            if (account != null)
            {
                Member m = new Member();
                m.Id = id;
                m.UserName = account.User;
                m.PassWord = account.Password;
                members.Add(m);
                id++;

                progressBar1.Value++;
                //if (progressBar1.Value >= progressBar1.Maximum)
                //{
                //    progressBar1.Visible = false;
                //}
            }

        }

        #region 省市县三级数据联动

        private void Form1_Load(object sender, EventArgs e)
        {
            ProDataBind();
        }

        private void CbPro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProCityCounty pro = (ProCityCounty)CbPro.SelectedItem;

            CbCounty.DataSource = null;

            CityDataBind(pro.Href);
        }

        private void CbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProCityCounty city = (ProCityCounty)CbCity.SelectedItem;

            CountyDataBind(city.Href);

        }

        /// <summary>
        /// 身份数据绑定
        /// </summary>
        private void ProDataBind()
        {
            List<ProCityCounty> pros = new List<ProCityCounty>();
            pros.Add(new ProCityCounty() { Name = "安徽", Href = "getCityByProvCode_110.html   " });
            pros.Add(new ProCityCounty() { Name = "北京", Href = "getCityByProvCode_9017.html  " });
            pros.Add(new ProCityCounty() { Name = "重庆", Href = "getCityByProvCode_9325.html  " });
            pros.Add(new ProCityCounty() { Name = "福建", Href = "getCityByProvCode_150.html   " });
            pros.Add(new ProCityCounty() { Name = "广东", Href = "getCityByProvCode_190.html   " });
            pros.Add(new ProCityCounty() { Name = "广西", Href = "getCityByProvCode_210.html   " });
            pros.Add(new ProCityCounty() { Name = "甘肃", Href = "getCityByProvCode_260.html   " });
            pros.Add(new ProCityCounty() { Name = "贵州", Href = "getCityByProvCode_220.html   " });
            pros.Add(new ProCityCounty() { Name = "海南", Href = "getCityByProvCode_200.html   " });
            pros.Add(new ProCityCounty() { Name = "黑龙江", Href = "getCityByProvCode_90.html  " });
            pros.Add(new ProCityCounty() { Name = "河北", Href = "getCityByProvCode_60.html    " });
            pros.Add(new ProCityCounty() { Name = "河南", Href = "getCityByProvCode_180.html   " });
            pros.Add(new ProCityCounty() { Name = "湖北", Href = "getCityByProvCode_170.html   " });
            pros.Add(new ProCityCounty() { Name = "湖南", Href = "getCityByProvCode_160.html   " });
            pros.Add(new ProCityCounty() { Name = "江苏", Href = "getCityByProvCode_100.html   " });
            pros.Add(new ProCityCounty() { Name = "江西", Href = "getCityByProvCode_140.html   " });
            pros.Add(new ProCityCounty() { Name = "吉林", Href = "getCityByProvCode_80.html    " });
            pros.Add(new ProCityCounty() { Name = "辽宁", Href = "getCityByProvCode_70.html    " });
            pros.Add(new ProCityCounty() { Name = "宁夏", Href = "getCityByProvCode_270.html   " });
            pros.Add(new ProCityCounty() { Name = "内蒙古", Href = "getCityByProvCode_40.html  " });
            pros.Add(new ProCityCounty() { Name = "青海", Href = "getCityByProvCode_280.html   " });
            pros.Add(new ProCityCounty() { Name = "上海", Href = "getCityByProvCode_9264.html  " });
            pros.Add(new ProCityCounty() { Name = "四川", Href = "getCityByProvCode_230.html   " });
            pros.Add(new ProCityCounty() { Name = "陕西", Href = "getCityByProvCode_250.html   " });
            pros.Add(new ProCityCounty() { Name = "山西", Href = "getCityByProvCode_50.html    " });
            pros.Add(new ProCityCounty() { Name = "山东", Href = "getCityByProvCode_120.html   " });
            pros.Add(new ProCityCounty() { Name = "天津", Href = "getCityByProvCode_9281       " });
            pros.Add(new ProCityCounty() { Name = "新疆", Href = "getCityByProvCode_290.html   " });
            pros.Add(new ProCityCounty() { Name = "西藏", Href = "getCityByProvCode_300.html   " });
            pros.Add(new ProCityCounty() { Name = "云南", Href = "getCityByProvCode_240.html   " });
            pros.Add(new ProCityCounty() { Name = "浙江", Href = "getCityByProvCode_130.html   " });

            CbPro.DataSource = pros;
            CbPro.DisplayMember = "Name";
            CbPro.ValueMember = "Href";
        }


        /// <summary>
        /// 城市数据
        /// </summary>
        /// <param name="href">省份编码</param>
        private void CityDataBind(string href)
        {
            string url = ConfigurationSettings.AppSettings["pro"] + href;

            List<ProCityCounty> citys = new List<ProCityCounty>();
            string[] data = WebClientExt.GetHtmlData(url).Replace("||", "|").Split('|');
            foreach (var d in data)
            {
                ProCityCounty city = new ProCityCounty();
                city.Name = Regex.Replace(d, @"[^\u4e00-\u9fa5]", "").ToString();
                city.Href = Regex.Replace(d, @"\D", "").ToString();
                citys.Add(city);
            }

            CbCity.DataSource = citys;
            CbCity.DisplayMember = "Name";
            CbCity.ValueMember = "Href";
        }


        /// <summary>
        /// 县市数据绑定
        /// </summary>
        /// <param name="href"></param>
        private void CountyDataBind(string href)
        {
            string url = ConfigurationSettings.AppSettings["city"] + href + ".html";

            List<ProCityCounty> countys = new List<ProCityCounty>();
            string[] data = WebClientExt.GetHtmlData(url).Replace("||", "|").Split('|');
            foreach (var d in data)
            {
                ProCityCounty county = new ProCityCounty();
                county.Name = Regex.Replace(d, @"[^\u4e00-\u9fa5]", "").ToString();
                county.Href = Regex.Replace(d, @"\D", "").ToString();
                countys.Add(county);
            }
            CbCounty.DataSource = countys;
            CbCounty.DisplayMember = "Name";
            CbCounty.ValueMember = "Href";
        }

        #endregion

        //导入帐号
        private void Import_Click(object sender, EventArgs e)
        {
            int threadId = AppDomain.GetCurrentThreadId();
            dsm.Open();
            dg.DataSource = null;
            new Threads(1, (ThreadStart)delegate()
            {
                dg.AutoGenerateColumns = false;
                dg.DataSource = members;
                dg.Columns["Num"].DataPropertyName = "Id";
                dg.Columns["Sel"].DataPropertyName = "IsSel";
                dg.Columns["User"].DataPropertyName = "UserName";
                dg.Columns["Password"].DataPropertyName = "Password";
            }).Start();

        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < members.Count - 1; i++)
            {
                if (members[i].IsSel)
                {
                    Logined(i);
                }
            }
            
        }

        Dictionary<int, CookieContainer> cookieContainers = new Dictionary<int, CookieContainer>();

        public void Logined(int i)
        {
            
            string postData = @"{'loginTheme':'defaultTheme','password':'"+members[i].PassWord+"','secPassword':'','service':'','username':'"+members[i].UserName+"','uuid':'e69e32dc-d56a-4956-a9a9-f61b897d3606','verifyCode':''}";

            cookieContainers.Add(i, WebClientExt.GetCooKie(ConfigurationSettings.AppSettings["LoginUrl"], postData));

            members[i].LoginState = "登陆成功";
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

    }
}
