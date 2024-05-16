using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace PayrollV1
{
    public partial class createPayrollWorkdays : Form
    {   
        PayrollPeriodRepo payrollPeriodRepo = new PayrollPeriodRepo();
        List<Payroll_Period> payrollPeriodList = new List<Payroll_Period>();
        Payroll_Period payrollPeriod;
        List<PayrollWorkDay> payrollWorkDayList = new List<PayrollWorkDay>();
        List<Workdays> workdaysList = new List<Workdays>();
        DataTable dataTable = new DataTable();
        private string sourceFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "payrollSAmpleWD.csv");
        WorkDaysRepository WorkDaysRepository = new WorkDaysRepository();
        private Payroll_Period selected;

        public createPayrollWorkdays()
        {
            InitializeComponent(); 
            dataTable.Columns.Add("payroll_period_id",typeof(int));
            dataTable.Columns.Add("date_from",typeof(DateTime));
            dataTable.Columns.Add("date_to",typeof(DateTime));
            dataTable.Columns.Add("date",typeof(DateTime));
            dataTable.Columns.Add("rate", typeof(decimal));
            dataTable.Columns.Add("comment",typeof(string));
        }

        /*private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Enter) {

                try
                {
                   
                    int payroll_period_id = int.Parse(PayrollPeriodTB.Text);
                    query = @"select * from payroll_period where payroll_period_ID=@payroll_period_ID";
                    sqlCommand = new SqlCommand(query, _connection);
                    sqlCommand.Parameters.AddWithValue("@payroll_period_ID", payroll_period_id);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateTime date_from = (DateTime)reader["date_from"];
                            DateTime date_to = (DateTime)reader["date_to"];

                            payrollPeriod = new Payroll_Period
                            {
                                Payroll_Period_ID = payroll_period_id,
                                Date_from = date_from,
                                Date_to = date_to
                            };
                        }
                        datefromTB.Text = payrollPeriod.Date_from.ToString();
                        dateToTB.Text = payrollPeriod.Date_to.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    _connection.Close();
                    
                }
            }

        }*/

        private void addRow_Click(object sender, EventArgs e)
        {    
            dataTable.Clear();
            PayrollWorkDay payrollWorkDay = new PayrollWorkDay() {
                Payroll_period_ID = payrollPeriod.Payroll_Period_ID,
                Date_from = payrollPeriod.Date_from,
                Date_to = payrollPeriod.Date_to,
                Date = DateTime.Parse(dateTB.Text),
                Rate = decimal.Parse(ratecb.Text),
                Comment= commentTB.Text,
            };
            payrollWorkDayList.Add(payrollWorkDay);
            displayAddedRows();
        }
        private void displayAddedRows() { 
                
           foreach(PayrollWorkDay p in  payrollWorkDayList)
            {
                DataRow data = dataTable.NewRow();
                data["payroll_period_id"] = p.Payroll_period_ID;
                data["date_from"] = p.Date_from;
                data["date_to"] = p.Date_to;
                data["date"] = p.Date;
                data["rate"] = p.Rate;
                data["comment"] = p.Comment;
                dataTable.Rows.Add(data);
            }

            table.DataSource = dataTable;
            
            
        }

        private void dateTB_Validating(object sender, CancelEventArgs e)
        {
            int result = DateTime.Parse(dateTB.Text).CompareTo(DateTime.Parse(datefromTB.Text));
            if (result < 0){
                errorProvider1.SetError(dateTB, "the date you've entered is earlier than payroll period");
            }
            result = DateTime.Parse(dateTB.Text).CompareTo(DateTime.Parse(dateToTB.Text));
            if (result > 0)
                errorProvider1.SetError(dateTB, "date you entered is not covered by the payroll period");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileSaver file = new FileSaver();  //this is for uploadButtondd
            table.DataSource=file.SaveFile();
        }


        private void download_Click(object sender, EventArgs e)
        {
            FileEnableDownload fileEnableDownload = new FileEnableDownload("payrollSAmpleWD.csv", "default_workdays_format.csv");
            fileEnableDownload.Download();
            //this is for downloading the csv file for workdays
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ratecb.SelectedIndex = 0;
                commentTB.Text = "Regular working day";
            }
           else if (comboBox1.SelectedIndex == 1)
            {
                ratecb.SelectedIndex = 1;
                commentTB.Text = "Regular holliday";
            }
           else if (comboBox1.SelectedIndex == 2)
            {
                ratecb.SelectedIndex = 2;
                commentTB.Text = "Special Working holliday";
            }
        }

        private void submitWorkDays_Click(object sender, EventArgs e)
        {
            workdaysList =payrollWorkDayList.Select(item => new Workdays
            {
                Payroll_period_ID= item.Payroll_period_ID,
                Date = item.Date,
                Rate = item.Rate,
                comment= item.Comment,
            }).ToList();
            
           int affectedRows= WorkDaysRepository.AddAll(workdaysList);
            if (affectedRows > 0)
            {
                payrollWorkDayList.Clear();
                dataTable.Rows.Clear();
            }
        }

        private void createPayrollWorkdays_Load(object sender, EventArgs e)
        {
            period_options.Items.Clear();
            period_options.Focus();
            payrollPeriodList = payrollPeriodRepo.findAll();
            payrollPeriodList.ForEach(element => { 
            period_options.Items.Add(element);

            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payrollWorkDayList.Clear();
            dataTable.Rows.Clear();
        }

        private void period_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index= period_options.SelectedIndex;
            selected = payrollPeriodList[selected_index];
            dateTB.Text = selected.Date_from.ToString();
            PayrollPeriodTB.Text = selected.Payroll_Period_ID.ToString();
            datefromTB.Text= selected.Date_from.ToString();
            dateToTB.Text= selected.Date_to.ToString();
        }
    }
    
    }

