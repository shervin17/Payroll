using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public class FileSaver
    {
        public DataTable SaveFile() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Call a method to load data from the selected CSV file into the DataGridView
               return LoadDataFromCSV(filePath);

            }
            return null;
    }
        private DataTable LoadDataFromCSV(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                try
                {
                    // Read the contents of the CSV file into a DataTable
                    DataTable dt = new DataTable();
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header);
                        }

                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            dt.Rows.Add(rows);
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
