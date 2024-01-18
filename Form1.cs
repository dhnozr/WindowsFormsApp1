using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PhoneBook : Form

    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone");
            contacts.Columns.Add("Email");

            phoneDataGrid.DataSource = contacts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            firstNameText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[phoneDataGrid.CurrentCell.RowIndex]["First Name"] = firstNameText.Text;
                contacts.Rows[phoneDataGrid.CurrentCell.RowIndex]["Last Name"] = lastNameText.Text;
                contacts.Rows[phoneDataGrid.CurrentCell.RowIndex]["Phone"] = phoneText.Text;
                contacts.Rows[phoneDataGrid.CurrentCell.RowIndex]["Email"] = emailText.Text;
            }
            else
            {
                contacts.Rows.Add(firstNameText.Text, lastNameText.Text, phoneText.Text, emailText.Text);
            }
            firstNameText.Text = "";
            lastNameText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";

            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch
            {
                Console.WriteLine("Not a valid row");
            }
        }

        private void phoneDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            firstNameText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailText.Text = contacts.Rows[phoneDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }
    }
}
