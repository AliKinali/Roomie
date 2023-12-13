namespace Roomie
{
    partial class Monografya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monografya));
            this.mesajlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mESAJGONDERENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJICERIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monografyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitirmeProjesiDataSet = new Roomie.BitirmeProjesiDataSet();
            this.gönderildi = new System.Windows.Forms.PictureBox();
            this.VerileriSil = new System.Windows.Forms.Button();
            this.gönderilmedi = new System.Windows.Forms.PictureBox();
            this.textGönderen = new System.Windows.Forms.TextBox();
            this.mesajGonder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textMesaj = new System.Windows.Forms.RichTextBox();
            this.monografyaTableAdapter = new Roomie.BitirmeProjesiDataSetTableAdapters.MonografyaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roomieDataSet = new Roomie.RoomieDataSet();
            this.monografyaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monografyaTableAdapter1 = new Roomie.RoomieDataSetTableAdapters.MonografyaTableAdapter();
            this.mesajlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monografyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monografyaBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.mesajlar.Location = new System.Drawing.Point(12, 151);
            this.mesajlar.Name = "mesajlar";
            this.mesajlar.Size = new System.Drawing.Size(750, 634);
            this.mesajlar.TabIndex = 17;
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
            this.dataGridView1.DataSource = this.monografyaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
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
            this.mESAJGONDERENDataGridViewTextBoxColumn.Width = 171;
            // 
            // mESAJICERIKDataGridViewTextBoxColumn
            // 
            this.mESAJICERIKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mESAJICERIKDataGridViewTextBoxColumn.DataPropertyName = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.HeaderText = "MESAJICERIK";
            this.mESAJICERIKDataGridViewTextBoxColumn.Name = "mESAJICERIKDataGridViewTextBoxColumn";
            this.mESAJICERIKDataGridViewTextBoxColumn.Width = 131;
            // 
            // monografyaBindingSource
            // 
            this.monografyaBindingSource.DataMember = "Monografya";
            this.monografyaBindingSource.DataSource = this.bitirmeProjesiDataSet;
            // 
            // bitirmeProjesiDataSet
            // 
            this.bitirmeProjesiDataSet.DataSetName = "BitirmeProjesiDataSet";
            this.bitirmeProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gönderildi
            // 
            this.gönderildi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gönderildi.Image = ((System.Drawing.Image)(resources.GetObject("gönderildi.Image")));
            this.gönderildi.Location = new System.Drawing.Point(650, 503);
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
            this.gönderilmedi.Location = new System.Drawing.Point(686, 503);
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
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "paper-plane.png");
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
            // monografyaTableAdapter
            // 
            this.monografyaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 100);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOMIE";
            // 
            // roomieDataSet
            // 
            this.roomieDataSet.DataSetName = "RoomieDataSet";
            this.roomieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monografyaBindingSource1
            // 
            this.monografyaBindingSource1.DataMember = "Monografya";
            this.monografyaBindingSource1.DataSource = this.roomieDataSet;
            // 
            // monografyaTableAdapter1
            // 
            this.monografyaTableAdapter1.ClearBeforeFill = true;
            // 
            // Monografya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(779, 857);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mesajlar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Monografya";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Monografya_Load);
            this.mesajlar.ResumeLayout(false);
            this.mesajlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monografyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirmeProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderildi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gönderilmedi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monografyaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mesajlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox gönderildi;
        private System.Windows.Forms.Button VerileriSil;
        private System.Windows.Forms.PictureBox gönderilmedi;
        private System.Windows.Forms.TextBox textGönderen;
        private System.Windows.Forms.Button mesajGonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textMesaj;
        private BitirmeProjesiDataSet bitirmeProjesiDataSet;
        private System.Windows.Forms.BindingSource monografyaBindingSource;
        private BitirmeProjesiDataSetTableAdapters.MonografyaTableAdapter monografyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJGONDERENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJICERIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RoomieDataSet roomieDataSet;
        private System.Windows.Forms.BindingSource monografyaBindingSource1;
        private RoomieDataSetTableAdapters.MonografyaTableAdapter monografyaTableAdapter1;
    }
}