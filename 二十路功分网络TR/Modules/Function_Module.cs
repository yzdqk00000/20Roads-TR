using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Win32;
using System.Windows.Forms;

namespace 二十路功分网络TR
{
    /// <summary>
    /// 功能模块：主要存放累加，异或，字节处理等常用协议处理方法
    /// </summary>
    
    public class Function_Module
    {
        /// <summary>
        /// 累加校验
        /// </summary>
        /// <param name="ck"></param>
        /// <returns></returns>
        public static string AddCheck(string ck)
        {
            string[] res = ck.Split(' ');
            int ires = 0;
            string sres = "";
            for (int i = 0; i < res.Length; i++)
            {
                ires += Convert.ToInt32(res[i], 16);
            }
            sres = Convert.ToString(ires, 16).Length < 2 ? "0" + Convert.ToString(ires, 16) : Convert.ToString(ires, 16);
            sres = sres.Substring(sres.Length - 2, 2);
            return sres;
        }

        /// <summary>
        /// 异或校验
        /// </summary>
        /// <param name="checkmsg"></param>
        /// <returns></returns>
        public static string Xorcheck(string checkmsg)
        {
            string[] checkdata = checkmsg.Split(' ');
            int checkres = 0;
            for (int i = 0; i < checkdata.Length; i++)
            {
                int data = Convert.ToInt32(checkdata[i], 16);
                checkres = checkres ^ data;
            }
            return Convert.ToString(checkres, 16).Length < 2 ? "0" + Convert.ToString(checkres, 16) : Convert.ToString(checkres, 16);
        }

        /// <summary>
        /// 取反加一校验
        /// </summary>
        /// <param name="checkmsg"></param>
        /// <returns></returns>
        public static string Notcheck(string checkmsg)
        {
            string[] checkdata = checkmsg.Split(' ');
            int checkres = 0;
            for (int i = 0; i < checkdata.Length; i++)
            {
                int data = Convert.ToInt32(checkdata[i], 16);
                checkres += data;
            }
            string reslt = Convert.ToString((255 - checkres) + 1, 16);
            reslt = reslt.Length < 2 ? "0" + reslt : reslt;
            return reslt.Substring(reslt.Length - 2, 2);
        }
  
