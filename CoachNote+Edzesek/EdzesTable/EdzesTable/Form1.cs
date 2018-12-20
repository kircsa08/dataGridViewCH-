using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectToMysqlDatabase;

namespace EdzesTable
{
    public partial class Form1 : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable edzesekdt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewEdzesek.ReadOnly = true;
            dataGridViewEdzesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEdzesek.AllowUserToDeleteRows = false;
            Adatbazis a = new Adatbazis(); mdi = a.kapcsolodas();
            mdi.open();
            edzesekdt = mdi.getToDataTable("SELECT * FROM edzes");
            dataGridViewEdzesek.DataSource = edzesekdt;
        }
    }
}
