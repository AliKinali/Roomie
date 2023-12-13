namespace Roomie
{
    partial class k
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(k));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.gönderildi = new System.Windows.Forms.PictureBox();
            this.gönderilmedi = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabloKisilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomieDataSet = new Roomie.RoomieDataSet();
            this.kisilerBtn = new System.Windows.Forms.Button();
            this.tabloKisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitirmeProjesiDataSet1 = new Roomie.BitirmeProjesiDataSet();
            this.mesajlar = new System.Windows.Forms.GroupBox();
            this.textAlici = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mESAJGONDERENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJALANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJICERIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabloMesajBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.VerileriSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textGönderen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mesajGonder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textMesaj = new System.Windows.Forms.RichTextBox();
            this.tabloMesajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitirmeProjesiDataSet = new Roomie.BitirmeProjesiDataSet();
            this.bitirmeProjesiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Roomie.BitirmeProjesiDataSetTableAdapters.TableAdapterManager();
            this.tablo_MesajTableAdapter = new Roomie.BitirmeProjesiDataSetTableAdapters.Tablo_MesajTableAdapter();
            this.tablo_KisilerTableAdapter = new Roomie.BitirmeProjesiDataSetTableAdapters.Tablo_KisilerTableAdapter();
            this.tablo_MesajTableAdapter1 = new Roomie.RoomieDataSetTableAdapters.Tablo_MesajTableAdapter();
            this.tablo_KisilerTableAdapter1 = new Roomie.RoomieDataSetTableAdapters.Tablo_KisilerTableAdapter();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öĞRENCİNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kULLANICITİPİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloKisilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloKisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet1)).BeginInit();
            this.mesajlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloMesajBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloMesajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 134);
            this.panel1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 55);
            this.label8.TabIndex = 0;
            this.label8.Text = "ROOMIE";
            // 
            // gönderildi
            // 
            this.gönderildi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gönderildi.Image = ((System.Drawing.Image)(resources.GetObject("gönderildi.Image")));
            this.gönderildi.Location = new System.Drawing.Point(414, 396);
            this.gönderildi.Name = "gönderildi";
            this.gönderildi.Size = new System.Drawing.Size(30, 30);
            this.gönderildi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gönderildi.TabIndex = 5;
            this.gönderildi.TabStop = false;
            this.gönderildi.Visible = false;
            // 
            // gönderilmedi
            // 
            this.gönderilmedi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gönderilmedi.Image = ((System.Drawing.Image)(resources.GetObject("gönderilmedi.Image")));
            this.gönderilmedi.Location = new System.Drawing.Point(450, 396);
            this.gönderilmedi.Name = "gönderilmedi";
            this.gönderilmedi.Size = new System.Drawing.Size(30, 30);
            this.gönderilmedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gönderilmedi.TabIndex = 6;
            this.gönderilmedi.TabStop = false;
            this.gönderilmedi.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.kisilerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(532, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 722);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİLER";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.öĞRENCİNODataGridViewTextBoxColumn,
            this.kULLANICITİPİDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabloKisilerBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(562, 651);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabloKisilerBindingSource1
            // 
            this.tabloKisilerBindingSource1.DataMember = "Tablo_Kisiler";
            this.tabloKisilerBindingSource1.DataSource = this.roomieDataSet;
            // 
            // roomieDataSet
            // 
            this.roomieDataSet.DataSetName = "RoomieDataSet";
            this.roomieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisilerBtn
            // 
            this.kisilerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisilerBtn.Location = new System.Drawing.Point(6, 683);
            this.kisilerBtn.Name = "kisilerBtn";
            this.kisilerBtn.Size = new System.Drawing.Size(162, 33);
            this.kisilerBtn.TabIndex = 0;
            this.kisilerBtn.Text = "KİŞİLERİ GÖSTER";
            this.kisilerBtn.UseVisualStyleBackColor = true;
            this.kisilerBtn.Click += new System.EventHandler(this.kisilerBtn_Click);
            // 
            // tabloKisilerBindingSource
            // 
            this.tabloKisilerBindingSource.DataMember = "Tablo_Kisiler";
            this.tabloKisilerBindingSource.DataSource = this.bitirmeProjesiDataSet1;
            // 
            // bitirmeProjesiDataSet1
            // 
            this.bitirmeProjesiDataSet1.DataSetName = "BitirmeProjesiDataSet1";
            this.bitirmeProjesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajlar
            // 
            this.mesajlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesajlar.BackgroundImage")));
            this.mesajlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesajlar.Controls.Add(this.textAlici);
            this.mesajlar.Controls.Add(this.dataGridView1);
            this.mesajlar.Controls.Add(this.gönderildi);
            this.mesajlar.Controls.Add(this.VerileriSil);
            this.mesajlar.Controls.Add(this.gönderilmedi);
            this.mesajlar.Controls.Add(this.label2);
            this.mesajlar.Controls.Add(this.textGönderen);
            this.mesajlar.Controls.Add(this.label1);
            this.mesajlar.Controls.Add(this.mesajGonder);
            this.mesajlar.Controls.Add(this.textMesaj);
            this.mesajlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajlar.Location = new System.Drawing.Point(0, 163);
            this.mesajlar.Name = "mesajlar";
            this.mesajlar.Size = new System.Drawing.Size(526, 525);
            this.mesajlar.TabIndex = 11;
            this.mesajlar.TabStop = false;
            this.mesajlar.Text = "MESAJ EKRANI";
            // 
            // textAlici
            // 
            this.textAlici.Location = new System.Drawing.Point(15, 429);
            this.textAlici.Mask = "0000000000";
            this.textAlici.Name = "textAlici";
            this.textAlici.Size = new System.Drawing.Size(143, 24);
            this.textAlici.TabIndex = 12;
            this.textAlici.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mESAJGONDERENDataGridViewTextBoxColumn,
            this.mESAJALANDataGridViewTextBoxColumn,
            this.mESAJICERIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabloMesajBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 369);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mESAJGONDERENDataGridViewTextBoxColumn
            // 
            this.mESAJGONDERENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJGONDERENDataGridViewTextBoxColumn.DataPropertyName = "MESAJGONDEREN";
            this.mESAJGONDERENDataGridViewTextBoxColumn.FillWeight = 150F;
            this.mESAJGONDERENDataGridViewTextBoxColumn.HeaderText = "MESAJGONDEREN";
            this.mESAJGONDERENDataGridViewTextBoxColumn.Name = "mESAJGONDERENDataGridViewTextBoxColumn";
            this.mESAJGONDERENDataGridViewTextBoxColumn.Width = 171;
            // 
            // mESAJALANDataGridViewTextBoxColumn
            // 
            this.mESAJALANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJALANDataGridViewTextBoxColumn.DataPropertyName = "MESAJALAN";
            this.mESAJALANDataGridViewTextBoxColumn.HeaderText = "MESAJALAN";
            this.mESAJALANDataGridViewTextBoxColumn.Name = "mESAJALANDataGridViewTextBoxColumn";
            this.mESAJALANDataGridViewTextBoxColumn.Width = 120;
            // 
            // mESAJICERIKDataGridViewTextBoxColumn
            // 
            this.mESAJICERIKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJICERIKDataGridViewTextBoxColumn.DataPropertyName = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.HeaderText = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.Name = "mESAJICERIKDataGridViewTextBoxColumn";
            this.mESAJICERIKDataGridViewTextBoxColumn.Width = 131;
            // 
            // tabloMesajBindingSource1
            // 
            this.tabloMesajBindingSource1.DataMember = "Tablo_Mesaj";
            this.tabloMesajBindingSource1.DataSource = this.roomieDataSet;
            // 
            // VerileriSil
            // 
            this.VerileriSil.Location = new System.Drawing.Point(398, 449);
            this.VerileriSil.Name = "VerileriSil";
            this.VerileriSil.Size = new System.Drawing.Size(105, 61);
            this.VerileriSil.TabIndex = 9;
            this.VerileriSil.Text = "Tüm Mesaj Verilerini Sil";
            this.VerileriSil.UseVisualStyleBackColor = true;
            this.VerileriSil.Click += new System.EventHandler(this.göster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "GÖNDEREN NO";
            // 
            // textGönderen
            // 
            this.textGönderen.Location = new System.Drawing.Point(164, 429);
            this.textGönderen.Name = "textGönderen";
            this.textGönderen.Size = new System.Drawing.Size(140, 24);
            this.textGönderen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALICI NO";
            // 
            // mesajGonder
            // 
            this.mesajGonder.ImageKey = "paper-plane.png";
            this.mesajGonder.ImageList = this.ımageList1;
            this.mesajGonder.Location = new System.Drawing.Point(323, 455);
            this.mesajGonder.Name = "mesajGonder";
            this.mesajGonder.Size = new System.Drawing.Size(58, 48);
            this.mesajGonder.TabIndex = 1;
            this.mesajGonder.UseVisualStyleBackColor = true;
            this.mesajGonder.Click += new System.EventHandler(this.mesajGonder_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "paper-plane.png");
            // 
            // textMesaj
            // 
            this.textMesaj.Location = new System.Drawing.Point(15, 455);
            this.textMesaj.Name = "textMesaj";
            this.textMesaj.Size = new System.Drawing.Size(302, 52);
            this.textMesaj.TabIndex = 0;
            this.textMesaj.Text = "";
            // 
            // tabloMesajBindingSource
            // 
            this.tabloMesajBindingSource.DataMember = "Tablo_Mesaj";
            this.tabloMesajBindingSource.DataSource = this.bitirmeProjesiDataSet1;
            // 
            // bitirmeProjesiDataSet
            // 
            this.bitirmeProjesiDataSet.DataSetName = "BitirmeProjesiDataSet";
            this.bitirmeProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitirmeProjesiDataSetBindingSource
            // 
            this.bitirmeProjesiDataSetBindingSource.DataSource = this.bitirmeProjesiDataSet;
            this.bitirmeProjesiDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.Anadolu_UygarlıklarıTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DişHekimliğindeAraçlarTableAdapter = null;
            this.tableAdapterManager1.EdebiyatTarihiTableAdapter = null;
            this.tableAdapterManager1.Fizik1TableAdapter = null;
            this.tableAdapterManager1.FizyolojiTableAdapter = null;
            this.tableAdapterManager1.JavaİleNesneTabanlıProgramlamaTableAdapter = null;
            this.tableAdapterManager1.Matematik_1TableAdapter = null;
            this.tableAdapterManager1.Matematik_2TableAdapter = null;
            this.tableAdapterManager1.MonografyaTableAdapter = null;
            this.tableAdapterManager1.MühendislikGirişTableAdapter = null;
            this.tableAdapterManager1.NümerikAnalizTableAdapter = null;
            this.tableAdapterManager1.OrtodontiTableAdapter = null;
            this.tableAdapterManager1.OsmanlıTarihiTableAdapter = null;
            this.tableAdapterManager1.OsmanlıTürkçesiTableAdapter = null;
            this.tableAdapterManager1.PatolojiTableAdapter = null;
            this.tableAdapterManager1.Programlama1TableAdapter = null;
            this.tableAdapterManager1.Programlama2TableAdapter = null;
            this.tableAdapterManager1.ServetiFünunEdebiyatıTableAdapter = null;
            this.tableAdapterManager1.Tablo_KisilerTableAdapter = null;
            this.tableAdapterManager1.Tablo_MesajTableAdapter = null;
            this.tableAdapterManager1.TanzimatEdebiyatıTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Roomie.BitirmeProjesiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.YazılımMimarisiVeTasarımıTableAdapter = null;
            // 
            // tablo_MesajTableAdapter
            // 
            this.tablo_MesajTableAdapter.ClearBeforeFill = true;
            // 
            // tablo_KisilerTableAdapter
            // 
            this.tablo_KisilerTableAdapter.ClearBeforeFill = true;
            // 
            // tablo_MesajTableAdapter1
            // 
            this.tablo_MesajTableAdapter1.ClearBeforeFill = true;
            // 
            // tablo_KisilerTableAdapter1
            // 
            this.tablo_KisilerTableAdapter1.ClearBeforeFill = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 57;
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // öĞRENCİNODataGridViewTextBoxColumn
            // 
            this.öĞRENCİNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.öĞRENCİNODataGridViewTextBoxColumn.DataPropertyName = "ÖĞRENCİNO";
            this.öĞRENCİNODataGridViewTextBoxColumn.HeaderText = "ÖĞRENCİNO";
            this.öĞRENCİNODataGridViewTextBoxColumn.Name = "öĞRENCİNODataGridViewTextBoxColumn";
            this.öĞRENCİNODataGridViewTextBoxColumn.Width = 132;
            // 
            // kULLANICITİPİDataGridViewTextBoxColumn
            // 
            this.kULLANICITİPİDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kULLANICITİPİDataGridViewTextBoxColumn.DataPropertyName = "KULLANICITİPİ";
            this.kULLANICITİPİDataGridViewTextBoxColumn.HeaderText = "KULLANICITİPİ";
            this.kULLANICITİPİDataGridViewTextBoxColumn.Name = "kULLANICITİPİDataGridViewTextBoxColumn";
            this.kULLANICITİPİDataGridViewTextBoxColumn.Width = 146;
            // 
            // k
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 746);
            this.Controls.Add(this.mesajlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "k";
            this.Text = "KİŞİSEL MESAJLAŞMA";
            this.Load += new System.EventHandler(this.k_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloKisilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloKisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet1)).EndInit();
            this.mesajlar.ResumeLayout(false);
            this.mesajlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloMesajBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloMesajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kisilerBtn;
        private System.Windows.Forms.GroupBox mesajlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mesajGonder;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.RichTextBox textMesaj;
        private System.Windows.Forms.PictureBox gönderilmedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGönderen;
        private System.Windows.Forms.Button VerileriSil;
        private System.Windows.Forms.PictureBox gönderildi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BitirmeProjesiDataSet bitirmeProjesiDataSet;
        private System.Windows.Forms.BindingSource bitirmeProjesiDataSetBindingSource;
        private BitirmeProjesiDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private BitirmeProjesiDataSet bitirmeProjesiDataSet1;
        private System.Windows.Forms.BindingSource tabloMesajBindingSource;
        private BitirmeProjesiDataSetTableAdapters.Tablo_MesajTableAdapter tablo_MesajTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tabloKisilerBindingSource;
        private BitirmeProjesiDataSetTableAdapters.Tablo_KisilerTableAdapter tablo_KisilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJGONDERENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJALANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJICERIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox textAlici;
        private RoomieDataSet roomieDataSet;
        private System.Windows.Forms.BindingSource tabloMesajBindingSource1;
        private RoomieDataSetTableAdapters.Tablo_MesajTableAdapter tablo_MesajTableAdapter1;
        private System.Windows.Forms.BindingSource tabloKisilerBindingSource1;
        private RoomieDataSetTableAdapters.Tablo_KisilerTableAdapter tablo_KisilerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öĞRENCİNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULLANICITİPİDataGridViewTextBoxColumn;
    }
}