using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace BugTracker
{
    
    public partial class Form1 : Form
    {
        SqlCeConnection mySqlConnection;
        
        public Form1()
        {
            InitializeComponent();
            connectToDatabase();
        }

        public void connectToDatabase()
        {
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\University\Adv Software Engineering\Bug Tracker\BugTracker\BugTracker\BugDatabase.mdf");
            String selcmd = "SELECT BugID, LineStart, LineEnd, ProgrammerName, ClassName, MethodName, TimeSubmitted, ProjectName, Description FROM dbo ORDER BY TimeSubmitted";
            SqlCeCommand mySqlCommand = new SqlCeCommand(selcmd, mySqlConnection);

        }
        public void populateListBox()
        {
            //this is all code from the tutorial guide to connect to a database, it has been modified with differant command strings to suit this program.
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\University\Adv Software Engineering\Bug Tracker\BugTracker\BugTracker\BugDatabase.mdf");
            String selcmd = "SELECT BugID, LineStart, LineEnd, ProgrammerName, ClassName, MethodName, TimeSubmitted, ProjectName, Description FROM dbo ORDER BY TimeSubmitted";
            SqlCeCommand mySqlCommand = new SqlCeCommand(selcmd, mySqlConnection);
           /*ry
            {
                mySqlConnection.Open();
                SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                bugsLB.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    bugsLB.Items.Add(mySqlDataReader["BugID"] + " " + mySqlDataReader["LineStart"] + mySqlDataReader["LineEnd"] + mySqlDataReader["ProgrammerName"] + mySqlDataReader["ClassName"] + mySqlDataReader["MethodName"]
                        +mySqlDataReader["TimeSubmitted"]+ mySqlDataReader["ProjectName"]+mySqlDataReader["Description"]);
                }
            }
            catch(SqlCeException ex)
            {
                //MessageBox.Show(ID + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            
        }

        public void clearTxtBoxes()
        {
            nameTB.Text = bugDescTB.Text = bugLineTb.Text = bugLineEndTB.Text = nameTB.Text = classTB.Text = methodTB.Text = ""; 
        }

        public bool checkForInput()
        {
            bool rtnValue = true;
            if(string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(bugDescTB.Text) || string.IsNullOrEmpty(bugLineTb.Text) || string.IsNullOrEmpty(bugLineEndTB.Text) |
                string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(classTB.Text) || string.IsNullOrEmpty(methodTB.Text))
            {
                MessageBox.Show("Please complete all fields before submitting!");
                //Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtnValue = false;
            }
            return (rtnValue);
        }

        public void insertRecord(String Name, String lineStart, String lineEnd, String theClass, String theMethod, String theDesc, String progName, String cmdString)
        {
            try
            {
                SqlCeCommand cmdInsert = new SqlCeCommand(cmdString, mySqlConnection);
               
                cmdInsert.Parameters.AddWithValue("@LineStart", lineStart);
                cmdInsert.Parameters.AddWithValue("@LineEnd", lineEnd);
                cmdInsert.Parameters.AddWithValue("@ProgrammerName", Name);
                cmdInsert.Parameters.AddWithValue("@ClassName", theClass);
                cmdInsert.Parameters.AddWithValue("@MethodName", theMethod);
                cmdInsert.Parameters.AddWithValue("@ProjectName", progName);
                cmdInsert.Parameters.AddWithValue("@TimeSubmitted", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@Fixed", false);
                cmdInsert.ExecuteNonQuery();
            }

            catch (SqlCeException ex)
            {
               MessageBox.Show(Name + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugDatabaseDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.bugDatabaseDataSet.Bugs);

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (checkForInput())
            {
               //String cmdString = 
               insertRecord(nameTB.Text, bugLineTb.Text, bugLineEndTB.Text, classTB.Text, bugDescTB.Text, projNameTb.Text,cmdString);
               clearTxtBoxes();
            }
        }

        private void bugsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugDatabaseDataSet);

        }
    }
}
