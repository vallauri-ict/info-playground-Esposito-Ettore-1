using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _01_12_EsercizioStoredProcedure
{
    public partial class FormStorico : Form
    {
        const string CONSTR = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\informatica\\5 superiore\\informatica\\info playground\\01_12_EsercizioStoredProcedure\\Piloti.mdf\";Integrated Security=True;Connect Timeout=30";

        public FormStorico()
        {
            InitializeComponent();
        }

        private void btnVisAgg_Click(object sender, EventArgs e)
        {
            DateTime date = txtDataAgg.Value;
            DataTable agg = GetStorico("VisStoricoAggiornamenti", date);

            dgvAgg.DataSource = agg;
            dgvAgg.AutoResizeColumns();
        }

        private void btnVisCan_Click(object sender, EventArgs e)
        {
            DateTime date = txtDataCan.Value;
            DataTable can = GetStorico("VisStoricoCancellazioni", date);

            dgvCan.DataSource = can;
            dgvCan.AutoResizeColumns();
        }

        private DataTable GetStorico(string procedure, DateTime date)
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            using (SqlCommand cmd = new SqlCommand("EXEC " + procedure + " " + date.Day + ", " + date.Month + ", " + date.Year, con))
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