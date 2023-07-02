using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;

namespace PhoneBook
{
    public partial class PhoneBook : Form
    {
        string DBFileName = "PhoneBook_DataBase.db";
        string DBFileNamePath = @"URI=File:" + Application.StartupPath + "\\PhoneBook_DataBase.db";

        private void Create_DataBaseFile()
        {
            if(System.IO.File.Exists(DBFileName)==false)
            {
                SQLiteConnection.CreateFile(DBFileName);

                using (var SQLLite = new SQLiteConnection(@"Data Source=" + DBFileName))
                {
                    SQLLite.Open();
                    string SQLQueryText = "create table PhoneBookData(FirstName varchar(30), LastName varchar(30), PhoneNumber varchar(30), Email varchar(30))";

                    SQLiteCommand SQLcmd = new SQLiteCommand(SQLQueryText, SQLLite);
                    SQLcmd.ExecuteNonQuery();
                }
                   
            }
        }

        private void LoadData()
        {
            var SQLConnection = new SQLiteConnection(DBFileNamePath);
            SQLConnection.Open();

            string SQLQueryText = "SELECT * FROM PhoneBookData";
            var SQLcmd = new SQLiteCommand(SQLQueryText, SQLConnection);
            SQLiteDataReader DataReader;

            DataReader = SQLcmd.ExecuteReader();
            PhoneBookDataGrid.Rows.Clear();
            while (DataReader.Read())
            {
                PhoneBookDataGrid.Rows.Insert(0, DataReader.GetString(0), DataReader.GetString(1), DataReader.GetString(2), DataReader.GetString(3));
            }


        }

        public PhoneBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_DataBaseFile();
            LoadData();
            FillTextValues();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string FirstName_value = FirstName.Text;
            string LastName_value = LastName.Text;
            string PhoneNumber_value = PhoneNumber.Text;
            string Email_value = Email.Text;
            
            var SQLiteConnection = new SQLiteConnection(DBFileNamePath);
            SQLiteConnection.Open();
            var SQLiteCMN = new SQLiteCommand(SQLiteConnection);

            SQLiteCMN.CommandText = "INSERT INTO PhoneBookData(FirstName, LastName, PhoneNumber, Email) VALUES(@FirstName, @LastName, @PhoneNumber, @Email)";
            SQLiteCMN.Parameters.AddWithValue("@FirstName", FirstName_value);
            SQLiteCMN.Parameters.AddWithValue("@LastName", LastName_value);
            SQLiteCMN.Parameters.AddWithValue("@PhoneNumber", PhoneNumber_value);
            SQLiteCMN.Parameters.AddWithValue("@Email", Email_value);
            SQLiteCMN.ExecuteNonQuery();

            SQLiteConnection.Close();

            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string FirstName_value = FirstName.Text;
            string LastName_value = LastName.Text;
            string PhoneNumber_value = PhoneNumber.Text;
            string Email_value = Email.Text;

            var SQLiteConnection = new SQLiteConnection(DBFileNamePath);
            SQLiteConnection.Open();
            var SQLiteCMN = new SQLiteCommand(SQLiteConnection);

            SQLiteCMN.CommandText = "DELETE FROM PhoneBookData Where FirstName = @FirstName AND LastName = @LastName AND PhoneNumber = @PhoneNumber AND Email = @Email";
            SQLiteCMN.Parameters.AddWithValue("@FirstName", FirstName_value);
            SQLiteCMN.Parameters.AddWithValue("@LastName", LastName_value);
            SQLiteCMN.Parameters.AddWithValue("@PhoneNumber", PhoneNumber_value);
            SQLiteCMN.Parameters.AddWithValue("@Email", Email_value);
            SQLiteCMN.ExecuteNonQuery();

            SQLiteConnection.Close();

            LoadData();
        }

      

        private void EditButton_Click(object sender, EventArgs e)
        {
            string FirstName_NewValue = FirstName.Text;
            string LastName_NewValue = LastName.Text;
            string PhoneNumber_NewValue = PhoneNumber.Text;
            string Email_NewValue = Email.Text;

            string FirstName_TargetValue = PhoneBookDataGrid.CurrentRow.Cells["FirstNamePhoneBookDataGrid"].FormattedValue.ToString();
            string LastName_TargetValue = PhoneBookDataGrid.CurrentRow.Cells["LastNamePhoneBookDataGrid"].FormattedValue.ToString();
            string PhoneNumber_TargetValue = PhoneBookDataGrid.CurrentRow.Cells["PhoneNumberPhoneBookDataGrid"].FormattedValue.ToString();
            string Email_TargetValue = PhoneBookDataGrid.CurrentRow.Cells["EmailPhoneBookDataGrid"].FormattedValue.ToString();

            var SQLiteConnection = new SQLiteConnection(DBFileNamePath);
            SQLiteConnection.Open();
            var SQLiteCMN = new SQLiteCommand(SQLiteConnection);

            SQLiteCMN.CommandText = "UPDATE PhoneBookData " +
                "SET FirstName = @FirstName_NewValue, LastName = @LastName_NewValue, PhoneNumber = @PhoneNumber_NewValue, Email = @Email_NewValue " +
                "Where FirstName = @FirstName_TargetValue AND LastName = @LastName_TargetValue AND PhoneNumber = @PhoneNumber_TargetValue AND Email = @Email_TargetValue";
            

            SQLiteCMN.Parameters.AddWithValue("@FirstName_NewValue", FirstName_NewValue);
            SQLiteCMN.Parameters.AddWithValue("@LastName_NewValue", LastName_NewValue);
            SQLiteCMN.Parameters.AddWithValue("@PhoneNumber_NewValue", PhoneNumber_NewValue);
            SQLiteCMN.Parameters.AddWithValue("@Email_NewValue", Email_NewValue);

            SQLiteCMN.Parameters.AddWithValue("@FirstName_TargetValue", FirstName_TargetValue);
            SQLiteCMN.Parameters.AddWithValue("@LastName_TargetValue", LastName_TargetValue);
            SQLiteCMN.Parameters.AddWithValue("@PhoneNumber_TargetValue", PhoneNumber_TargetValue);
            SQLiteCMN.Parameters.AddWithValue("@Email_TargetValue", Email_TargetValue);

            SQLiteCMN.ExecuteNonQuery();

            SQLiteConnection.Close();

            LoadData();
        }

        private void PhoneBookDataGrid_Click(object sender, EventArgs e)
        {

            FillTextValues();

        }

        public void FillTextValues()
        {
            if(PhoneBookDataGrid.CurrentRow != null)
            {
                FirstName.Text = PhoneBookDataGrid.CurrentRow.Cells["FirstNamePhoneBookDataGrid"].FormattedValue.ToString();
                LastName.Text = PhoneBookDataGrid.CurrentRow.Cells["LastNamePhoneBookDataGrid"].FormattedValue.ToString();
                PhoneNumber.Text = PhoneBookDataGrid.CurrentRow.Cells["PhoneNumberPhoneBookDataGrid"].FormattedValue.ToString();
                Email.Text = PhoneBookDataGrid.CurrentRow.Cells["EmailPhoneBookDataGrid"].FormattedValue.ToString();
            }
           
        }

    }
}
