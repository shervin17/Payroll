using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public class FileEnableDownload
    {


        public string SourceFile { get; set; }
        public string filename { get; set; }
        
     
        public FileEnableDownload(string SourceFile, string filename) { 
        this.SourceFile = SourceFile;
        this.filename = filename;
        }
        public void Download() {
            string sourceFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), SourceFile);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = filename;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                // Copy the CSV file from the desktop to the chosen destination
                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show("CSV file downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        }
    }

