using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Text.RegularExpressions;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProDataBind();
        }

        /// <summary>
        /// 身份数据绑定
        /// </summary>
        private void ProDataBind()
        {
            List<ProCityCounty> pros = new List<ProCityCounty>();
            pros.Add(new ProCityCounty() { Name = "安徽", Href = "getCityByProvCode_110.html" });
            pros.Add(new ProCityCounty() { Name = "北京", Href = "getCityByProvCode_9017.html" });
            pros.Add(new ProCityCounty() { Name = "重庆", Href = "getCityByProvCode_9325.html" });
            pros.Add(new ProCityCounty() { Name = "福建", Href = "getCityByProvCode_150.html" });
            pros.Add(new ProCityCounty() { Name = "广东", Href = "getCityByProvCode_190.html" });
            pros.Add(new ProCityCounty() { Name = "广西", Href = "getCityByProvCode_210.html" });
            pros.Add(new ProCityCounty() { Name = "甘肃", Href = "getCityByProvCode_260.html" });
            pros.Add(new ProCityCounty() { Name = "贵州", Href = "getCityByProvCode_220.html" });
            pros.Add(new ProCityCounty() { Name = "海南", Href = "getCityByProvCode_200.html" });
            pros.Add(new ProCityCounty() { Name = "黑龙江", Href = "getCityByProvCode_90.html" });
            pros.Add(new ProCityCounty() { Name = "河北", Href = "getCityByProvCode_60.html " });
            pros.Add(new ProCityCounty() { Name = "河南", Href = "getCityByProvCode_180.html" });
            pros.Add(new ProCityCounty() { Name = "湖北", Href = "getCityByProvCode_170.html" });
            pros.Add(new ProCityCounty() { Name = "湖南", Href = "getCityByProvCode_160.html" });
            pros.Add(new ProCityCounty() { Name = "江苏", Href = "getCityByProvCode_100.html" });
            pros.Add(new ProCityCounty() { Name = "江西", Href = "getCityByProvCode_140.html" });
            pros.Add(new ProCityCounty() { Name = "吉林", Href = "getCityByProvCode_80.html " });
            pros.Add(new ProCityCounty() { Name = "辽宁", Href = "getCityByProvCode_70.html " });
            pros.Add(new ProCityCounty() { Name = "宁夏", Href = "getCityByProvCode_270.html" });
            pros.Add(new ProCityCounty() { Name = "内蒙古", Href = "getCityByProvCode_40.html" });
            pros.Add(new ProCityCounty() { Name = "青海", Href = "getCityByProvCode_280.html" });
            pros.Add(new ProCityCounty() { Name = "上海", Href = "getCityByProvCode_9264.html" });
            pros.Add(new ProCityCounty() { Name = "四川", Href = "getCityByProvCode_230.html" });
            pros.Add(new ProCityCounty() { Name = "陕西", Href = "getCityByProvCode_250.html" });
            pros.Add(new ProCityCounty() { Name = "山西", Href = "getCityByProvCode_50.html " });
            pros.Add(new ProCityCounty() { Name = "山东", Href = "getCityByProvCode_120.html" });
            pros.Add(new ProCityCounty() { Name = "天津", Href = "getCityByProvCode_9281 " });
            pros.Add(new ProCityCounty() { Name = "新疆", Href = "getCityByProvCode_290.html" });
            pros.Add(new ProCityCounty() { Name = "西藏", Href = "getCityByProvCode_300.html" });
            pros.Add(new ProCityCounty() { Name = "云南", Href = "getCityByProvCode_240.html" });
            pros.Add(new ProCityCounty() { Name = "浙江", Href = "getCityByProvCode_130.html" });

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

            List<ProCityCounty> coutys = new List<ProCityCounty>();
            string[] data = WebClientExt.GetHtmlData(url).Replace("||", "|").Split('|');
            foreach (var d in data)
            {
                ProCityCounty couty = new ProCityCounty();
                couty.Name = Regex.Replace(d, @"[^\u4e00-\u9fa5]", "").ToString();
                couty.Href = Regex.Replace(d, @"\D", "").ToString();
                coutys.Add(couty);
            }
            CbCounty.DataSource = coutys;
            CbCounty.DisplayMember = "Name";
            CbCounty.ValueMember = "Href";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void CbPro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ProCityCounty pro = (ProCityCounty)CbPro.SelectedItems;

            CbCounty.DataSource = null;

            CityDataBind(pro.Href);
        }


        private void CbCity_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ProCityCounty city = (ProCityCounty)CbCity.SelectedItems;
            CountyDataBind(city.Href);
        }

    }
}
