using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionTest
{
    public class Replace
    {
        public static void ReplaceFile(string SourceFile, string OriginalSymbol, string NewSymbol, RichTextBox richTextBox, string TargetFolder = "")
        {
            try
            {

                if (TargetFolder != "" && !Directory.Exists(TargetFolder))
                    Directory.CreateDirectory(TargetFolder);

                using (StreamReader TR = File.OpenText(SourceFile))
                {
                    
                    string str_ReadAll = TR.ReadToEnd();
                    richTextBox.Text = Regex.Replace(str_ReadAll, OriginalSymbol, NewSymbol);
                    //richTextBox.Text = str_ReadAll.Replace(OriginalSymbol, NewSymbol);
                    TR.Dispose();
                }
                if (TargetFolder != "")
                    File.Copy(SourceFile, TargetFolder + "\\" + SourceFile );
                
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
