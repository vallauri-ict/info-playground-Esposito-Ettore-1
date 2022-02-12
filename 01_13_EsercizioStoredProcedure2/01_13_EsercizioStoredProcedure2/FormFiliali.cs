using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _01_13_EsercizioStoredProcedure2
{
    public partial class FormFiliali : Form
    {
        const string CONSTR = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\informatica\\5 superiore\\informatica\\info playground\\01_13_EsercizioStoredProcedure2\\Banche.mdf\";Integrated Security=True;Connect Timeout=30";

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

            DataTable tot = GetTotale("EXEC Conta '" + nomeBanca + "', '" + comuneFiliale + "';");
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
            if (txtBanca.Text == "")
            {
                MessageBox.Show("Metti il nome della banca");
                return;
            }

            VediFiliali();
        }

        private DataTable GetTotale(string query)
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

        private void VediFiliali()
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                string sql = "VediFiliali";

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter nomeBanca = new SqlParameter();
                nomeBanca.ParameterName = "banca";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType = DbType.String;  // Tipo di dato nella S.P.
                nomeBanca.Size = 50;               // Dimensione del dato in caso di stringhe
                nomeBanca.Value = txtBanca.Text;
                cmd.Parameters.Add(nomeBanca);

                SqlParameter totale = new SqlParameter();
                totale.ParameterName = "totale";
                totale.Direction = ParameterDirection.Output;
                totale.DbType = DbType.Int32;
                cmd.Parameters.Add(totale);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader ris = cmd.ExecuteReader();

                if (!ris.HasRows)
                {
                    MessageBox.Show("La banca non ha filiali");
                    return;
                }

                string output = "";
                while (ris.Read())
                    output += "\n - Id: " + ris.GetInt32(0) + ", Comune " + ris.GetString(1) + ", numero: " + ris.GetInt32(2);
                ris.Close();
                MessageBox.Show("Eleco filiali (totale: " + totale.Value + "):" + output);

                con.Close();
            }
        }
    }
}