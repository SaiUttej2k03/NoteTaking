using System.ComponentModel;
using System.Data;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        DataTable table;


        public Form2() => InitializeComponent();



        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("The Title ", typeof(String));
            table.Columns.Add("Your Message", typeof(String));

            dataGridView1.DataSource = table;
         
            dataGridView1.Columns["Title"].Width = 140;



        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle1.Clear();
            txtMessage.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle1.Text, txtMessage.Text);
            txtTitle1.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                txtTitle1.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index= dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}