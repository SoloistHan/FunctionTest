using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionTest
{
    public class Rename
    {
        public static void RenameFile(string SourceFolder, string TargetFolder, string NewName, string Extension)
        {
            try
            {
                List<string> GetFileList = new List<string>(Directory.GetFiles(SourceFolder));

                if (!Directory.Exists(TargetFolder))
                    Directory.CreateDirectory(TargetFolder);

                int Start = 0;
                foreach(string source in GetFileList)
                {
                    Start++;
                    string Four = Start.ToString();
                    if (Four.Length == 1)
                        Four = "000" + Four;
                    else if (Four.Length == 2)
                        Four = "00" + Four;
                    else if (Four.Length == 3)
                        Four = "0" + Four;

                    File.Move(source, TargetFolder + "\\" + NewName + "_" + Four + Extension);
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
