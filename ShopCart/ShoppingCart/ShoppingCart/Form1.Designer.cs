namespace ShoppingCart
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.CbPro = new Telerik.WinControls.UI.RadDropDownList();
            this.CbCity = new Telerik.WinControls.UI.RadDropDownList();
            this.CbCounty = new Telerik.WinControls.UI.RadDropDownList();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 124);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(517, 205);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(13, 10);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "导入帐号";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radProgressBar1.ImageIndex = -1;
            this.radProgressBar1.ImageKey = "";
            this.radProgressBar1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radProgressBar1.Location = new System.Drawing.Point(13, 92);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBar1.Size = new System.Drawing.Size(516, 23);
            this.radProgressBar1.TabIndex = 3;
            this.radProgressBar1.Text = "radProgressBar1";
            // 
            // CbPro
            // 
            this.CbPro.DropDownAnimationEnabled = true;
            this.CbPro.Location = new System.Drawing.Point(13, 50);
            this.CbPro.Name = "CbPro";
            this.CbPro.ShowImageInEditorArea = true;
            this.CbPro.Size = new System.Drawing.Size(172, 20);
            this.CbPro.TabIndex = 4;
            this.CbPro.Text = "请选择";
            this.CbPro.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CbPro_SelectedIndexChanged);
            // 
            // CbCity
            // 
            this.CbCity.DropDownAnimationEnabled = true;
            this.CbCity.Location = new System.Drawing.Point(191, 50);
            this.CbCity.Name = "CbCity";
            this.CbCity.ShowImageInEditorArea = true;
            this.CbCity.Size = new System.Drawing.Size(172, 20);
            this.CbCity.TabIndex = 4;
            this.CbCity.Text = "请选择";
            this.CbCity.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CbCity_SelectedIndexChanged);
            // 
            // CbCounty
            // 
            this.CbCounty.DropDownAnimationEnabled = true;
            this.CbCounty.Location = new System.Drawing.Point(369, 50);
            this.CbCounty.Name = "CbCounty";
            this.CbCounty.ShowImageInEditorArea = true;
            this.CbCounty.Size = new System.Drawing.Size(158, 20);
            this.CbCounty.TabIndex = 4;
            this.CbCounty.Text = "请选择";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(145, 10);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(120, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "登录";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(409, 10);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(120, 24);
            this.radButton3.TabIndex = 2;
            this.radButton3.Text = "停止";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(278, 10);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(120, 24);
            this.radButton4.TabIndex = 2;
            this.radButton4.Text = "开始";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 341);
            this.Controls.Add(this.CbCounty);
            this.Controls.Add(this.CbCity);
            this.Controls.Add(this.CbPro);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.UI.RadDropDownList CbPro;
        private Telerik.WinControls.UI.RadDropDownList CbCity;
        private Telerik.WinControls.UI.RadDropDownList CbCounty;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}

