using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ka
{
    internal class Program
    {
        /*
         * ka://have_you_seen_this_man
         * */

        [STAThread]
        static void Main(string[] args)
        {
            string message = "No Arguments Found ";
            //System.Diagnostics.Debugger.Launch();
                
            if (args != null && args.Length > 0)
            {
                message = string.Join("\n", args);

                Console.WriteLine("Dummy: Acesssing USB");
                Thread.Sleep(1000);

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                       // Process.Start(fileName);
                    }
                    Console.WriteLine("Dummy: Accessing File" + string.Join(", ", openFileDialog.FileNames));
                    Thread.Sleep(1000);
                    Console.WriteLine("Dummy: Encrypting File");
                    Thread.Sleep(1000);
                    Console.WriteLine("Dummy: Submitting File to server using "+ args[0]);
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Dummy: Unable to acccess File");
                }
               
            }
           // System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
