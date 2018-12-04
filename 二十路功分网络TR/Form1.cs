using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InstrLibrary.InstrObect;
using DevExpress.XtraEditors;
using 二十路功分网络TR.TestLibrary;
using DevExpress.XtraBars;

namespace 二十路功分网络TR
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NetWorkAnalyzerBase _NetWork = new NetWorkAnalyzerBase("GPIB0::16::INSTR");

        public 驻波_相位_插损 Test驻波;
        public 隔离度 Test隔离度;
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                _NetWork.VisaOpen();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("仪表链接失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            Test隔离度 = new 隔离度(_NetWork);
            Test驻波 = new 驻波_相位_插损(_NetWork);
        }

        /// <summary>
        /// 工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool IsTest = false;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (e.Item.Caption)
                {
                    case "另存为":
                        this.saveFileDialog1.Filter = "2010 Excel文件|*.xlsx|97-2003 Excel文件|*.xls";
                        this.saveFileDialog1.FileName = spreadsheetControl1.Document.Worksheets[0].Cells["A7"].Value.ToString();
                        if (DialogResult.OK == this.saveFileDialog1.ShowDialog())
                        {
                            string path = this.saveFileDialog1.FileName;
                            this.spreadsheetControl1.Document.SaveDocument(path);
                        }
                        break;

                    case "驻波等-开始测试":
                        IsTest = true;
                        while (IsTest)
                        {
                            DialogResult res = XtraMessageBox.Show("即将进行驻波|幅度|相位测试  第" + barEditItem_驻波_索引号.EditValue + "行 \n 点击【YES】开始测试\n点击【No】,重新测试\n点击【Cancel】，停止测试", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (res == DialogResult.Yes)
                            {
                                驻波等测试();
                                barEditItem_驻波_索引号.EditValue = Convert.ToInt32(barEditItem_驻波_索引号.EditValue) + 1;
                            }
                            else if(res == DialogResult.No)
                            {
                                barEditItem_驻波_索引号.EditValue = Convert.ToInt32(barEditItem_驻波_索引号.EditValue) - 1;
                                驻波等测试();
                                barEditItem_驻波_索引号.EditValue = Convert.ToInt32(barEditItem_驻波_索引号.EditValue) + 1;
                            }
                            else
                            {
                                IsTest = false;
                            }
                        }         

                        break;

                    case "IN口-开始测试":
                        double zhubo2 = Test驻波.驻波测试();
                        spreadsheetControl1.Document.Worksheets[0].Cells["C" + 27].Value = zhubo2.ToString("f2");
                        spreadsheetControl1.Document.Worksheets[0].Cells["C" + 27].FillColor = zhubo2 <= 1.5 ? Color.White : Color.Red;
                        break;

                    case "隔离度-开始测试":
                        IsTest = true;
                        while (IsTest)
                        {
                            DialogResult res = XtraMessageBox.Show("即将进行隔离度测试  第" + barEditItem_隔离度_索引号.EditValue + "行 \n 点击【YES】开始测试\n点击【No】,重新测试\n点击【Cancel】，停止测试", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (res == DialogResult.Yes)
                            {
                                隔离度测试();
                                barEditItem_隔离度_索引号.EditValue = Convert.ToInt32(barEditItem_隔离度_索引号.EditValue) + 2;
                            }
                            else if (res == DialogResult.No)
                            {
                                barEditItem_隔离度_索引号.EditValue = Convert.ToInt32(barEditItem_隔离度_索引号.EditValue) - 2;
                                隔离度测试();
                                barEditItem_隔离度_索引号.EditValue = Convert.ToInt32(barEditItem_隔离度_索引号.EditValue) + 2;               
                            }
                            else
                            {
                                IsTest = false;
                            }

                        }
                        IsTest = true;

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        /// <summary>
        /// 报表载入菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Caption)
            {
                case "本振功分网络（TR）":
                    spreadsheetControl1.Document.LoadDocument("本振（TR）测试表格.xlsx");
                    Test指标.驻波 = 1.5;
                    Test指标.幅度 = 15.5;
                    Test指标.相位 = 10;
                    Test指标.隔离度 = 20;

                    break;

                case "本振功分网络（R）":
                    spreadsheetControl1.Document.LoadDocument("本振（R）测试表格.xlsx");
                    Test指标.驻波 = 1.5;
                    Test指标.幅度 = 15.5;
                    Test指标.相位 = 10;
                    Test指标.隔离度 = 20;
                    break;

                case "合路功分网络（TR）":
                    spreadsheetControl1.Document.LoadDocument("合路（TR）测试表格.xlsx");
                    Test指标.驻波 = 1.8;
                    Test指标.幅度 = 17;
                    Test指标.相位 = 8;
                    Test指标.隔离度 = 25;
                    break;

                case "合路功分网络（R）":
                    spreadsheetControl1.Document.LoadDocument("合路（R）测试表格.xlsx");
                    Test指标.驻波 = 1.8;
                    Test指标.幅度 = 15;
                    Test指标.相位 = 5;
                    Test指标.隔离度 = 30;
                    break;
                default:
                    break;
            }

            //索引回归
            barEditItem_驻波_索引号.EditValue = 7;
            barEditItem_隔离度_索引号.EditValue = 7;
            
        }

        private void 隔离度测试()
        {
            double value = Test隔离度.Start();
            spreadsheetControl1.Document.Worksheets[0].Cells["J" + barEditItem_隔离度_索引号.EditValue].Value = value;
            spreadsheetControl1.Document.Worksheets[0].Cells["J" + barEditItem_隔离度_索引号.EditValue].FillColor = value >= Test指标.隔离度 ? Color.White : Color.Red;
        }

        private void 驻波等测试()
        {
            spreadsheetControl1.BeginUpdate();

            double zhubo = Test驻波.驻波测试();

            spreadsheetControl1.Document.Worksheets[0].Cells["C" + barEditItem_驻波_索引号.EditValue].Value = zhubo;
            spreadsheetControl1.Document.Worksheets[0].Cells["C" + barEditItem_驻波_索引号.EditValue].FillColor = zhubo <= Test指标.驻波 ? Color.White : Color.Red;
       
            double[] db = Test驻波.幅度测试();
            spreadsheetControl1.Document.Worksheets[0].Cells["D" + barEditItem_驻波_索引号.EditValue].Value = db[0];
            spreadsheetControl1.Document.Worksheets[0].Cells["D" + barEditItem_驻波_索引号.EditValue].FillColor = db[0] < Test指标.幅度 ? Color.White : Color.Red;
            spreadsheetControl1.Document.Worksheets[0].Cells["E" + barEditItem_驻波_索引号.EditValue].Value = db[1];
            spreadsheetControl1.Document.Worksheets[0].Cells["E" + barEditItem_驻波_索引号.EditValue].FillColor = db[1] < Test指标.幅度 ? Color.White : Color.Red;
            spreadsheetControl1.Document.Worksheets[0].Cells["F" + barEditItem_驻波_索引号.EditValue].Value = db[2];
            spreadsheetControl1.Document.Worksheets[0].Cells["F" + barEditItem_驻波_索引号.EditValue].FillColor = db[2] < Test指标.幅度 ? Color.White : Color.Red;

            double[] db2 = Test驻波.相位测试();
            spreadsheetControl1.Document.Worksheets[0].Cells["G" + barEditItem_驻波_索引号.EditValue].Value = db2[0];
            spreadsheetControl1.Document.Worksheets[0].Cells["G" + barEditItem_驻波_索引号.EditValue].FillColor = Math.Abs(db2[0]) <= Test指标.相位 ? Color.White : Color.Red;
            spreadsheetControl1.Document.Worksheets[0].Cells["H" + barEditItem_驻波_索引号.EditValue].Value = db2[1];
            spreadsheetControl1.Document.Worksheets[0].Cells["H" + barEditItem_驻波_索引号.EditValue].FillColor = Math.Abs(db2[1]) <= Test指标.相位 ? Color.White : Color.Red;
            spreadsheetControl1.Document.Worksheets[0].Cells["I" + barEditItem_驻波_索引号.EditValue].Value = db2[2];
            spreadsheetControl1.Document.Worksheets[0].Cells["I" + barEditItem_驻波_索引号.EditValue].FillColor = Math.Abs(db2[2]) <= Test指标.相位 ? Color.White : Color.Red;

            spreadsheetControl1.Document.SaveDocument("AutoSave.xlsx");
            spreadsheetControl1.EndUpdate();
        }
    }
}
