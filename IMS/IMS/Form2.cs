using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace IMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string myconnstrng = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\IMS_DB.accdb";

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IMS_DBDataSet.person_tbl' table. You can move, or remove it, as needed.
            //this.person_tblTableAdapter.Fill(this.IMS_DBDataSet.person_tbl);

            this.reportViewer1.RefreshReport();

            //Creating database connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            conn.Open();
            string sql = "SELECT * FROM person_tbl ORDER BY DateCreated DESC";
            OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

            conn.Close();
            this.reportViewer1.RefreshReport();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            //Creating database connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            if (filterby.Text == "Keyword")
            {
                conn.Open();
                string sql = "SELECT * FROM person_tbl WHERE FullName LIKE '%" + keyword.Text + "%' OR Nationality LIKE '%" + keyword.Text + "%' ORDER BY DateCreated DESC";
                OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                ada.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

                conn.Close();
            }
            else if (filterby.Text == "Date")
            {

                DateTime fromdate = DateTime.Parse(fromDate.Text);
                DateTime todate = DateTime.Parse(toDate.Text);

                conn.Open();

                string sql = "SELECT * FROM person_tbl WHERE DateCreated BETWEEN '" + fromdate.ToString("M/d/yyyy") + "' AND '" + todate.ToString("M/d/yyyy") + "' ORDER BY DateCreated DESC ";
                //string sql = "SELECT * FROM person_tbl WHERE DateCreated >= '" + fromdate.ToString("M/d/yyyy") + "' AND DateCreated <= '" + todate.ToString("M/d/yyyy") + "' ORDER BY DateCreated DESC ";
                //MessageBox.Show(sql);
                OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();

                conn.Close();
            }
            else
            {
                MessageBox.Show("You need to select a filter option to filter by!");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            filterby.Text = "";
            keyword.Text = "";
            fromDate.Text = "";
            toDate.Text = "";

            //Creating database connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            conn.Open();
            string sql = "SELECT * FROM person_tbl ORDER BY DateCreated DESC";
            OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

            conn.Close();
        }
    }
}
