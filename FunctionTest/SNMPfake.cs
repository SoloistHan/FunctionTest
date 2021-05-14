using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionTest
{
    public partial class  FormMain
    {
        Random ran = new Random();
        int i_counToStr = 0;
        public void SNMPtrans()
        {

            try
            {

                List<string> list_OutData = new List<string>();
                string ReadOne;
                string OID = "";
                string VT = "";

                using (StreamReader sr = File.OpenText(TextBox_SNMPsource.Text))
                {
                    while ((ReadOne = sr.ReadLine()) != null)
                    {
                        if (ReadOne.IndexOf("oid") > -1)
                        {
                            int FirstDot = ReadOne.IndexOf(".");
                            OID = ReadOne.Substring(FirstDot, ReadOne.Length - 6);

                            if ((ReadOne = sr.ReadLine()).IndexOf("valueType") > -1)
                            {
                                if (ReadOne.IndexOf("String") > -1)
                                    VT = "STRING";
                                else if (ReadOne.IndexOf("TimeTicks") > -1)
                                    VT = "Timeticks";
                                else if (ReadOne.IndexOf("Integer") > -1)                                
                                    VT = "INTEGER";
                                else if (ReadOne.IndexOf("Gauge") > -1)
                                    VT = "Gauge32";
                                else
                                    VT = ReadOne.Substring((ReadOne.IndexOf("=") + 2), ReadOne.Length - 12);
                            }

                            list_OutData.Add($"{OID} = {VT}: {FakeValue(VT)}");
                            i_counToStr++;
                        }
                    }
                    sr.Dispose();
                }
                string TargetFolder = TextBox_SNMPtarget.Text.Substring(0, TextBox_SNMPtarget.Text.LastIndexOf(@"\"));
                if (!Directory.Exists(TargetFolder));
                    Directory.CreateDirectory(TargetFolder);

                StreamWriter sw = new StreamWriter(TextBox_SNMPtarget.Text);
                foreach(string everyOne in list_OutData)
                {
                    sw.WriteLine(everyOne,true);
                }
                sw.Dispose();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string FakeValue(string VT)
        {
            //string Generate = "";
            if (VT == "STRING")
            {
                return "\"" + TextBox_SNMPstrTitle.Text + "_" + i_counToStr.ToString() + "\"";
            }
            else if (VT == "Timeticks")
            {
                return $"({i_counToStr}) {DateTime.Now.ToString("HH:mm:ss.ss")}";
            }
            else if (VT == "INTEGER")
            {
                return i_counToStr.ToString();
            }
            else if (VT == "IpAddress")
            {
                int lastOne = ran.Next(1, 255);
                return $"192.168.0.{lastOne}";
            }
            else if ( VT == "Gauge32")
            {
                return i_counToStr.ToString() + "000";
            }
            else
                return "Unknow Type";
        }

    }
}
