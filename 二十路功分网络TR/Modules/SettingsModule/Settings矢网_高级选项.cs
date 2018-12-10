using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace 二十路功分网络TR.Modules
{
    public partial class Settings矢网_高级选项 : DevExpress.XtraEditors.XtraForm
    {
        public Settings矢网_高级选项()
        {
            InitializeComponent();

            textEdit_窗口1.Text = Function_Module.GetConfig("窗口1");
            textEdit_窗口2.Text = Function_Module.GetConfig("窗口2");
            textEdit_窗口3.Text = Function_Module.GetConfig("窗口3");
            textEdit_窗口4.Text = Function_Module.GetConfig("窗口4");
        }
    }
}