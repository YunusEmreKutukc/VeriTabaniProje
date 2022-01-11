
namespace DisHekimligiOto
{
    partial class SEKRETER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEKRETER));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRandevuList = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewRandevu = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSet3 = new DisHekimligiOto.DataSet3();
            this.pROJHASTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJ_HASTATableAdapter = new DisHekimligiOto.DataSet3TableAdapters.PROJ_HASTATableAdapter();
            this.hASTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTDOGUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTRANDEVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTMESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTCINSIYETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTSIKAYETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTADRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASTEPOSTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHASTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1299, 667);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageRandevuList
            // 
            this.tabPageRandevuList.Controls.Add(this.pictureBox1);
            this.tabPageRandevuList.Controls.Add(this.button3);
            this.tabPageRandevuList.Controls.Add(this.dataGridViewRandevu);
            this.tabPageRandevuList.Controls.Add(this.label10);
            this.tabPageRandevuList.Location = new System.Drawing.Point(4, 22);
            this.tabPageRandevuList.Name = "tabPageRandevuList";
            this.tabPageRandevuList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevuList.Size = new System.Drawing.Size(1291, 641);
            this.tabPageRandevuList.TabIndex = 2;
            this.tabPageRandevuList.Text = "RANDEVU LİSTESİ";
            this.tabPageRandevuList.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1122, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewRandevu
            // 
            this.dataGridViewRandevu.AutoGenerateColumns = false;
            this.dataGridViewRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hASTIDDataGridViewTextBoxColumn,
            this.hASTADDataGridViewTextBoxColumn,
            this.hASTSOYADDataGridViewTextBoxColumn,
            this.hASTTCDataGridViewTextBoxColumn,
            this.hASTDOGUMDataGridViewTextBoxColumn,
            this.hASTRANDEVUDataGridViewTextBoxColumn,
            this.hASTMESLEKDataGridViewTextBoxColumn,
            this.hASTCINSIYETDataGridViewTextBoxColumn,
            this.hASTSIKAYETDataGridViewTextBoxColumn,
            this.hASTADRESDataGridViewTextBoxColumn,
            this.hASTTELDataGridViewTextBoxColumn,
            this.hASTEPOSTADataGridViewTextBoxColumn});
            this.dataGridViewRandevu.DataSource = this.pROJHASTABindingSource;
            this.dataGridViewRandevu.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewRandevu.Name = "dataGridViewRandevu";
            this.dataGridViewRandevu.Size = new System.Drawing.Size(1108, 627);
            this.dataGridViewRandevu.TabIndex = 1;
            this.dataGridViewRandevu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1285, 635);
            this.label10.TabIndex = 0;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJHASTABindingSource
            // 
            this.pROJHASTABindingSource.DataMember = "PROJ_HASTA";
            this.pROJHASTABindingSource.DataSource = this.dataSet3;
            // 
            // pROJ_HASTATableAdapter
            // 
            this.pROJ_HASTATableAdapter.ClearBeforeFill = true;
            // 
            // hASTIDDataGridViewTextBoxColumn
            // 
            this.hASTIDDataGridViewTextBoxColumn.DataPropertyName = "HASTID";
            this.hASTIDDataGridViewTextBoxColumn.HeaderText = "HASTID";
            this.hASTIDDataGridViewTextBoxColumn.Name = "hASTIDDataGridViewTextBoxColumn";
            // 
            // hASTADDataGridViewTextBoxColumn
            // 
            this.hASTADDataGridViewTextBoxColumn.DataPropertyName = "HASTAD";
            this.hASTADDataGridViewTextBoxColumn.HeaderText = "HASTAD";
            this.hASTADDataGridViewTextBoxColumn.Name = "hASTADDataGridViewTextBoxColumn";
            // 
            // hASTSOYADDataGridViewTextBoxColumn
            // 
            this.hASTSOYADDataGridViewTextBoxColumn.DataPropertyName = "HASTSOYAD";
            this.hASTSOYADDataGridViewTextBoxColumn.HeaderText = "HASTSOYAD";
            this.hASTSOYADDataGridViewTextBoxColumn.Name = "hASTSOYADDataGridViewTextBoxColumn";
            // 
            // hASTTCDataGridViewTextBoxColumn
            // 
            this.hASTTCDataGridViewTextBoxColumn.DataPropertyName = "HASTTC";
            this.hASTTCDataGridViewTextBoxColumn.HeaderText = "HASTTC";
            this.hASTTCDataGridViewTextBoxColumn.Name = "hASTTCDataGridViewTextBoxColumn";
            // 
            // hASTDOGUMDataGridViewTextBoxColumn
            // 
            this.hASTDOGUMDataGridViewTextBoxColumn.DataPropertyName = "HASTDOGUM";
            this.hASTDOGUMDataGridViewTextBoxColumn.HeaderText = "HASTDOGUM";
            this.hASTDOGUMDataGridViewTextBoxColumn.Name = "hASTDOGUMDataGridViewTextBoxColumn";
            // 
            // hASTRANDEVUDataGridViewTextBoxColumn
            // 
            this.hASTRANDEVUDataGridViewTextBoxColumn.DataPropertyName = "HASTRANDEVU";
            this.hASTRANDEVUDataGridViewTextBoxColumn.HeaderText = "HASTRANDEVU";
            this.hASTRANDEVUDataGridViewTextBoxColumn.Name = "hASTRANDEVUDataGridViewTextBoxColumn";
            // 
            // hASTMESLEKDataGridViewTextBoxColumn
            // 
            this.hASTMESLEKDataGridViewTextBoxColumn.DataPropertyName = "HASTMESLEK";
            this.hASTMESLEKDataGridViewTextBoxColumn.HeaderText = "HASTMESLEK";
            this.hASTMESLEKDataGridViewTextBoxColumn.Name = "hASTMESLEKDataGridViewTextBoxColumn";
            // 
            // hASTCINSIYETDataGridViewTextBoxColumn
            // 
            this.hASTCINSIYETDataGridViewTextBoxColumn.DataPropertyName = "HASTCINSIYET";
            this.hASTCINSIYETDataGridViewTextBoxColumn.HeaderText = "HASTCINSIYET";
            this.hASTCINSIYETDataGridViewTextBoxColumn.Name = "hASTCINSIYETDataGridViewTextBoxColumn";
            // 
            // hASTSIKAYETDataGridViewTextBoxColumn
            // 
            this.hASTSIKAYETDataGridViewTextBoxColumn.DataPropertyName = "HASTSIKAYET";
            this.hASTSIKAYETDataGridViewTextBoxColumn.HeaderText = "HASTSIKAYET";
            this.hASTSIKAYETDataGridViewTextBoxColumn.Name = "hASTSIKAYETDataGridViewTextBoxColumn";
            // 
            // hASTADRESDataGridViewTextBoxColumn
            // 
            this.hASTADRESDataGridViewTextBoxColumn.DataPropertyName = "HASTADRES";
            this.hASTADRESDataGridViewTextBoxColumn.HeaderText = "HASTADRES";
            this.hASTADRESDataGridViewTextBoxColumn.Name = "hASTADRESDataGridViewTextBoxColumn";
            // 
            // hASTTELDataGridViewTextBoxColumn
            // 
            this.hASTTELDataGridViewTextBoxColumn.DataPropertyName = "HASTTEL";
            this.hASTTELDataGridViewTextBoxColumn.HeaderText = "HASTTEL";
            this.hASTTELDataGridViewTextBoxColumn.Name = "hASTTELDataGridViewTextBoxColumn";
            // 
            // hASTEPOSTADataGridViewTextBoxColumn
            // 
            this.hASTEPOSTADataGridViewTextBoxColumn.DataPropertyName = "HASTEPOSTA";
            this.hASTEPOSTADataGridViewTextBoxColumn.HeaderText = "HASTEPOSTA";
            this.hASTEPOSTADataGridViewTextBoxColumn.Name = "hASTEPOSTADataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1234, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // SEKRETER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "SEKRETER";
            this.Text = "HastaKayıtForm";
            this.Load += new System.EventHandler(this.SEKRETER_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRandevuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHASTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRandevuList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewRandevu;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource pROJHASTABindingSource;
        private DataSet3TableAdapters.PROJ_HASTATableAdapter pROJ_HASTATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTDOGUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTRANDEVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTMESLEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTCINSIYETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTSIKAYETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTADRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTEPOSTADataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}