namespace Roomie
{
    partial class Matematik_1Grubu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matematik_1Grubu));
            this.matematik1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bitirmeProjesiDataSet = new Roomie.BitirmeProjesiDataSet();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.matematik1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matematik_1TableAdapter = new Roomie.BitirmeProjesiDataSetTableAdapters.Matematik_1TableAdapter();
            this.mesajlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mESAJGONDERENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJICERIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gönderildi = new System.Windows.Forms.PictureBox();
            this.VerileriSil = new System.Windows.Forms.Button();
            this.gönderilmedi = new System.Windows.Forms.PictureBox();
            this.textGönderen = new System.Windows.Forms.TextBox();
            this.mesajGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textMesaj = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomieDataSet = new Roomie.RoomieDataSet();
            this.matematik1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.matematik_1TableAdapter1 = new Roomie.RoomieDataSetTableAdapters.Matematik_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource)).BeginInit();
            this.mesajlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // matematik1BindingSource1
            // 
            this.matematik1BindingSource1.DataMember = "Matematik_1";
            this.matematik1BindingSource1.DataSource = this.bitirmeProjesiDataSet;
            // 
            // bitirmeProjesiDataSet
            // 
            this.bitirmeProjesiDataSet.DataSetName = "BitirmeProjesiDataSet";
            this.bitirmeProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "paper-plane.png");
            // 
            // matematik1BindingSource
            // 
            this.matematik1BindingSource.DataMember = "Matematik_1";
            this.matematik1BindingSource.DataSource = this.bitirmeProjesiDataSet;
            // 
            // matematik_1TableAdapter
            // 
            this.matematik_1TableAdapter.ClearBeforeFill = true;
            // 
            // mesajlar
            // 
            this.mesajlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesajlar.Controls.Add(this.dataGridView1);
            this.mesajlar.Controls.Add(this.gönderildi);
            this.mesajlar.Controls.Add(this.VerileriSil);
            this.mesajlar.Controls.Add(this.gönderilmedi);
            this.mesajlar.Controls.Add(this.textGönderen);
            this.mesajlar.Controls.Add(this.mesajGonder);
            this.mesajlar.Controls.Add(this.label2);
            this.mesajlar.Controls.Add(this.textMesaj);
            this.mesajlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajlar.Location = new System.Drawing.Point(6, 158);
            this.mesajlar.Name = "mesajlar";
            this.mesajlar.Size = new System.Drawing.Size(750, 634);
            this.mesajlar.TabIndex = 16;
            this.mesajlar.TabStop = false;
            this.mesajlar.Text = "MESAJ EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mESAJGONDERENDataGridViewTextBoxColumn,
            this.mESAJICERIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matematik1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 456);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mESAJGONDERENDataGridViewTextBoxColumn
            // 
            this.mESAJGONDERENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJGONDERENDataGridViewTextBoxColumn.DataPropertyName = "MESAJGONDEREN";
            this.mESAJGONDERENDataGridViewTextBoxColumn.HeaderText = "MESAJGONDEREN";
            this.mESAJGONDERENDataGridViewTextBoxColumn.Name = "mESAJGONDERENDataGridViewTextBoxColumn";
            this.mESAJGONDERENDataGridViewTextBoxColumn.ReadOnly = true;
            this.mESAJGONDERENDataGridViewTextBoxColumn.Width = 171;
            // 
            // mESAJICERIKDataGridViewTextBoxColumn
            // 
            this.mESAJICERIKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJICERIKDataGridViewTextBoxColumn.DataPropertyName = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.HeaderText = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.Name = "mESAJICERIKDataGridViewTextBoxColumn";
            this.mESAJICERIKDataGridViewTextBoxColumn.ReadOnly = true;
            this.mESAJICERIKDataGridViewTextBoxColumn.Width = 131;
            // 
            // gönderildi
            // 
            this.gönderildi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gönderildi.Image = ((System.Drawing.Image)(resources.GetObject("gönderildi.Image")));
            this.gönderildi.Location = new System.Drawing.Point(652, 486);
            this.gönderildi.Name = "gönderildi";
            this.gönderildi.Size = new System.Drawing.Size(30, 30);
            this.gönderildi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gönderildi.TabIndex = 5;
            this.gönderildi.TabStop = false;
            this.gönderildi.Visible = false;
            // 
            // VerileriSil
            // 
            this.VerileriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VerileriSil.Location = new System.Drawing.Point(444, 548);
            this.VerileriSil.Name = "VerileriSil";
            this.VerileriSil.Size = new System.Drawing.Size(105, 61);
            this.VerileriSil.TabIndex = 9;
            this.VerileriSil.Text = "Tüm Mesaj Verilerini Sil";
            this.VerileriSil.UseVisualStyleBackColor = true;
            this.VerileriSil.Click += new System.EventHandler(this.VerileriSil_Click);
            // 
            // gönderilmedi
            // 
            this.gönderilmedi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gönderilmedi.Image = ((System.Drawing.Image)(resources.GetObject("gönderilmedi.Image")));
            this.gönderilmedi.Location = new System.Drawing.Point(688, 486);
            this.gönderilmedi.Name = "gönderilmedi";
            this.gönderilmedi.Size = new System.Drawing.Size(30, 30);
            this.gönderilmedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gönderilmedi.TabIndex = 6;
            this.gönderilmedi.TabStop = false;
            this.gönderilmedi.Visible = false;
            // 
            // textGönderen
            // 
            this.textGönderen.Location = new System.Drawing.Point(14, 531);
            this.textGönderen.Name = "textGönderen";
            this.textGönderen.Size = new System.Drawing.Size(140, 24);
            this.textGönderen.TabIndex = 7;
            // 
            // mesajGonder
            // 
            this.mesajGonder.ImageKey = "paper-plane.png";
            this.mesajGonder.ImageList = this.ımageList1;
            this.mesajGonder.Location = new System.Drawing.Point(322, 561);
            this.mesajGonder.Name = "mesajGonder";
            this.mesajGonder.Size = new System.Drawing.Size(88, 48);
            this.mesajGonder.TabIndex = 1;
            this.mesajGonder.UseVisualStyleBackColor = true;
            this.mesajGonder.Click += new System.EventHandler(this.mesajGonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "GÖNDEREN NO";
            // 
            // textMesaj
            // 
            this.textMesaj.Location = new System.Drawing.Point(14, 557);
            this.textMesaj.Name = "textMesaj";
            this.textMesaj.Size = new System.Drawing.Size(302, 52);
            this.textMesaj.TabIndex = 0;
            this.textMesaj.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 100);
            this.panel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Plum;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(222, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 55);
            this.label8.TabIndex = 0;
            this.label8.Text = "ROOMIE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mesajlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 820);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // roomieDataSet
            // 
            this.roomieDataSet.DataSetName = "RoomieDataSet";
            this.roomieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matematik1BindingSource2
            // 
            this.matematik1BindingSource2.DataMember = "Matematik_1";
            this.matematik1BindingSource2.DataSource = this.roomieDataSet;
            // 
            // matematik_1TableAdapter1
            // 
            this.matematik_1TableAdapter1.ClearBeforeFill = true;
            // 
            // Matematik_1Grubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(787, 835);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Matematik_1Grubu";
            this.Text = "Matematik_1Grubu";
            this.Load += new System.EventHandler(this.Matematik_1Grubu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource)).EndInit();
            this.mesajlar.ResumeLayout(false);
            this.mesajlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matematik1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BitirmeProjesiDataSet bitirmeProjesiDataSet;
        private System.Windows.Forms.BindingSource matematik1BindingSource;
        private BitirmeProjesiDataSetTableAdapters.Matematik_1TableAdapter matematik_1TableAdapter;
        private System.Windows.Forms.BindingSource matematik1BindingSource1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox mesajlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJGONDERENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJICERIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox gönderildi;
        private System.Windows.Forms.Button VerileriSil;
        private System.Windows.Forms.PictureBox gönderilmedi;
        private System.Windows.Forms.TextBox textGönderen;
        private System.Windows.Forms.Button mesajGonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textMesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private RoomieDataSet roomieDataSet;
        private System.Windows.Forms.BindingSource matematik1BindingSource2;
        private RoomieDataSetTableAdapters.Matematik_1TableAdapter matematik_1TableAdapter1;
    }
}