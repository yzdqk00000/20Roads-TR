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
        Settings矢网_高级选项 _Settings_NetWork;

        public SettingsModule()
        {
            InitializeComponent();

            _Settings_NetWork = new Settings矢网_高级选项();

            textEdit_矢网地址.Text = Function_Module.GetConfig("矢网地址");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Function_Module.SetConfig("矢网地址", textEdit_矢网地址.Text);

                Function_Module.SetConfig("窗口1", _Settings_NetWork.textEdit_窗口1.Text);
                Function_Module.SetConfig("窗口2", _Settings_NetWork.textEdit_窗口2.Text);
                Function_Module.SetConfig("窗口3", _Settings_NetWork.textEdit_窗口3.Text);
                Function_Module.SetConfig("窗口4", _Settings_NetWork.textEdit_窗口4.Text);

                XtraMessageBox.Show("设置成功！程序重启后即可", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void simpleButton_高级选项_矢网_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            string[] name = sb.Name.Split('_');
            switch (name[2])
            {
                case "矢网":
                    _Settings_NetWork.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}