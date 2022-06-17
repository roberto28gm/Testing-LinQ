using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Reflection;

namespace Forms_LinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string playerData = getJsonStr();
            
            try
            {
                PlayerList playerList = JsonSerializer.Deserialize<PlayerList>(playerData);
                var binding = new BindingList<Player>(playerList.players);
                dataGridView1.DataSource = binding;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_orderScore_Click(object sender, EventArgs e)
        {
            // TODO order list by score
        }

        private void btn_orderName_Click(object sender, EventArgs e)
        {
            // TODO order list by name
        }

        private string getJsonStr()
        {
            string json;
            try
            {
                using (StreamReader r = new StreamReader(
                    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) +
                    "\\playerData.json"))
                {
                    json = r.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                json = null;
            }

            return json;
        }
    }
}
