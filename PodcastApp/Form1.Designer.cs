﻿namespace PodcastApp
{
    partial class Podcast_app
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUppdateringsf = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbxFrekvens = new System.Windows.Forms.ComboBox();
            this.cmbxKategori = new System.Windows.Forms.ComboBox();
            this.btnNyFeed = new System.Windows.Forms.Button();
            this.btnSparaNyaVardenFeed = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lstAvsnitt = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lstKategorier = new System.Windows.Forms.ListBox();
            this.txtValdKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.lblRubrikPodcastInfo = new System.Windows.Forms.Label();
            this.lblPodcastBeskrivning = new System.Windows.Forms.Label();
            this.podcastDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrekvens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvsnittNamn = new System.Windows.Forms.Label();
            this.lblPodAvsnitt = new System.Windows.Forms.Label();
            this.visaAlla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.podcastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(44, 606);
            this.lblURL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(91, 37);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblUppdateringsf
            // 
            this.lblUppdateringsf.AutoSize = true;
            this.lblUppdateringsf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsf.Location = new System.Drawing.Point(614, 606);
            this.lblUppdateringsf.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUppdateringsf.Name = "lblUppdateringsf";
            this.lblUppdateringsf.Size = new System.Drawing.Size(346, 37);
            this.lblUppdateringsf.TabIndex = 2;
            this.lblUppdateringsf.Text = "Uppdateringfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(1100, 606);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(158, 37);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(52, 650);
            this.txtURL.Margin = new System.Windows.Forms.Padding(6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(506, 31);
            this.txtURL.TabIndex = 4;
            // 
            // cmbxFrekvens
            // 
            this.cmbxFrekvens.FormattingEnabled = true;
            this.cmbxFrekvens.Items.AddRange(new object[] {
            "1",
            "5",
            "10"});
            this.cmbxFrekvens.Location = new System.Drawing.Point(622, 648);
            this.cmbxFrekvens.Margin = new System.Windows.Forms.Padding(6);
            this.cmbxFrekvens.Name = "cmbxFrekvens";
            this.cmbxFrekvens.Size = new System.Drawing.Size(454, 33);
            this.cmbxFrekvens.TabIndex = 5;
            this.cmbxFrekvens.Text = "Välj uppdateringsfrekvens";
            // 
            // cmbxKategori
            // 
            this.cmbxKategori.FormattingEnabled = true;
            this.cmbxKategori.Location = new System.Drawing.Point(1108, 648);
            this.cmbxKategori.Margin = new System.Windows.Forms.Padding(6);
            this.cmbxKategori.Name = "cmbxKategori";
            this.cmbxKategori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbxKategori.Size = new System.Drawing.Size(368, 33);
            this.cmbxKategori.TabIndex = 6;
            this.cmbxKategori.Text = "Välj en kategori";
            // 
            // btnNyFeed
            // 
            this.btnNyFeed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyFeed.Location = new System.Drawing.Point(828, 750);
            this.btnNyFeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnNyFeed.Name = "btnNyFeed";
            this.btnNyFeed.Size = new System.Drawing.Size(150, 44);
            this.btnNyFeed.TabIndex = 7;
            this.btnNyFeed.Text = "Ny...";
            this.btnNyFeed.UseVisualStyleBackColor = true;
            this.btnNyFeed.Click += new System.EventHandler(this.btnNyFeed_Click);
            // 
            // btnSparaNyaVardenFeed
            // 
            this.btnSparaNyaVardenFeed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaNyaVardenFeed.Location = new System.Drawing.Point(1076, 750);
            this.btnSparaNyaVardenFeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnSparaNyaVardenFeed.Name = "btnSparaNyaVardenFeed";
            this.btnSparaNyaVardenFeed.Size = new System.Drawing.Size(150, 44);
            this.btnSparaNyaVardenFeed.TabIndex = 8;
            this.btnSparaNyaVardenFeed.Text = "Spara";
            this.btnSparaNyaVardenFeed.UseVisualStyleBackColor = true;
            this.btnSparaNyaVardenFeed.Click += new System.EventHandler(this.btnSparaNyaVardenFeed_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort.Location = new System.Drawing.Point(1330, 750);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(6);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(150, 44);
            this.btnTaBort.TabIndex = 9;
            this.btnTaBort.Text = "Ta bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(54, 838);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(125, 37);
            this.lblAvsnitt.TabIndex = 10;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // lstAvsnitt
            // 
            this.lstAvsnitt.FormattingEnabled = true;
            this.lstAvsnitt.ItemHeight = 25;
            this.lstAvsnitt.Location = new System.Drawing.Point(52, 881);
            this.lstAvsnitt.Margin = new System.Windows.Forms.Padding(6);
            this.lstAvsnitt.Name = "lstAvsnitt";
            this.lstAvsnitt.Size = new System.Drawing.Size(1424, 554);
            this.lstAvsnitt.TabIndex = 12;
            this.lstAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lstAvsnitt_SelectedIndexChanged);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.BackColor = System.Drawing.Color.White;
            this.lblKategorier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(1582, 44);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(189, 37);
            this.lblKategorier.TabIndex = 13;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lstKategorier
            // 
            this.lstKategorier.FormattingEnabled = true;
            this.lstKategorier.ItemHeight = 25;
            this.lstKategorier.Location = new System.Drawing.Point(1564, 83);
            this.lstKategorier.Margin = new System.Windows.Forms.Padding(6);
            this.lstKategorier.Name = "lstKategorier";
            this.lstKategorier.Size = new System.Drawing.Size(774, 479);
            this.lstKategorier.TabIndex = 14;
            this.lstKategorier.SelectedIndexChanged += new System.EventHandler(this.lstKategorier_SelectedIndexChanged);
            // 
            // txtValdKategori
            // 
            this.txtValdKategori.Location = new System.Drawing.Point(1564, 648);
            this.txtValdKategori.Margin = new System.Windows.Forms.Padding(6);
            this.txtValdKategori.Name = "txtValdKategori";
            this.txtValdKategori.Size = new System.Drawing.Size(774, 31);
            this.txtValdKategori.TabIndex = 15;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyKategori.Location = new System.Drawing.Point(1564, 750);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(6);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(226, 44);
            this.btnNyKategori.TabIndex = 16;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaKategori.Location = new System.Drawing.Point(1856, 750);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(6);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(226, 44);
            this.btnSparaKategori.TabIndex = 17;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(2116, 750);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(6);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(226, 44);
            this.btnTaBortKategori.TabIndex = 18;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // lblRubrikPodcastInfo
            // 
            this.lblRubrikPodcastInfo.AutoSize = true;
            this.lblRubrikPodcastInfo.BackColor = System.Drawing.Color.White;
            this.lblRubrikPodcastInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubrikPodcastInfo.Location = new System.Drawing.Point(1584, 902);
            this.lblRubrikPodcastInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRubrikPodcastInfo.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblRubrikPodcastInfo.Name = "lblRubrikPodcastInfo";
            this.lblRubrikPodcastInfo.Size = new System.Drawing.Size(87, 30);
            this.lblRubrikPodcastInfo.TabIndex = 19;
            this.lblRubrikPodcastInfo.Text = "label6";
            // 
            // lblPodcastBeskrivning
            // 
            this.lblPodcastBeskrivning.AutoSize = true;
            this.lblPodcastBeskrivning.BackColor = System.Drawing.Color.White;
            this.lblPodcastBeskrivning.Location = new System.Drawing.Point(1584, 1043);
            this.lblPodcastBeskrivning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPodcastBeskrivning.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            this.lblPodcastBeskrivning.Size = new System.Drawing.Size(70, 25);
            this.lblPodcastBeskrivning.TabIndex = 20;
            this.lblPodcastBeskrivning.Text = "label7";
            // 
            // podcastDataGridView
            // 
            this.podcastDataGridView.AllowUserToAddRows = false;
            this.podcastDataGridView.AllowUserToDeleteRows = false;
            this.podcastDataGridView.AllowUserToResizeColumns = false;
            this.podcastDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.podcastDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.podcastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podcastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAvsnitt,
            this.ColumnNamn,
            this.ColumnURL,
            this.ColumnFrekvens,
            this.ColumnKategori});
            this.podcastDataGridView.Location = new System.Drawing.Point(26, 23);
            this.podcastDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.podcastDataGridView.MultiSelect = false;
            this.podcastDataGridView.Name = "podcastDataGridView";
            this.podcastDataGridView.ReadOnly = true;
            this.podcastDataGridView.RowHeadersVisible = false;
            this.podcastDataGridView.RowHeadersWidth = 51;
            this.podcastDataGridView.Size = new System.Drawing.Size(1428, 523);
            this.podcastDataGridView.TabIndex = 21;
            this.podcastDataGridView.SelectionChanged += new System.EventHandler(this.podcastDataGridView_SelectionChanged);
            // 
            // ColumnAvsnitt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ColumnAvsnitt.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnAvsnitt.HeaderText = "Avsnitt";
            this.ColumnAvsnitt.MinimumWidth = 6;
            this.ColumnAvsnitt.Name = "ColumnAvsnitt";
            this.ColumnAvsnitt.ReadOnly = true;
            this.ColumnAvsnitt.Width = 60;
            // 
            // ColumnNamn
            // 
            this.ColumnNamn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNamn.HeaderText = "Namn";
            this.ColumnNamn.MinimumWidth = 6;
            this.ColumnNamn.Name = "ColumnNamn";
            this.ColumnNamn.ReadOnly = true;
            // 
            // ColumnURL
            // 
            this.ColumnURL.HeaderText = "URL";
            this.ColumnURL.MinimumWidth = 6;
            this.ColumnURL.Name = "ColumnURL";
            this.ColumnURL.ReadOnly = true;
            this.ColumnURL.Width = 270;
            // 
            // ColumnFrekvens
            // 
            this.ColumnFrekvens.HeaderText = "Frekvens";
            this.ColumnFrekvens.MinimumWidth = 6;
            this.ColumnFrekvens.Name = "ColumnFrekvens";
            this.ColumnFrekvens.ReadOnly = true;
            this.ColumnFrekvens.Width = 70;
            // 
            // ColumnKategori
            // 
            this.ColumnKategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnKategori.HeaderText = "Kategori";
            this.ColumnKategori.MinimumWidth = 6;
            this.ColumnKategori.Name = "ColumnKategori";
            this.ColumnKategori.ReadOnly = true;
            this.ColumnKategori.Width = 125;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(44, 712);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(226, 37);
            this.lblNamn.TabIndex = 22;
            this.lblNamn.Text = "Namn på pod:";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(52, 754);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(6);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(506, 31);
            this.txtNamn.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(1564, 881);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 558);
            this.label1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(1562, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 523);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(1518, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 1394);
            this.label3.TabIndex = 26;
            // 
            // lblAvsnittNamn
            // 
            this.lblAvsnittNamn.AutoSize = true;
            this.lblAvsnittNamn.BackColor = System.Drawing.Color.White;
            this.lblAvsnittNamn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittNamn.Location = new System.Drawing.Point(1584, 942);
            this.lblAvsnittNamn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvsnittNamn.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblAvsnittNamn.Name = "lblAvsnittNamn";
            this.lblAvsnittNamn.Size = new System.Drawing.Size(102, 30);
            this.lblAvsnittNamn.TabIndex = 27;
            this.lblAvsnittNamn.Text = "Avsnitt";
            // 
            // lblPodAvsnitt
            // 
            this.lblPodAvsnitt.AutoSize = true;
            this.lblPodAvsnitt.BackColor = System.Drawing.Color.White;
            this.lblPodAvsnitt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodAvsnitt.Location = new System.Drawing.Point(1584, 962);
            this.lblPodAvsnitt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPodAvsnitt.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblPodAvsnitt.Name = "lblPodAvsnitt";
            this.lblPodAvsnitt.Size = new System.Drawing.Size(87, 30);
            this.lblPodAvsnitt.TabIndex = 27;
            this.lblPodAvsnitt.Text = "label6";
            // 
            // visaAlla
            // 
            this.visaAlla.Location = new System.Drawing.Point(1330, 556);
            this.visaAlla.Name = "visaAlla";
            this.visaAlla.Size = new System.Drawing.Size(123, 45);
            this.visaAlla.TabIndex = 28;
            this.visaAlla.Text = "Visa alla";
            this.visaAlla.UseVisualStyleBackColor = true;
            this.visaAlla.Click += new System.EventHandler(this.visaAlla_Click);
            // 
            // Podcast_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(2420, 1454);
            this.Controls.Add(this.visaAlla);
            this.Controls.Add(this.lblPodAvsnitt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.podcastDataGridView);
            this.Controls.Add(this.lblPodcastBeskrivning);
            this.Controls.Add(this.lblRubrikPodcastInfo);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.txtValdKategori);
            this.Controls.Add(this.lstKategorier);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lstAvsnitt);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSparaNyaVardenFeed);
            this.Controls.Add(this.btnNyFeed);
            this.Controls.Add(this.cmbxKategori);
            this.Controls.Add(this.cmbxFrekvens);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsf);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Podcast_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcast app";
            this.Load += new System.EventHandler(this.Podcast_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.podcastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUppdateringsf;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cmbxFrekvens;
        private System.Windows.Forms.ComboBox cmbxKategori;
        private System.Windows.Forms.Button btnNyFeed;
        private System.Windows.Forms.Button btnSparaNyaVardenFeed;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListBox lstAvsnitt;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListBox lstKategorier;
        private System.Windows.Forms.TextBox txtValdKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label lblRubrikPodcastInfo;
        private System.Windows.Forms.Label lblPodcastBeskrivning;
        private System.Windows.Forms.DataGridView podcastDataGridView;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrekvens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKategori;
        private System.Windows.Forms.Label lblAvsnittNamn;
        private System.Windows.Forms.Label lblPodAvsnitt;
        private System.Windows.Forms.Button visaAlla;
    }
}

