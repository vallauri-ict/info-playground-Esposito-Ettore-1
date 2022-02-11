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

namespace _01_13_EsercizioStoredProcedure2
{
    public partial class FormFiliali : Form
    {
        const string CONSTR = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"S:\\informatica\\5 superiore\\informatica\\info playground\\01_13_EsercizioStoredProcedure2\\Banche.mdf\";Integrated Security=True;Connect Timeout=30";

        public FormFiliali()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            string nomeBanca = txtBanca.Text;
            string comuneFiliale = txtComune.Text;

            if(nomeBanca == "")
            {
                MessageBox.Show("Metti il nome della banca");
                return;
            }
            if (comuneFiliale == "")
            {
                MessageBox.Show("Metti il comune della filiale");
                return;
            }

            DataTable tot = GetStorico("EXEC Conta '" + nomeBanca + "', '" + comuneFiliale + "';");
            if (tot.Rows.Count == 0)
            {
                MessageBox.Show("La banca non ha filiali in quel comune");
                return;
            }

            int ris = tot.Rows[0].Field<int>("tot");
            MessageBox.Show("Totale filiali: " + ris);
        }

        private void btnVedi_Click(object sender, EventArgs e)
        {
            string nomeBanca = txtBanca.Text;

            if (nomeBanca == "")
            {
                MessageBox.Show("Metti il nome della banca");
                return;
            }

            DataTable filiali = GetStorico("EXEC VediFiliali '" + nomeBanca + "';");
            if (filiali.Rows.Count == 0)
            {
                MessageBox.Show("La banca non ha filiali");
                return;
            }

            string ris = "";
            foreach (DataRow row in filiali.Rows)
                ris += "\n - Id: " + row.Field<int>("Id") + ", Comune " + row.Field<string>("Citta") + ", numero: " + row.Field<int>("Numero");
            MessageBox.Show("Eleco filiali:" + ris);
        }

        private DataTable GetStorico(string query)
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                con.Open();
                adapter.Fill(data);
                con.Close();

                return data;
            }
        }
    }
}
