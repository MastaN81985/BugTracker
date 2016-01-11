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

namespace BugTracker
{
    public partial class Form1 : Form
    {
        SqlCeConnection mySqlConnection;
        public Form1()
        {
            InitializeComponent();
            populateListBox();
        }

        public void populateListBox()
        {
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\UNIVERSITY\ADV SOFTWARE ENGINEERING\BUG TRACKER\BUGTRACKER\BUGTRACKER\BUGDATABASE.MDF");
            String selcmd = "SELECT BugID, LineStart, LineEnd, ProgrammerName, ClassName, MethodName, TimeSubmitted, ProjectName, Description FROM dbo ORDER BY BugID";
            SqlCeCommand mySqlCommand = new SqlCeCommand(selcmd, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                bugsLB.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    bugsLB.Items.Add(mySqlDataReader["BugID"] + " " + mySqlDataReader["LineStart"]);
                }
            }
            catch(SqlCeException ex)
            {
                //MessageBox.Show(ID + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cmdInsert.Parameters.AddWithValue("@ProgrammerName", progName);
                cmdInsert.Parameters.AddWithValue("@ClassName", theClass);
                cmdInsert.Parameters.AddWithValue("@MethodName", theMethod);
                cmdInsert.Parameters.AddWithValue("@ProjectName", progName);
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

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (checkForInput())
            {
                String commandString = "INSERT INTO dbo(BugID, LineStart, LineEnd, ProgrammerName, ClassName,MethodName,ProjectName,Description) VALUES (@BugID, @LineStart, @LineEnd, @ProgrammerName, @ClassName, @MethodName, @ProjectName)";
                insertRecord(nameTB.Text, bugLineTb.Text, bugLineEndTB.Text, classTB.Text, methodTB.Text, projNameTb.Text,bugDescTB.Text, commandString);
                populateListBox();
                clearTxtBoxes();
            }
        }
    }
}
