namespace ShopCartWin
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.CbPro = new System.Windows.Forms.ComboBox();
            this.CbCity = new System.Windows.Forms.ComboBox();
            this.CbCounty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Sel,
            this.User,
            this.Password,
            this.LoginState,
            this.CartState});
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 23;
            this.dg.Size = new System.Drawing.Size(609, 312);
            this.dg.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "序号";
            this.Num.Name = "Num";
            this.Num.Width = 60;
            // 
            // Sel
            // 
            this.Sel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sel.HeaderText = "选择";
            this.Sel.Name = "Sel";
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sel.Width = 60;
            // 
            // User
            // 
            this.User.HeaderText = "帐号";
            this.User.Name = "User";
            this.User.Width = 120;
            // 
            // Password
            // 
            this.Password.HeaderText = "密码";
            this.Password.Name = "Password";
            this.Password.Width = 120;
            // 
            // LoginState
            // 
            this.LoginState.HeaderText = "登录状态";
            this.LoginState.Name = "LoginState";
            // 
            // CartState
            // 
            this.CartState.HeaderText = "购物车";
            this.CartState.Name = "CartState";
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(12, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 1;
            this.Import.Text = "导入帐号";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(183, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 1;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(369, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(546, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // CbPro
            // 
            this.CbPro.FormattingEnabled = true;
            this.CbPro.Location = new System.Drawing.Point(55, 56);
            this.CbPro.Name = "CbPro";
            this.CbPro.Size = new System.Drawing.Size(121, 20);
            this.CbPro.TabIndex = 2;
            this.CbPro.SelectionChangeCommitted += new System.EventHandler(this.CbPro_SelectionChangeCommitted);
            // 
            // CbCity
            // 
            this.CbCity.FormattingEnabled = true;
            this.CbCity.Location = new System.Drawing.Point(262, 56);
            this.CbCity.Name = "CbCity";
            this.CbCity.Size = new System.Drawing.Size(121, 20);
            this.CbCity.TabIndex = 2;
            this.CbCity.SelectionChangeCommitted += new System.EventHandler(this.CbCity_SelectionChangeCommitted);
            // 
            // CbCounty
            // 
            this.CbCounty.FormattingEnabled = true;
            this.CbCounty.Location = new System.Drawing.Point(500, 56);
            this.CbCounty.Name = "CbCounty";
            this.CbCounty.Size = new System.Drawing.Size(121, 20);
            this.CbCounty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "省份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "城市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "地区：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 312);
            this.panel1.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(609, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Tag = "";
            this.progressBar1.Value = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 453);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbCounty);
            this.Controls.Add(this.CbCity);
            this.Controls.Add(this.CbPro);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Import);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ComboBox CbPro;
        private System.Windows.Forms.ComboBox CbCity;
        private System.Windows.Forms.ComboBox CbCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginState;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartState;
    }
}

