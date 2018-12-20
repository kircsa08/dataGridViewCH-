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
        bool lettValtozas = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            betoltesutaniAllapot();
            dataGridViewEdzesek.ReadOnly = true;
            dataGridViewEdzesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEdzesek.AllowUserToDeleteRows = false;
            Adatbazis a = new Adatbazis(); mdi = a.kapcsolodas();
            mdi.open();
            edzesekdt = mdi.getToDataTable("SELECT * FROM edzes");
            dataGridViewEdzesek.DataSource = edzesekdt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BelepeskoriAllapot();
        }
        public void betoltesutaniAllapot()
        {
            buttonMegse.Visible = true;
            buttonMent.Visible = true;
            buttonModosit.Visible = true;
            buttonTorol.Visible = true;
            buttonUj.Visible = true;
            buttonMegse.Enabled = false;
            buttonMent.Enabled = false;
            buttonModosit.Enabled = true;
            buttonTorol.Enabled = true;
            buttonUj.Enabled = true;
        }
        public void modositoAllapot()
        {
            buttonMegse.Enabled = true;
            buttonMent.Enabled = true;
            buttonTorol.Enabled = false;
            buttonUj.Enabled = false;
        }
        public void BelepeskoriAllapot()
        {
            buttonMegse.Visible = false;
            buttonMent.Visible = false;
            buttonModosit.Visible = false;
            buttonTorol.Visible = false;
            buttonUj.Visible = false;
        }

        private void buttonMent_Click(object sender, EventArgs e)
        {
            if (lettValtozas)
            {
                mdi.updateChangesInTable(edzesekdt);
                buttonMent.Enabled = false;
                buttonModosit.Enabled = true;
                buttonUj.Enabled = true;
                buttonTorol.Enabled = true;
                lettValtozas = false;
            }
            else
            {
                MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonMent.Enabled = false;
            }
        }

        private void dataGridViewEdzesek_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettValtozas = true;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            modositoAllapot();
            dataGridViewEdzesek.AllowUserToAddRows = true;
            dataGridViewEdzesek.SelectionMode = DataGridViewSelectionMode.CellSelect;

            int sor = dataGridViewEdzesek.Rows.Count - 1;
            dataGridViewEdzesek.Rows[sor].Cells[1].Selected = true;
            dataGridViewEdzesek.Rows[sor].Cells[1].Value = "Írja ide az új adatot";

            dataGridViewEdzesek.ReadOnly = false;
            for (int i = 0; i < sor; i = i + 1)
            {
                dataGridViewEdzesek.Rows[i].ReadOnly = true;
            }
            dataGridViewEdzesek.FirstDisplayedScrollingRowIndex = sor;
            dataGridViewEdzesek.Columns[0].ReadOnly = true;
            lettValtozas = true;
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            if (lettValtozas)
            {
                if (MessageBox.Show("Nem mentett adatok vannak! Valóban ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }

        private void buttonTorol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    int sor = dataGridViewEdzesek.SelectedRows[0].Index;
                    dataGridViewEdzesek.Rows.RemoveAt(sor);
                    buttonMent.Enabled = true;
                    lettValtozas = true;
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void dataGridViewEdzesek_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();

            int max;
            bool siker = int.TryParse(mdiujid.executeScalarQuery("SELECT MAX(edzesid) FROM edzes"), out max);
            if (!siker)
            {
                MessageBox.Show("Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba. Új adat felvitele nem lehetséges", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mdiujid.close();

            e.Row.Cells[0].Value = max + 1;
        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            buttonUj.Enabled = true;
            buttonModosit.Enabled = true;
            buttonTorol.Enabled = true;

            dataGridViewEdzesek.ReadOnly = true;
            dataGridViewEdzesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            buttonMegse.Visible = false;

            edzesekdt = mdi.getToDataTable("SELECT * FROM vtermekek"); dataGridViewEdzesek.DataSource = edzesekdt;

            lettValtozas = false;
        }
    }
}
