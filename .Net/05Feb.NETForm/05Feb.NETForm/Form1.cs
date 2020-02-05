using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Feb.NETForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petCareServicesDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.petCareServicesDataSet.Owner);
            // TODO: This line of code loads data into the 'petCareServicesDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.petCareServicesDataSet.Owner);

        }

        private void ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ownerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petCareServicesDataSet);

        }

        private void ownerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ownerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petCareServicesDataSet);

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Data Source = TIMBER2000\\SQLEXPRESS; Initial Catalog = PetCareServices; Integrated Security = True"))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("OwnerAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@LastName", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@mobile", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@notes", textBox5.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successful");
                Clear();
            }
            void Clear()
            {
                const string V = "";
                textBox5.Text = textBox5.Text = textBox5.Text = textBox5.Text = textBox5.Text = V;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
