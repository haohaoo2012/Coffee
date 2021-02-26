namespace coffee
{
    partial class mon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.dataGridViewmon = new System.Windows.Forms.DataGridView();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new coffee.CafeDataSet();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.Món = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monTableAdapter = new coffee.CafeDataSetTableAdapters.monTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btthem);
            this.panel2.Location = new System.Drawing.Point(602, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 52);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(370, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(252, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(136, 12);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(98, 37);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmon
            // 
            this.txtmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmon.Location = new System.Drawing.Point(752, 210);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(236, 24);
            this.txtmon.TabIndex = 6;
            // 
            // dataGridViewmon
            // 
            this.dataGridViewmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmon.Location = new System.Drawing.Point(1, 12);
            this.dataGridViewmon.Name = "dataGridViewmon";
            this.dataGridViewmon.RowHeadersWidth = 51;
            this.dataGridViewmon.RowTemplate.Height = 24;
            this.dataGridViewmon.Size = new System.Drawing.Size(553, 462);
            this.dataGridViewmon.TabIndex = 7;
            this.dataGridViewmon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmon_CellContentClick);
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "mon";
            this.monBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtm
            // 
            this.txtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtm.Location = new System.Drawing.Point(752, 273);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(236, 24);
            this.txtm.TabIndex = 8;
            // 
            // txtl
            // 
            this.txtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl.Location = new System.Drawing.Point(752, 334);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(236, 24);
            this.txtl.TabIndex = 9;
            // 
            // Món
            // 
            this.Món.AutoSize = true;
            this.Món.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Món.Location = new System.Drawing.Point(660, 210);
            this.Món.Name = "Món";
            this.Món.Size = new System.Drawing.Size(60, 23);
            this.Món.TabIndex = 10;
            this.Món.Text = "Món :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá M :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá L :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(649, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 95);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách Món";
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1136, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Món);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.dataGridViewmon);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.panel2);
            this.Name = "mon";
            this.Text = "mon";
            this.Load += new System.EventHandler(this.mon_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btthem;
       
        
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.DataGridView dataGridViewmon;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label Món;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource monBindingSource;
        private CafeDataSetTableAdapters.monTableAdapter monTableAdapter;
    }
}