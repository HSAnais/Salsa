using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salsa_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userTableDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userTableDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.userTableDataSet.User);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.userBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.userTableDataSet);
                MessageBox.Show("The Data has been saved");
                userBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(ex);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.AddNew();
                usernameTextBox.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(exception);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?");
            try
            {
                userBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(exception);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(exception);
                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(exception);
                throw;
            }
        }
    }
}
