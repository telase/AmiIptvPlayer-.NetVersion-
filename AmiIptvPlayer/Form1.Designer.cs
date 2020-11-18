namespace AmiIptvPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshEPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chList = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.logoChannel = new System.Windows.Forms.PictureBox();
            this.lbChName = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelvideo = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbYear = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFixId = new System.Windows.Forms.Button();
            this.logoEPG = new System.Windows.Forms.PictureBox();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStars = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitleEPG = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbVersionText = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbProcessingEPG = new System.Windows.Forms.Label();
            this.txtLoadCh = new System.Windows.Forms.TextBox();
            this.btnMuteUnmute = new System.Windows.Forms.Button();
            this.trVolumen = new System.Windows.Forms.TrackBar();
            this.cmbLangs = new System.Windows.Forms.ComboBox();
            this.cmbSubs = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnURLInfo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.refreshListToolStripMenuItem,
            this.refreshEPGToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshListToolStripMenuItem, "refreshListToolStripMenuItem");
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // refreshEPGToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshEPGToolStripMenuItem, "refreshEPGToolStripMenuItem");
            this.refreshEPGToolStripMenuItem.Name = "refreshEPGToolStripMenuItem";
            this.refreshEPGToolStripMenuItem.Click += new System.EventHandler(this.refreshEPGToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chList
            // 
            resources.ApplyResources(this.chList, "chList");
            this.chList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chName});
            this.chList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.chList.HideSelection = false;
            this.chList.Name = "chList";
            this.chList.UseCompatibleStateImageBehavior = false;
            this.chList.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // chNumber
            // 
            resources.ApplyResources(this.chNumber, "chNumber");
            // 
            // chName
            // 
            resources.ApplyResources(this.chName, "chName");
            // 
            // loadingPanel
            // 
            resources.ApplyResources(this.loadingPanel, "loadingPanel");
            this.loadingPanel.Controls.Add(this.label1);
            this.loadingPanel.Controls.Add(this.pgBar);
            this.loadingPanel.Name = "loadingPanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pgBar
            // 
            resources.ApplyResources(this.pgBar, "pgBar");
            this.pgBar.Name = "pgBar";
            this.pgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBar.UseWaitCursor = true;
            // 
            // logoChannel
            // 
            resources.ApplyResources(this.logoChannel, "logoChannel");
            this.logoChannel.Name = "logoChannel";
            this.logoChannel.TabStop = false;
            // 
            // lbChName
            // 
            resources.ApplyResources(this.lbChName, "lbChName");
            this.lbChName.Name = "lbChName";
            // 
            // txtFilter
            // 
            resources.ApplyResources(this.txtFilter, "txtFilter");
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panelvideo
            // 
            resources.ApplyResources(this.panelvideo, "panelvideo");
            this.panelvideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelvideo.ForeColor = System.Drawing.Color.Black;
            this.panelvideo.Name = "panelvideo";
            this.panelvideo.DoubleClick += new System.EventHandler(this.panelvideo_DoubleClick);
            // 
            // btnPlayPause
            // 
            resources.ApplyResources(this.btnPlayPause, "btnPlayPause");
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // seekBar
            // 
            resources.ApplyResources(this.seekBar, "seekBar");
            this.seekBar.LargeChange = 0;
            this.seekBar.Name = "seekBar";
            this.seekBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.seekBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseDown);
            this.seekBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseUp);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnFixId);
            this.panel1.Controls.Add(this.logoEPG);
            this.panel1.Controls.Add(this.lbEndTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbStartTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbStars);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTitleEPG);
            this.panel1.Name = "panel1";
            // 
            // lbYear
            // 
            resources.ApplyResources(this.lbYear, "lbYear");
            this.lbYear.Name = "lbYear";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnFixId
            // 
            resources.ApplyResources(this.btnFixId, "btnFixId");
            this.btnFixId.Name = "btnFixId";
            this.btnFixId.UseVisualStyleBackColor = true;
            this.btnFixId.Click += new System.EventHandler(this.btnFixId_Click);
            // 
            // logoEPG
            // 
            resources.ApplyResources(this.logoEPG, "logoEPG");
            this.logoEPG.Name = "logoEPG";
            this.logoEPG.TabStop = false;
            this.logoEPG.Click += new System.EventHandler(this.logoEPG_Click);
            this.logoEPG.MouseHover += new System.EventHandler(this.logoEPG_MouseHover);
            // 
            // lbEndTime
            // 
            resources.ApplyResources(this.lbEndTime, "lbEndTime");
            this.lbEndTime.Name = "lbEndTime";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lbStartTime
            // 
            resources.ApplyResources(this.lbStartTime, "lbStartTime");
            this.lbStartTime.Name = "lbStartTime";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbStars
            // 
            resources.ApplyResources(this.lbStars, "lbStars");
            this.lbStars.Name = "lbStars";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbTitleEPG
            // 
            resources.ApplyResources(this.lbTitleEPG, "lbTitleEPG");
            this.lbTitleEPG.Name = "lbTitleEPG";
            // 
            // lbDuration
            // 
            resources.ApplyResources(this.lbDuration, "lbDuration");
            this.lbDuration.Name = "lbDuration";
            // 
            // lbVersionText
            // 
            resources.ApplyResources(this.lbVersionText, "lbVersionText");
            this.lbVersionText.Name = "lbVersionText";
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.Name = "lbVersion";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbProcessingEPG
            // 
            resources.ApplyResources(this.lbProcessingEPG, "lbProcessingEPG");
            this.lbProcessingEPG.Name = "lbProcessingEPG";
            // 
            // txtLoadCh
            // 
            resources.ApplyResources(this.txtLoadCh, "txtLoadCh");
            this.txtLoadCh.Name = "txtLoadCh";
            // 
            // btnMuteUnmute
            // 
            resources.ApplyResources(this.btnMuteUnmute, "btnMuteUnmute");
            this.btnMuteUnmute.Name = "btnMuteUnmute";
            this.btnMuteUnmute.UseVisualStyleBackColor = true;
            this.btnMuteUnmute.Click += new System.EventHandler(this.btnMuteUnmute_Click);
            // 
            // trVolumen
            // 
            resources.ApplyResources(this.trVolumen, "trVolumen");
            this.trVolumen.LargeChange = 0;
            this.trVolumen.Maximum = 50;
            this.trVolumen.Name = "trVolumen";
            this.trVolumen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trVolumen_MouseUp);
            // 
            // cmbLangs
            // 
            resources.ApplyResources(this.cmbLangs, "cmbLangs");
            this.cmbLangs.FormattingEnabled = true;
            this.cmbLangs.Name = "cmbLangs";
            this.cmbLangs.SelectedIndexChanged += new System.EventHandler(this.cmbLangs_SelectedIndexChanged);
            // 
            // cmbSubs
            // 
            resources.ApplyResources(this.cmbSubs, "cmbSubs");
            this.cmbSubs.FormattingEnabled = true;
            this.cmbSubs.Name = "cmbSubs";
            this.cmbSubs.SelectedIndexChanged += new System.EventHandler(this.cmbSubs_SelectedIndexChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnURLInfo
            // 
            resources.ApplyResources(this.btnURLInfo, "btnURLInfo");
            this.btnURLInfo.Name = "btnURLInfo";
            this.btnURLInfo.UseVisualStyleBackColor = true;
            this.btnURLInfo.Click += new System.EventHandler(this.btnURLInfo_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnURLInfo);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSubs);
            this.Controls.Add(this.cmbLangs);
            this.Controls.Add(this.trVolumen);
            this.Controls.Add(this.btnMuteUnmute);
            this.Controls.Add(this.lbProcessingEPG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbVersionText);
            this.Controls.Add(this.panelvideo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lbChName);
            this.Controls.Add(this.logoChannel);
            this.Controls.Add(this.chList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.txtLoadCh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView chList;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.PictureBox logoChannel;
        private System.Windows.Forms.Label lbChName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.Panel panelvideo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitleEPG;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.PictureBox logoEPG;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVersionText;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbProcessingEPG;
        private System.Windows.Forms.ToolStripMenuItem refreshEPGToolStripMenuItem;
        private System.Windows.Forms.Button btnFixId;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoadCh;
        private System.Windows.Forms.Button btnMuteUnmute;
        private System.Windows.Forms.TrackBar trVolumen;
        private System.Windows.Forms.ComboBox cmbLangs;
        private System.Windows.Forms.ComboBox cmbSubs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnURLInfo;
    }
}

