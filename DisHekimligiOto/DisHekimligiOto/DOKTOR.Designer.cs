
namespace DisHekimligiOto
{
    partial class DOKTOR
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRandevular = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet4 = new DisHekimligiOto.DataSet4();
            this.pROJDOKRAPORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJ_DOKRAPORTableAdapter = new DisHekimligiOto.DataSet4TableAdapters.PROJ_DOKRAPORTableAdapter();
            this.dataGridViewRandevuLst = new System.Windows.Forms.DataGridView();
            this.dataSet5 = new DisHekimligiOto.DataSet5();
            this.pROJHASTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJ_HASTATableAdapter = new DisHekimligiOto.DataSet5TableAdapters.PROJ_HASTATableAdapter();
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
            this.tabControl1.SuspendLayout();
            this.tabPageRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDOKRAPORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHASTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevular);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1582, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRandevular
            // 
            this.tabPageRandevular.Controls.Add(this.dataGridViewRandevuLst);
            this.tabPageRandevular.Controls.Add(this.label1);
            this.tabPageRandevular.Location = new System.Drawing.Point(4, 22);
            this.tabPageRandevular.Name = "tabPageRandevular";
            this.tabPageRandevular.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevular.Size = new System.Drawing.Size(1574, 654);
            this.tabPageRandevular.TabIndex = 0;
            this.tabPageRandevular.Text = "RANDEVULAR";
            this.tabPageRandevular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1568, 648);
            this.label1.TabIndex = 3;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJDOKRAPORBindingSource
            // 
            this.pROJDOKRAPORBindingSource.DataMember = "PROJ_DOKRAPOR";
            this.pROJDOKRAPORBindingSource.DataSource = this.dataSet4;
            // 
            // pROJ_DOKRAPORTableAdapter
            // 
            this.pROJ_DOKRAPORTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewRandevuLst
            // 
            this.dataGridViewRandevuLst.AutoGenerateColumns = false;
            this.dataGridViewRandevuLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevuLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewRandevuLst.DataSource = this.pROJHASTABindingSource;
            this.dataGridViewRandevuLst.Location = new System.Drawing.Point(8, 18);
            this.dataGridViewRandevuLst.Name = "dataGridViewRandevuLst";
            this.dataGridViewRandevuLst.Size = new System.Drawing.Size(1549, 630);
            this.dataGridViewRandevuLst.TabIndex = 6;
            this.dataGridViewRandevuLst.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJHASTABindingSource
            // 
            this.pROJHASTABindingSource.DataMember = "PROJ_HASTA";
            this.pROJHASTABindingSource.DataSource = this.dataSet5;
            // 
            // pROJ_HASTATableAdapter
            // 
            this.pROJ_HASTATableAdapter.ClearBeforeFill = true;
            // 
            // hASTIDDataGridViewTextBoxColumn
            // 
            this.hASTIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hASTIDDataGridViewTextBoxColumn.DataPropertyName = "HASTID";
            this.hASTIDDataGridViewTextBoxColumn.HeaderText = "HASTA ID";
            this.hASTIDDataGridViewTextBoxColumn.Name = "hASTIDDataGridViewTextBoxColumn";
            this.hASTIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // hASTADDataGridViewTextBoxColumn
            // 
            this.hASTADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTADDataGridViewTextBoxColumn.DataPropertyName = "HASTAD";
            this.hASTADDataGridViewTextBoxColumn.HeaderText = "HASTA AD";
            this.hASTADDataGridViewTextBoxColumn.Name = "hASTADDataGridViewTextBoxColumn";
            // 
            // hASTSOYADDataGridViewTextBoxColumn
            // 
            this.hASTSOYADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTSOYADDataGridViewTextBoxColumn.DataPropertyName = "HASTSOYAD";
            this.hASTSOYADDataGridViewTextBoxColumn.HeaderText = "HASTA SOYAD";
            this.hASTSOYADDataGridViewTextBoxColumn.Name = "hASTSOYADDataGridViewTextBoxColumn";
            // 
            // hASTTCDataGridViewTextBoxColumn
            // 
            this.hASTTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTTCDataGridViewTextBoxColumn.DataPropertyName = "HASTTC";
            this.hASTTCDataGridViewTextBoxColumn.HeaderText = "HASTA TC";
            this.hASTTCDataGridViewTextBoxColumn.Name = "hASTTCDataGridViewTextBoxColumn";
            // 
            // hASTDOGUMDataGridViewTextBoxColumn
            // 
            this.hASTDOGUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTDOGUMDataGridViewTextBoxColumn.DataPropertyName = "HASTDOGUM";
            this.hASTDOGUMDataGridViewTextBoxColumn.HeaderText = "HASTA DOGUM";
            this.hASTDOGUMDataGridViewTextBoxColumn.Name = "hASTDOGUMDataGridViewTextBoxColumn";
            // 
            // hASTRANDEVUDataGridViewTextBoxColumn
            // 
            this.hASTRANDEVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTRANDEVUDataGridViewTextBoxColumn.DataPropertyName = "HASTRANDEVU";
            this.hASTRANDEVUDataGridViewTextBoxColumn.HeaderText = "HASTA RANDEVU";
            this.hASTRANDEVUDataGridViewTextBoxColumn.Name = "hASTRANDEVUDataGridViewTextBoxColumn";
            // 
            // hASTMESLEKDataGridViewTextBoxColumn
            // 
            this.hASTMESLEKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTMESLEKDataGridViewTextBoxColumn.DataPropertyName = "HASTMESLEK";
            this.hASTMESLEKDataGridViewTextBoxColumn.HeaderText = "HASTA MESLEK";
            this.hASTMESLEKDataGridViewTextBoxColumn.Name = "hASTMESLEKDataGridViewTextBoxColumn";
            // 
            // hASTCINSIYETDataGridViewTextBoxColumn
            // 
            this.hASTCINSIYETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTCINSIYETDataGridViewTextBoxColumn.DataPropertyName = "HASTCINSIYET";
            this.hASTCINSIYETDataGridViewTextBoxColumn.HeaderText = "HASTA CINSIYET";
            this.hASTCINSIYETDataGridViewTextBoxColumn.Name = "hASTCINSIYETDataGridViewTextBoxColumn";
            // 
            // hASTSIKAYETDataGridViewTextBoxColumn
            // 
            this.hASTSIKAYETDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTSIKAYETDataGridViewTextBoxColumn.DataPropertyName = "HASTSIKAYET";
            this.hASTSIKAYETDataGridViewTextBoxColumn.HeaderText = "HASTA SIKAYET";
            this.hASTSIKAYETDataGridViewTextBoxColumn.Name = "hASTSIKAYETDataGridViewTextBoxColumn";
            // 
            // hASTADRESDataGridViewTextBoxColumn
            // 
            this.hASTADRESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTADRESDataGridViewTextBoxColumn.DataPropertyName = "HASTADRES";
            this.hASTADRESDataGridViewTextBoxColumn.HeaderText = "HASTA ADRES";
            this.hASTADRESDataGridViewTextBoxColumn.Name = "hASTADRESDataGridViewTextBoxColumn";
            // 
            // hASTTELDataGridViewTextBoxColumn
            // 
            this.hASTTELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTTELDataGridViewTextBoxColumn.DataPropertyName = "HASTTEL";
            this.hASTTELDataGridViewTextBoxColumn.HeaderText = "HASTA TEL";
            this.hASTTELDataGridViewTextBoxColumn.Name = "hASTTELDataGridViewTextBoxColumn";
            // 
            // hASTEPOSTADataGridViewTextBoxColumn
            // 
            this.hASTEPOSTADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASTEPOSTADataGridViewTextBoxColumn.DataPropertyName = "HASTEPOSTA";
            this.hASTEPOSTADataGridViewTextBoxColumn.HeaderText = "HASTA EPOSTA";
            this.hASTEPOSTADataGridViewTextBoxColumn.Name = "hASTEPOSTADataGridViewTextBoxColumn";
            // 
            // DOKTOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 680);
            this.Controls.Add(this.tabControl1);
            this.Name = "DOKTOR";
            this.Text = "DOKTOR";
            this.Load += new System.EventHandler(this.DOKTOR_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDOKRAPORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHASTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRandevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPORDISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPORTEDAVIDataGridViewTextBoxColumn;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource pROJDOKRAPORBindingSource;
        private DataSet4TableAdapters.PROJ_DOKRAPORTableAdapter pROJ_DOKRAPORTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewRandevuLst;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource pROJHASTABindingSource;
        private DataSet5TableAdapters.PROJ_HASTATableAdapter pROJ_HASTATableAdapter;
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
    }
}