namespace UnderwaterRover
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabTcpIp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPortTcpIp = new System.Windows.Forms.TextBox();
            this.TbIpSousMarin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnConnexionIP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbIpSousMarinUDP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnBackward = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TabTcpIp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabTcpIp
            // 
            this.TabTcpIp.Controls.Add(this.tabPage1);
            this.TabTcpIp.Controls.Add(this.tabPage2);
            this.TabTcpIp.Controls.Add(this.tabPage3);
            this.TabTcpIp.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabTcpIp.Location = new System.Drawing.Point(0, 0);
            this.TabTcpIp.Margin = new System.Windows.Forms.Padding(2);
            this.TabTcpIp.Name = "TabTcpIp";
            this.TabTcpIp.SelectedIndex = 0;
            this.TabTcpIp.Size = new System.Drawing.Size(778, 84);
            this.TabTcpIp.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbPortTcpIp);
            this.tabPage1.Controls.Add(this.TbIpSousMarin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(770, 58);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Port TCP/IP du sous-marin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP du sous-marin";
            // 
            // tbPortTcpIp
            // 
            this.tbPortTcpIp.Location = new System.Drawing.Point(148, 32);
            this.tbPortTcpIp.Margin = new System.Windows.Forms.Padding(2);
            this.tbPortTcpIp.Name = "tbPortTcpIp";
            this.tbPortTcpIp.Size = new System.Drawing.Size(76, 20);
            this.tbPortTcpIp.TabIndex = 17;
            // 
            // TbIpSousMarin
            // 
            this.TbIpSousMarin.Location = new System.Drawing.Point(148, 8);
            this.TbIpSousMarin.Margin = new System.Windows.Forms.Padding(2);
            this.TbIpSousMarin.Name = "TbIpSousMarin";
            this.TbIpSousMarin.Size = new System.Drawing.Size(76, 20);
            this.TbIpSousMarin.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnConnexion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(770, 58);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Port série";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(123, 15);
            this.BtnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(80, 19);
            this.BtnConnexion.TabIndex = 21;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.BtnConnexionIP);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.TbIpSousMarinUDP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 58);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UDP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnConnexionIP
            // 
            this.BtnConnexionIP.Location = new System.Drawing.Point(280, 15);
            this.BtnConnexionIP.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConnexionIP.Name = "BtnConnexionIP";
            this.BtnConnexionIP.Size = new System.Drawing.Size(86, 26);
            this.BtnConnexionIP.TabIndex = 21;
            this.BtnConnexionIP.Text = "start";
            this.BtnConnexionIP.UseVisualStyleBackColor = true;
            this.BtnConnexionIP.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "IP du sous-marin";
            // 
            // TbIpSousMarinUDP
            // 
            this.TbIpSousMarinUDP.Location = new System.Drawing.Point(154, 19);
            this.TbIpSousMarinUDP.Margin = new System.Windows.Forms.Padding(2);
            this.TbIpSousMarinUDP.Name = "TbIpSousMarinUDP";
            this.TbIpSousMarinUDP.Size = new System.Drawing.Size(86, 20);
            this.TbIpSousMarinUDP.TabIndex = 19;
            this.TbIpSousMarinUDP.Text = "10.20.2.158";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 924);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(778, 0);
            this.flowLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 446F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 576);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 348);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 344);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnUp, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnDown, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(122, 333);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // BtnUp
            // 
            this.BtnUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUp.Location = new System.Drawing.Point(2, 127);
            this.BtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(118, 36);
            this.BtnUp.TabIndex = 24;
            this.BtnUp.Text = "UP";
            this.BtnUp.UseVisualStyleBackColor = true;
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(2, 168);
            this.BtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(118, 36);
            this.BtnDown.TabIndex = 24;
            this.BtnDown.Text = "DOWN";
            this.BtnDown.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.BtnForward, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBackward, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnLeft, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(128, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 333);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // BtnForward
            // 
            this.BtnForward.AutoSize = true;
            this.BtnForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnForward.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
            this.BtnForward.Location = new System.Drawing.Point(102, 2);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(2);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(96, 105);
            this.BtnForward.TabIndex = 21;
            this.BtnForward.Text = "8";
            this.BtnForward.UseVisualStyleBackColor = true;
            // 
            // BtnRight
            // 
            this.BtnRight.AutoSize = true;
            this.BtnRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRight.Image = global::UnderwaterRover.Properties.Resources.fleche_droite;
            this.BtnRight.Location = new System.Drawing.Point(202, 111);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(104, 105);
            this.BtnRight.TabIndex = 17;
            this.BtnRight.Text = "6";
            this.BtnRight.UseVisualStyleBackColor = true;
            // 
            // BtnBackward
            // 
            this.BtnBackward.AutoSize = true;
            this.BtnBackward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBackward.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackward.Image")));
            this.BtnBackward.Location = new System.Drawing.Point(102, 220);
            this.BtnBackward.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackward.Name = "BtnBackward";
            this.BtnBackward.Size = new System.Drawing.Size(96, 111);
            this.BtnBackward.TabIndex = 20;
            this.BtnBackward.Text = "2";
            this.BtnBackward.UseVisualStyleBackColor = true;
            // 
            // BtnLeft
            // 
            this.BtnLeft.AutoSize = true;
            this.BtnLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLeft.Image = global::UnderwaterRover.Properties.Resources.fleche_gauche;
            this.BtnLeft.Location = new System.Drawing.Point(2, 111);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(96, 105);
            this.BtnLeft.TabIndex = 30;
            this.BtnLeft.Text = "4";
            this.BtnLeft.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UnderwaterRover.Properties.Resources.noir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 840);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 924);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.TabTcpIp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabTcpIp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabTcpIp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPortTcpIp;
        private System.Windows.Forms.TextBox TbIpSousMarin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnConnexionIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbIpSousMarinUDP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnBackward;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

