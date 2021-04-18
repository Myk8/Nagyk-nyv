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

namespace Nagykönyv
{
    public partial class FrmKonyv : Form
    {
        private readonly SqlConnection _connectionString;
        private readonly bool rogzit;
        private readonly KonyvModel konyv;
        private Dictionary<string, int> szerzok;
        public FrmKonyv(SqlConnection connectionString, bool rogzit, KonyvModel konyv)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.rogzit = rogzit;
            this.konyv = konyv;
        }

        private void FrmKonyv_Load(object sender, EventArgs e)
        {

            _connectionString.Open();
            var result = new SqlCommand("select * from szerzo order by Id; ", _connectionString).ExecuteReader();

            szerzok = new Dictionary<string, int>();

            while (result.Read())
            {
                szerzok.Add(result.GetString(1), result.GetInt32(0));
            }
            _connectionString.Close();
            result.Close();

            szerzo.DataSource = new BindingSource(szerzok, null);
            szerzo.DisplayMember = "Key";
            szerzo.ValueMember = "Value";


            if (rogzit)
            {
                mod.Enabled = false;
                mod.Enabled = false;
            }
            else
            {
               rog.Enabled = false;
                id.Text = konyv.Id.ToString();
                cim.Text = konyv.Cim;
                helyezes.Text = konyv.Helyezes.ToString();
                szerzo.SelectedIndex = szerzo.FindStringExact(szerzok.FirstOrDefault(szerzo => szerzo.Value == konyv.SzerzoId).Key);

            }
        }

        private void rog_Click(object sender, EventArgs e)
        {
            if (megerosites("rogziteni"))
            {
                if (ellenorzesSikeres())
                {
                    _connectionString.Open();
                    string query = $"Insert into konyv values ({id.Text},'{cim.Text}', {szerzo.SelectedValue}, {helyezes.Text}) ;";
                    var insertCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                    _connectionString.Close();
                    this.Close();
                }





            }
        }

        private bool ellenorzesSikeres()
        {
            if (id.Text.Trim().Length == 0 || !int.TryParse(id.Text.Trim(), out int num))
            {
                helyezes.Text = "hibas Id";
                return false;
            }

            if (cim.Text.Trim().Length == 0)
            {
                cim.Text = "hianyos cim";
                return false;
            }

            if (helyezes.Text.Trim().Length == 0 || !int.TryParse(helyezes.Text.Trim(), out int num2))
            {
                helyezes.Text = "hibas helyezes";
                return false;
            }

            if (szerzo.Text.Trim().Length == 0)
            {
                return false;
            }

            return true;
        }

        private bool megerosites(string gombNev)
        {

            var res = MessageBox.Show(
                "Biztos vagy benne , hogy " + gombNev + " szeretnel?",
                "negerosites",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
            if (res == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (megerosites("modositani"))
            {
                if (ellenorzesSikeres())
                {
                    _connectionString.Open();
                    string query = $"update konyv set  id = {id.Text}, cim = '{cim.Text}',  szerzoId = {szerzo.SelectedValue}, helyezes = {helyezes.Text} where id = {id.Text};";
                    //MessageBox.Show(query);
                    var updateCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                    _connectionString.Close();
                    this.Close();
                }
            }

        }

        private void tor_Click(object sender, EventArgs e)
        {
            if (megerosites("torolni"))
            {

                _connectionString.Open();
                string query = $"delete from konyv where id = {id.Text};";
                //MessageBox.Show(query);
                var updateCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                _connectionString.Close();
                this.Close();
            }
        }
    }


}
