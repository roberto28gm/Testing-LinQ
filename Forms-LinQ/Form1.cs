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
        private PlayerList playerList;
        private bool scoreDesc = false;
        private bool nameDesc = false;
        private int totalPlayers = 0;
        private int higherScore = 0;
        private float averageScore = 0;


        public Form1()
        {
            InitializeComponent();
            string playerData = getJsonStr();

            try
            {
                playerList = JsonSerializer.Deserialize<PlayerList>(playerData);
                var binding = new BindingList<Player>(playerList.players);
                bindingSource1.DataSource = binding;
                dataGridView1.DataSource = bindingSource1;

                // Count and update label Current players
                totalPlayers = playerList.players.Count();
                lbl_totalPlayers.Text = $"Current Players: {totalPlayers}";

                // Calculate max and average score
                higherScore = playerList.players.Max(player => player.score);
                averageScore = (float)playerList.players.Average(player => player.score);
                lbl_maxScore.Text = $"Higher Score: {higherScore}";
                lbl_averageScore.Text = $"Average Score: {averageScore.ToString("0.00")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_orderScore_Click(object sender, EventArgs e)
        {
            if (scoreDesc)
            {
                bindingSource1.DataSource = playerList.players.OrderByDescending(player => player.score);
                this.scoreDesc = false;
            }
            else
            {
                bindingSource1.DataSource = playerList.players.OrderBy(player => player.score);
                this.scoreDesc = true;
            }
            
        }

        private void btn_orderName_Click(object sender, EventArgs e)
        {
            if (nameDesc)
            {
                bindingSource1.DataSource = playerList.players.OrderByDescending(player => player.name);
                this.nameDesc = false;
            }
            else
            {
                bindingSource1.DataSource = playerList.players.OrderBy(player => player.name);
                this.nameDesc = true;
            }
            
        }

        private string getJsonStr()
        {
            string json;
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                using (StreamReader r = new StreamReader(path + "\\playerData.json"))
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

        private void updatePlayerList()
        {
            string playerData = getJsonStr();
            this.playerList = JsonSerializer.Deserialize<PlayerList>(playerData);
            var binding = new BindingList<Player>(this.playerList.players);
            bindingSource1.DataSource = binding;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_CreatePLayer CreatePlayerForm  = new frm_CreatePLayer();
            CreatePlayerForm.Show();
            CreatePlayerForm.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frm_CreatePLayer frmCreatePlayer = (frm_CreatePLayer)sender;
            updatePlayerList();
        }

    }
}
