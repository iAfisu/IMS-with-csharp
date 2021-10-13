using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string myconnstrng = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\IMS_DB.accdb";

        //Selecting Data from Database
        public DataTable Select()
        {
            //Step 1: Database Connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM person_tbl ORDER BY ID DESC";

                //Creating cmd using sql and conn
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                //Open Connection
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load data on data gridview
            DataTable dt = Select();
            dgvList.DataSource = dt;
        }

        private void memberstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberstate.Text == "Ecowas")
            {
                nationality.Items.Clear();
                fee.Items.Clear();
                nationality.Items.AddRange(new string[] { "Benin", "Burkina Faso", "Cabo Verde", "Cote d’Ivoire", "Gambia", "Ghana", "Guinea", "Guinea - Bissau", "Liberia", "Mali", "Niger", "Nigeria", "Senegal", "Sierra Leone", "Togo" });
                fee.Items.AddRange(new string[] { "150" });
            }
            else
            {
                nationality.Items.Clear();
                fee.Items.Clear();
                nationality.Items.AddRange(new string[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", 
                    "Barbados", "Belarus", "Belgium", "Belize", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burundi", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", 
                    "Chile", "China", "Colombia", "Comoros", "Congo (Congo-Brazzaville)", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czechia (Czech Republic)", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", 
                    "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini (fmr. Swaziland)", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Georgia", "Germany", "Greece", 
                    "Grenada", "Guatemala", "Guyana", "Haiti", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati",
                    "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Malta", "Marshall", "Islands", "Mauritania", "Mauritius", 
                    "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (formerly Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "North Korea", "North Macedonia", 
                    "Norway", "Oman", "Pakistan", "Palau", "Palestine State", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", 
                    "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Serbia", "Seychelles", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", 
                    "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", 
                    "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States of America", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
                fee.Items.AddRange(new string[] { "200" });
            }
        }

        private void dgvList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from Datagridview and load it into their various textboxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            id.Text = dgvList.Rows[rowIndex].Cells[0].Value.ToString();
            fullname.Text = dgvList.Rows[rowIndex].Cells[1].Value.ToString();
            dateofbirth.Text = dgvList.Rows[rowIndex].Cells[2].Value.ToString();
            sex.Text = dgvList.Rows[rowIndex].Cells[3].Value.ToString();
            memberstate.Text = dgvList.Rows[rowIndex].Cells[4].Value.ToString();
            nationality.Text = dgvList.Rows[rowIndex].Cells[5].Value.ToString();
            school.Text = dgvList.Rows[rowIndex].Cells[6].Value.ToString();
            typeofpermit.Text = dgvList.Rows[rowIndex].Cells[7].Value.ToString();
            fee.Text = dgvList.Rows[rowIndex].Cells[8].Value.ToString();
            passportno.Text = dgvList.Rows[rowIndex].Cells[9].Value.ToString();
            placeofissue.Text = dgvList.Rows[rowIndex].Cells[10].Value.ToString();
            dateofissue.Text = dgvList.Rows[rowIndex].Cells[11].Value.ToString();
            dateofexpiry.Text = dgvList.Rows[rowIndex].Cells[12].Value.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Step 1: Create Database Connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {
                if (fullname.Text == "" || dateofbirth.Text == "" || sex.Text == "" || memberstate.Text == "" || nationality.Text == "" || school.Text == "" || typeofpermit.Text == "" || fee.Text == "" || passportno.Text == "" || placeofissue.Text == "" || dateofissue.Text == "" || dateofexpiry.Text == "")
                {
                    MessageBox.Show("All the fields are mandatory");
                }
                else
                {
                    //Step 2: Create an SQL Query to Insert Data
                    string sql = "INSERT INTO person_tbl (FullName, DateOfBirth, Sex, MemberState, Nationality, School, TypeOfPermit, Fee, PassportNo, PlaceOfIssue, DateOfIssue, DateOfExpiry, DayCreated, MonthCreated, YearCreated, DateCreated, DateModified) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

                    //Creating SQL Command using sql and conn
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@FullName", fullname.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth.Text);
                    cmd.Parameters.AddWithValue("@Sex", sex.Text);
                    cmd.Parameters.AddWithValue("@MemberState", memberstate.Text);
                    cmd.Parameters.AddWithValue("@Nationality", nationality.Text);
                    cmd.Parameters.AddWithValue("@School", school.Text);
                    cmd.Parameters.AddWithValue("@TypeOfPermit", typeofpermit.Text);
                    cmd.Parameters.AddWithValue("@Fee", fee.Text);
                    cmd.Parameters.AddWithValue("@PassportNo", passportno.Text);
                    cmd.Parameters.AddWithValue("@PlaceOfIssue", placeofissue.Text);
                    cmd.Parameters.AddWithValue("@DateOfIssue", dateofissue.Text);
                    cmd.Parameters.AddWithValue("@DateOfExpiry", dateofexpiry.Text);
                    cmd.Parameters.AddWithValue("@DayCreated", DateTime.Today.Day.ToString());
                    cmd.Parameters.AddWithValue("@MonthCreated", DateTime.Today.Month.ToString());
                    cmd.Parameters.AddWithValue("@YearCreated", DateTime.Today.Year.ToString());
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Today.ToString("M/d/yyyy"));
                    cmd.Parameters.AddWithValue("@DateModified", DateTime.Today.ToString("M/d/yyyy"));

                    //Open Connection
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if(rows > 0)
                    {
                        //Success Message
                        MessageBox.Show("Record Save Successfully");

                        Clear();
                    }
                    else
                    {
                        //Failure Message
                        MessageBox.Show("Failed to save new record. Try again.");
                    }

                    //Load data on data gridview
                    DataTable dt = Select();
                    dgvList.DataSource = dt;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
           
        }

        //Clear all fields
        public void Clear()
        {
            id.Text = "";
            fullname.Text = "";
            dateofbirth.Text = "";
            sex.Text = "";
            memberstate.Text = "";
            nationality.Text = "";
            school.Text = "";
            typeofpermit.Text = "";
            fee.Text = "";
            passportno.Text = "";
            placeofissue.Text = "";
            dateofissue.Text = "";
            dateofexpiry.Text = "";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void update_Click(object sender, EventArgs e)
        {
            //Step 1: Create Database Connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {
                if (fullname.Text == "" || dateofbirth.Text == "" || sex.Text == "" || memberstate.Text == "" || nationality.Text == "" || school.Text == "" || typeofpermit.Text == "" || fee.Text == "" || passportno.Text == "" || placeofissue.Text == "" || dateofissue.Text == "" || dateofexpiry.Text == "")
                {
                    MessageBox.Show("All the fields are mandatory");
                }
                else
                {
                    //Step 2: Create an SQL Query to update Data
                    string sql = "UPDATE person_tbl SET FullName = '" + fullname.Text + "', DateOfBirth = '" + dateofbirth.Text + "', Sex = '" + sex.Text + "', MemberState = '" + memberstate.Text + "', Nationality = '" + nationality.Text + "', School = '" + school.Text + "', TypeOfPermit = '" + typeofpermit.Text + "', Fee = '" + fee.Text + "', PassportNo = '" + passportno.Text + "', PlaceOfIssue = '" + placeofissue.Text + "', DateOfIssue = '" + dateofissue.Text + "', DateOfExpiry = '" + dateofexpiry.Text + "', DateModified = '" + DateTime.Today.ToString("M/d/yyyy") + "' WHERE ID = "+int.Parse(id.Text)+"";
                    //MessageBox.Show(sql);

                    //Creating SQL Command using sql and conn
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    //cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));
                    //cmd.Parameters.AddWithValue("@FullName", fullname.Text);
                    //cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth.Text);
                    //cmd.Parameters.AddWithValue("@Sex", sex.Text);
                    //cmd.Parameters.AddWithValue("@MemberState", memberstate.Text);
                    //cmd.Parameters.AddWithValue("@Nationality", nationality.Text);
                    //cmd.Parameters.AddWithValue("@School", school.Text);
                    //cmd.Parameters.AddWithValue("@TypeOfPermit", typeofpermit.Text);
                    //cmd.Parameters.AddWithValue("@Fee", fee.Text);
                    //cmd.Parameters.AddWithValue("@PassportNo", passportno.Text);
                    //cmd.Parameters.AddWithValue("@PlaceOfIssue", placeofissue.Text);
                    //cmd.Parameters.AddWithValue("@DateOfIssue", dateofissue.Text);
                    //cmd.Parameters.AddWithValue("@DateOfExpiry", dateofexpiry.Text);
                    //cmd.Parameters.AddWithValue("@DateModified", DateTime.Today.ToString("M/d/yyyy"));

                    //Open Connection
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        //Success Message
                        MessageBox.Show("Record Updated Successfully");
                        Clear();
                    }
                    else
                    {
                        //Failure Message
                        MessageBox.Show("Failed to Update Record. Try again.");
                    }

                    //Load data on data gridview
                    DataTable dt = Select();
                    dgvList.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Create database connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            try
            {
                //SQL to update data in our Database
                string sql = "DELETE FROM person_tbl WHERE ID="+int.Parse(id.Text)+"";
                //MessageBox.Show(sql);

                //Creating SQL Command
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                //Create Parameters to add values
                //cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));

                //Open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if rows > 0 else equal to zero
                if (rows > 0)
                {
                    //Success Message
                    MessageBox.Show("Record Deleted Successfully");

                    //Clear input fields
                    Clear();
                }
                else
                {
                    //Failure Message
                    MessageBox.Show("Failed to Delete Record. Try again.");
                }

                //Load data on data gridview
                DataTable dt = Select();
                dgvList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
        }

        private void genreport_Click(object sender, EventArgs e)
        {
            //Show report form
            Form2 reportForm = new Form2();
            reportForm.Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            //Get search value from search field
            string keyword = search.Text;

            //Creating database connection
            OleDbConnection conn = new OleDbConnection(myconnstrng);

            //SQL statement
            string sql = "SELECT * FROM person_tbl WHERE FullName LIKE '%" + keyword + "%' OR Sex LIKE '%" + keyword + "%' OR MemberState LIKE '%" + keyword + "%' OR Nationality LIKE '%" + keyword + "%'";
            OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            dgvList.DataSource = dt;
        }

    }
}
