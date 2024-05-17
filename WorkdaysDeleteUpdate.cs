using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
{
    public partial class WorkdaysDeleteUpdate : Form
    {
        public static PayrollWorkDay updated_Entry { get; set; }

        public PayrollWorkDay workdays { get;set; }

        public  List<PayrollWorkDay> p_list { get; set; }

        public WorkdaysDeleteUpdate(PayrollWorkDay workdays,List<PayrollWorkDay> p_list)
        {
            InitializeComponent();
            this.workdays = workdays;  
            this.p_list = p_list;
        }

        private void WorkdaysDeleteUpdate_Load(object sender, EventArgs e)
        {
            payroll_periodTB.Text= workdays.Payroll_period_ID.ToString();
            rateTB.Text= workdays.Rate.ToString();
            dateTimePicker1.Value = workdays.Date;
            commentBox.Text = workdays.Comment;
            double rate_val = (double)workdays.Rate;
            comboBox1.Text=  rate_val== 2.0 ? "Regular Holiday": rate_val == 1 ? "Regular Working Day": rate_val == 1.3 ? 
                "Special Holiday" :null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                rateTB.Text = "1.0";
                commentBox.Text = "Regular Working Day";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                rateTB.Text = "2";
                commentBox.Text = "Regular Holiday";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                rateTB.Text = "1.3";
                commentBox.Text = "Special Holiday";
            }
        }

        private void delBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("delete?", "delete",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                int index = 0;
                int len = p_list.Count;
                p_list.ForEach(p =>
                {
                    if (p.Date.Equals(workdays.Date))
                    {
                        index= p_list.IndexOf(p);
                    }
                });
                try
                {
                    p_list.RemoveAt(index);
                    if (p_list.Count < len)
                    {
                        MessageBox.Show("deleted");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally { 
                 Dispose();
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (workdays != null)
            {
                try
                {
                    updated_Entry = new PayrollWorkDay();
                    updated_Entry.Payroll_period_ID = workdays.Payroll_period_ID;
                    updated_Entry.Date_to = workdays.Date_to;
                    updated_Entry.Date_from = workdays.Date_from;
                    updated_Entry.Date = dateTimePicker1.Value;
                    updated_Entry.Rate = decimal.Parse(rateTB.Text);
                    updated_Entry.Comment = commentBox.Text;
                    int index = 0;
                    p_list.ForEach(p =>
                    {
                        if (p.Date.Equals(workdays.Date))
                        {
                            index = p_list.IndexOf(p);
                        }
                    });
                    p_list.Insert(index, updated_Entry);
                    p_list.RemoveAt(index + 1);
                    MessageBox.Show("record updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    Dispose();
                }
            }
            
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