        /// <summary>
        /// 读取配配置文件值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 设置配置文件键值
        /// </summary>
        /// <param name="newkey"></param>
        /// <param name="newvalue"></param>
        public static void SetConfig(string newkey, string newvalue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newkey)
                {
                    isModified = true;
                }
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newkey);
            }

            config.AppSettings.Settings.Add(newkey, newvalue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 设置开机自启
        /// </summary>
        public static void AutoOpen()
        {
            try
            {
                string path = Application.ExecutablePath;
                RegistryKey key = Registry.LocalMachine;
                RegistryKey k2 = key.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                k2.SetValue("SKR", path);
                k2.Close();
                key.Close();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 拆字节为二进制，并补位到8位
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char[] CharArr(string s)
        {
            int a = Convert.ToInt32(s, 16);
            string aa = Convert.ToString(a, 2);
            string ab = AddZero(aa);
            char[] c = ab.ToArray();
            return c;
        }

        /// <summary>
        /// 补零到8位
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string AddZero(string s)
        {
            string addZero = "";
            if (s.Length != 8)
            {
                for (int i = 0; i < 8 - s.Length; i++)
                {
                    addZero += "0";
                }
                s = addZero + s;
            }
            return s;
        }

        /// <summary>
        /// 补零到N位
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string AddZero_ToN(string s,int n)
        {
            string addZero = "";
            if (s.Length != n)
            {
                for (int i = 0; i < n - s.Length; i++)
                {
                    addZero += "0";
                }
                s = addZero + s;
            }
            return s;
        }

        /// <summary>
        /// 跨位转换：输入一个十进制数，按十六进制每两位一个空格隔开并输出
        /// </summary>
        /// <param name="number">500</param>
        /// <returns>01 F4</returns>
        public static string ByteBeyond(int number)
        {
            string init16 = Convert.ToString(number, 16);

            //检查长度是否为偶数
            if (init16.Length % 2 == 0)
            {
                string two16 = init16;
                int quotinents = (two16.Length / 2) - 1;

                if (quotinents == 0)
                {
                    return two16;
                }
                else
                {
                    for (int i = 1; i <= quotinents; i++)
                    {
                        two16 = two16.Insert(i * 2 + (i - 1), " ");
                    }
                    return two16;
                }

            }
            //奇数情况
            else
            {
                //补成偶数位
                string two16 = Function_Module.AddZero_ToN(init16, init16.Length + 1);
                int quotinents = (two16.Length / 2) - 1;

                if (quotinents == 0)
                {
                    return two16;
                }
                else
                {
                    for (int i = 1; i <= quotinents; i++)
                    {
                        two16 = two16.Insert(i * 2 + (i - 1), " ");
                    }
                    return two16;
                }

            }
        }

        
        /// <summary>
        /// 跨位转换进阶：输入指定位数，自动补零并有空格隔开
        /// </summary>
        /// <param name="number">100</param>
        /// <param name="weishu">4</param>
        /// <returns>00 64</returns>
        public static string ByteBeyond_Selected(int number, int weishu)
        {
            //判断位数是否是偶数
            if (weishu % 2 != 0)
            {
                return "-1";
            }
            else
            {
                //判断使用ByteBeyond转换后去除空格的长度是否等于指定长度
                if (Function_Module.ByteBeyond(number).Replace(" ", "").Length == Convert.ToInt32(weishu))
                {
                    return Function_Module.ByteBeyond(number);
                }
                else if ((Function_Module.ByteBeyond(number).Replace(" ", "").Length  > weishu))
                {
                    return "-1";
                }
                else
                {
                    int changeValue = Convert.ToInt32(weishu) - Function_Module.ByteBeyond(number).Replace(" ", "").Length;
                    string result = Function_Module.ByteBeyond(number);

                    //判断应该加几个00
                    changeValue = changeValue / 2;
                    for (int i = 1; i <= changeValue; i++)
                    {
                        result = "00 " + result;
                    }
                    return result;
                }

            }       
        }

        /// <summary>
        /// 接收字节数据后转换位字符串
        /// </summary>
        /// <param name="recvByte"></param>
        /// <returns></returns>
        public static string[] RecvProgress(byte[] recvByte)
        {
            string recvData = "";
            for (int i = 0; i < recvByte.Length; i++)
            {
                recvData += recvByte[i].ToString("x2") + "_";
            }
            //接受数组recvArr
            string[] recvArr = recvData.Split('_');
            //检查校验位是否正确

            return recvArr;
        }

        /// <summary>
        /// Excel数字转字母
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string ToName(int index)
        {
            if (index < 0) { throw new Exception("无效"); }

            List<string> chars = new List<string>();
            do
            {
                if (chars.Count > 0) index--;
                chars.Insert(0, ((char)(index % 26 + (int)'A')).ToString());
                index = (int)((index - index % 26) / 26);
            } while (index > 0);

            return String.Join(string.Empty, chars.ToArray());
        }

        /// <summary>
        /// Excel字母转数字
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static int ToIndex(string columnName)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(columnName.ToUpper(), @"[A-Z]+")) { throw new Exception("无效"); }

            int index = 0;
            char[] chars = columnName.ToUpper().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index += ((int)chars[i] - (int)'A' + 1) * (int)Math.Pow(26, chars.Length - i - 1);
            }
            return index - 1;
        }

        /// <summary>
        /// 排列组合算法
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public static List<string[]> Permutation_and_Combination(string[] test)
        {
            int n = 2;//长度为2的所有组合  
            List<string[]> list = new List<string[]>();
            foreach (string s in test)
            {
                List<string[]> lst = list.Where(p => p.Length < n).ToList();
                string[] nArr = { s };
                list.Add(nArr);
                foreach (string[] ss in lst)
                {
                    list.Add(ss.Concat(nArr).ToArray());
                }
            }
            list.RemoveAll(p => p.Length == 1);
            //outList.ForEach(p => Console.WriteLine(string.Join(",", p)));
            return list;
        }

    }
     
}
