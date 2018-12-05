namespace 二十路功分网络TR
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::二十路功分网络TR.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barEditItem_驻波_索引号 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barEditItem_隔离度_索引号 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_地址配置 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_自动保存 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barEditItem_驻波_索引号,
            this.barButtonItem10,
            this.barEditItem_隔离度_索引号,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem_地址配置,
            this.barButtonItem1_自动保存});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.Size = new System.Drawing.Size(979, 134);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "新报表";
            this.barButtonItem1.DropDownControl = this.popupMenu1;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.new_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.new_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem6);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem7);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem8);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem9);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "本振功分网络（TR）";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.textbox_32x32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "本振功分网络（R）";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.textbox_32x321;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "合路功分网络（TR）";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.textbox_32x323;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "合路功分网络（R）";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.textbox_32x322;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "另存为";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.saveall_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.saveall_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "载入";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.loadfrom_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.loadfrom_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "驻波|插损|相位";
            this.barButtonItem4.DropDownControl = this.popupMenu2;
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.splinearea_16x16;
            this.barButtonItem4.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.splinearea_32x32;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // popupMenu2
            // 
            this.popupMenu2.ItemLinks.Add(this.barEditItem_驻波_索引号);
            this.popupMenu2.ItemLinks.Add(this.barButtonItem10);
            this.popupMenu2.ItemLinks.Add(this.barButtonItem12);
            this.popupMenu2.Name = "popupMenu2";
            this.popupMenu2.Ribbon = this.ribbonControl1;
            // 
            // barEditItem_驻波_索引号
            // 
            this.barEditItem_驻波_索引号.Caption = "索引号：";
            this.barEditItem_驻波_索引号.Edit = this.repositoryItemTextEdit1;
            this.barEditItem_驻波_索引号.EditValue = 7;
            this.barEditItem_驻波_索引号.Id = 9;
            this.barEditItem_驻波_索引号.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.merge_32x32;
            this.barEditItem_驻波_索引号.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.merge_32x32;
            this.barEditItem_驻波_索引号.Name = "barEditItem_驻波_索引号";
            this.barEditItem_驻波_索引号.Tag = "zhu";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "驻波等-开始测试";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.media_32x32;
            this.barButtonItem10.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.media_32x32;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "IN口-开始测试";
            this.barButtonItem12.Id = 13;
            this.barButtonItem12.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.media_32x32;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Caption = "隔离度";
            this.barButtonItem5.DropDownControl = this.popupMenu3;
            this.barButtonItem5.Id = 3;
            this.barButtonItem5.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.changechartseriestype_16x16;
            this.barButtonItem5.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.changechartseriestype_32x32;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // popupMenu3
            // 
            this.popupMenu3.ItemLinks.Add(this.barEditItem_隔离度_索引号);
            this.popupMenu3.ItemLinks.Add(this.barButtonItem11);
            this.popupMenu3.Name = "popupMenu3";
            this.popupMenu3.Ribbon = this.ribbonControl1;
            // 
            // barEditItem_隔离度_索引号
            // 
            this.barEditItem_隔离度_索引号.Caption = "索引号：";
            this.barEditItem_隔离度_索引号.Edit = this.repositoryItemTextEdit2;
            this.barEditItem_隔离度_索引号.EditValue = 7;
            this.barEditItem_隔离度_索引号.Id = 11;
            this.barEditItem_隔离度_索引号.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.merge_32x32;
            this.barEditItem_隔离度_索引号.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.merge_16x16;
            this.barEditItem_隔离度_索引号.Name = "barEditItem_隔离度_索引号";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "隔离度-开始测试";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.media_32x32;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem_地址配置
            // 
            this.barButtonItem_地址配置.Caption = "地址配置";
            this.barButtonItem_地址配置.Id = 14;
            this.barButtonItem_地址配置.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.pagesetup_16x16;
            this.barButtonItem_地址配置.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.pagesetup_32x32;
            this.barButtonItem_地址配置.Name = "barButtonItem_地址配置";
            this.barButtonItem_地址配置.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1_自动保存
            // 
            this.barButtonItem1_自动保存.Caption = "打开”自动保存“目录";
            this.barButtonItem1_自动保存.Id = 15;
            this.barButtonItem1_自动保存.ImageOptions.Image = global::二十路功分网络TR.Properties.Resources.converttoparagraphs_16x16;
            this.barButtonItem1_自动保存.ImageOptions.LargeImage = global::二十路功分网络TR.Properties.Resources.converttoparagraphs_32x32;
            this.barButtonItem1_自动保存.Name = "barButtonItem1_自动保存";
            this.barButtonItem1_自动保存.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_地址配置);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1_自动保存);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "常规操作";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "测试项目";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 134);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(979, 601);
            this.spreadsheetControl1.TabIndex = 1;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 735);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二十路功分网络测试软件  唐理文 2018.12";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private DevExpress.XtraBars.BarEditItem barEditItem_驻波_索引号;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarEditItem barEditItem_隔离度_索引号;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_地址配置;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_自动保存;
    }
}

