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
    public partial class SettingsModule : DevExpress.XtraEditors.XtraForm
    {
        public SettingsModule()
        {
            InitializeComponent();

            textEdit_矢网地址.Text = Function_Module.GetConfig("矢网地址");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Function_Module.SetConfig("矢网地址", textEdit_矢网地址.Text);
                XtraMessageBox.Show("设置成功！程序重启后即可", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}