using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Forms_LinQ
{
    public partial class frm_CreatePLayer : Form
    {
        public frm_CreatePLayer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tbox_name.Text;
            int initialScore = int.Parse(tbox_initialScore.Text);
            Player player = new Player(name, initialScore);
            string jsonPlayer = JsonSerializer.Serialize(player);
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\playerData.json";
            string newJson;

            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    PlayerList playerList = JsonSerializer.Deserialize<PlayerList>(json);
                    playerList.players.Add(player);
                    newJson = JsonSerializer.Serialize(playerList);
                }
                File.WriteAllText(path, newJson);
                MessageBox.Show($"Player {player.name} added.");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
