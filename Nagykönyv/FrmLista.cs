using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace Nagykönyv
{
    public partial class FrmLista : Form
    {
        public static SqlConnection connectionString;
        public FrmLista()
        {
            AppDomain.CurrentDomain.SetData(
               "DataDirectory",
               Path.GetDirectoryName(
                   Assembly.GetExecutingAssembly()
                   .Location.Replace(@"bin\Debug", @"\")));
            connectionString = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nagykonyvDTS.mdf;Integrated Security=True");
            InitializeComponent();
        }

        private void FillDgv(string kereso)
        {
            konyvek.Rows.Clear();

            connectionString.Open();

            var result = new SqlCommand("select * from konyv inner join szerzo on konyv.szerzoId = szerzo.Id where cim like('%" + kereso + "%') or nev like('%" + kereso + "%') ORDER BY helyezes; ", connectionString).ExecuteReader();
            while (result.Read())
            {
               konyvek.Rows.Add(result[0], result.GetInt32(3), result.GetString(5), result.GetString(1));
            }
            result.Close();
            connectionString.Close();

        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            FillDgv("");
        }

        private void keres_TextChanged(object sender, EventArgs e)
        {
            FillDgv(keres.Text);
        }

        private void konyvek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connectionString.Open();
            var result = new SqlCommand("select * from konyv inner join szerzo on konyv.szerzoId = szerzo.Id where konyv.id = " + int.Parse(konyvek.Rows[e.RowIndex].Cells[0].Value.ToString()) + "; ", connectionString).ExecuteReader();
            result.Read();
            var konyv = new KonyvModel()
            {
                Id = result.GetInt32(0),
                Cim = result.GetString(1),
                SzerzoId = result.GetInt32(2),
                Helyezes = result.GetInt32(3)
            };
            connectionString.Close();
            result.Close();

            var frm = new FrmKonyv(connectionString, false, konyv);
            frm.ShowDialog();
        }

        private void FrmLista_Activated(object sender, EventArgs e)
        {
            FillDgv("");
        }

        private void ujKonyvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKonyv(connectionString, true, null);
            frm.ShowDialog();

        }
    }
}
