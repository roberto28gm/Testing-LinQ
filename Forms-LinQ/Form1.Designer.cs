
namespace Forms_LinQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_averageScore = new System.Windows.Forms.Label();
            this.lbl_maxScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_totalPlayers = new System.Windows.Forms.Label();
            this.btn_orderName = new System.Windows.Forms.Button();
            this.btn_orderScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_orderName);
            this.groupBox1.Controls.Add(this.btn_orderScore);
            this.groupBox1.Location = new System.Drawing.Point(373, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // lbl_averageScore
            // 
            this.lbl_averageScore.AutoSize = true;
            this.lbl_averageScore.Location = new System.Drawing.Point(6, 49);
            this.lbl_averageScore.Name = "lbl_averageScore";
            this.lbl_averageScore.Size = new System.Drawing.Size(85, 15);
            this.lbl_averageScore.TabIndex = 5;
            this.lbl_averageScore.Text = "Average Score:";
            // 
            // lbl_maxScore
            // 
            this.lbl_maxScore.AutoSize = true;
            this.lbl_maxScore.Location = new System.Drawing.Point(6, 34);
            this.lbl_maxScore.Name = "lbl_maxScore";
            this.lbl_maxScore.Size = new System.Drawing.Size(78, 15);
            this.lbl_maxScore.TabIndex = 4;
            this.lbl_maxScore.Text = "Higher Score:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_totalPlayers
            // 
            this.lbl_totalPlayers.AutoSize = true;
            this.lbl_totalPlayers.Location = new System.Drawing.Point(6, 19);
            this.lbl_totalPlayers.Name = "lbl_totalPlayers";
            this.lbl_totalPlayers.Size = new System.Drawing.Size(75, 15);
            this.lbl_totalPlayers.TabIndex = 2;
            this.lbl_totalPlayers.Text = "Total Players:";
            // 
            // btn_orderName
            // 
            this.btn_orderName.Location = new System.Drawing.Point(6, 51);
            this.btn_orderName.Name = "btn_orderName";
            this.btn_orderName.Size = new System.Drawing.Size(150, 23);
            this.btn_orderName.TabIndex = 1;
            this.btn_orderName.Text = "Order by Name";
            this.btn_orderName.UseVisualStyleBackColor = true;
            this.btn_orderName.Click += new System.EventHandler(this.btn_orderName_Click);
            // 
            // btn_orderScore
            // 
            this.btn_orderScore.Location = new System.Drawing.Point(6, 22);
            this.btn_orderScore.Name = "btn_orderScore";
            this.btn_orderScore.Size = new System.Drawing.Size(150, 23);
            this.btn_orderScore.TabIndex = 0;
            this.btn_orderScore.Text = "Order by Score";
            this.btn_orderScore.UseVisualStyleBackColor = true;
            this.btn_orderScore.Click += new System.EventHandler(this.btn_orderScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(364, 433);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_totalPlayers);
            this.groupBox2.Controls.Add(this.lbl_averageScore);
            this.groupBox2.Controls.Add(this.lbl_maxScore);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Player Score LinQ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_orderScore;
        private System.Windows.Forms.Button btn_orderName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbl_totalPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_maxScore;
        private System.Windows.Forms.Label lbl_averageScore;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

