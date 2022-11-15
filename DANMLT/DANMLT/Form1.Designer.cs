namespace DANMLT
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.Label();
            this.TH = new System.Windows.Forms.Label();
            this.NSX = new System.Windows.Forms.Label();
            this.HSD = new System.Windows.Forms.Label();
            this.LH = new System.Windows.Forms.Label();
            this.mhText = new System.Windows.Forms.TextBox();
            this.thText = new System.Windows.Forms.TextBox();
            this.nsxText = new System.Windows.Forms.TextBox();
            this.hsdText = new System.Windows.Forms.TextBox();
            this.lhText = new System.Windows.Forms.TextBox();
            this.them_mhBtn = new System.Windows.Forms.Button();
            this.searchMHText = new System.Windows.Forms.TextBox();
            this.searchMHBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.them_lhBtn = new System.Windows.Forms.Button();
            this.ListLHBtn = new System.Windows.Forms.Button();
            this.listMHBtn = new System.Windows.Forms.Button();
            this.searchLHText = new System.Windows.Forms.TextBox();
            this.searchLHBtn = new System.Windows.Forms.Button();
            this.suaText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MH
            // 
            this.MH.AutoSize = true;
            this.MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH.Location = new System.Drawing.Point(12, 24);
            this.MH.Name = "MH";
            this.MH.Size = new System.Drawing.Size(74, 20);
            this.MH.TabIndex = 1;
            this.MH.Text = "Mã Hàng";
            // 
            // TH
            // 
            this.TH.AutoSize = true;
            this.TH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH.Location = new System.Drawing.Point(12, 60);
            this.TH.Name = "TH";
            this.TH.Size = new System.Drawing.Size(79, 20);
            this.TH.TabIndex = 2;
            this.TH.Text = "Tên Hàng";
            // 
            // NSX
            // 
            this.NSX.AutoSize = true;
            this.NSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSX.Location = new System.Drawing.Point(12, 94);
            this.NSX.Name = "NSX";
            this.NSX.Size = new System.Drawing.Size(42, 20);
            this.NSX.TabIndex = 3;
            this.NSX.Text = "NSX";
            // 
            // HSD
            // 
            this.HSD.AutoSize = true;
            this.HSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSD.Location = new System.Drawing.Point(12, 125);
            this.HSD.Name = "HSD";
            this.HSD.Size = new System.Drawing.Size(44, 20);
            this.HSD.TabIndex = 4;
            this.HSD.Text = "HSD";
            // 
            // LH
            // 
            this.LH.AutoSize = true;
            this.LH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LH.Location = new System.Drawing.Point(12, 195);
            this.LH.Name = "LH";
            this.LH.Size = new System.Drawing.Size(82, 20);
            this.LH.TabIndex = 5;
            this.LH.Text = "Loại Hàng";
            // 
            // mhText
            // 
            this.mhText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhText.Location = new System.Drawing.Point(111, 22);
            this.mhText.Name = "mhText";
            this.mhText.Size = new System.Drawing.Size(149, 26);
            this.mhText.TabIndex = 6;
            // 
            // thText
            // 
            this.thText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thText.Location = new System.Drawing.Point(111, 54);
            this.thText.Name = "thText";
            this.thText.Size = new System.Drawing.Size(149, 26);
            this.thText.TabIndex = 7;
            // 
            // nsxText
            // 
            this.nsxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsxText.Location = new System.Drawing.Point(111, 86);
            this.nsxText.Name = "nsxText";
            this.nsxText.Size = new System.Drawing.Size(149, 26);
            this.nsxText.TabIndex = 8;
            // 
            // hsdText
            // 
            this.hsdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsdText.Location = new System.Drawing.Point(111, 119);
            this.hsdText.Name = "hsdText";
            this.hsdText.Size = new System.Drawing.Size(149, 26);
            this.hsdText.TabIndex = 9;
            // 
            // lhText
            // 
            this.lhText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhText.Location = new System.Drawing.Point(111, 189);
            this.lhText.Name = "lhText";
            this.lhText.Size = new System.Drawing.Size(149, 26);
            this.lhText.TabIndex = 10;
            // 
            // them_mhBtn
            // 
            this.them_mhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_mhBtn.Location = new System.Drawing.Point(266, 21);
            this.them_mhBtn.Name = "them_mhBtn";
            this.them_mhBtn.Size = new System.Drawing.Size(99, 28);
            this.them_mhBtn.TabIndex = 11;
            this.them_mhBtn.Text = "Thêm MH";
            this.them_mhBtn.UseVisualStyleBackColor = true;
            // 
            // searchMHText
            // 
            this.searchMHText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMHText.Location = new System.Drawing.Point(460, 12);
            this.searchMHText.Name = "searchMHText";
            this.searchMHText.Size = new System.Drawing.Size(149, 26);
            this.searchMHText.TabIndex = 12;
            // 
            // searchMHBtn
            // 
            this.searchMHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMHBtn.Location = new System.Drawing.Point(615, 10);
            this.searchMHBtn.Name = "searchMHBtn";
            this.searchMHBtn.Size = new System.Drawing.Size(139, 28);
            this.searchMHBtn.TabIndex = 13;
            this.searchMHBtn.Text = "Tìm Kiếm MH";
            this.searchMHBtn.UseVisualStyleBackColor = true;
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(615, 94);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(139, 28);
            this.suaBtn.TabIndex = 14;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(655, 239);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(99, 28);
            this.xoaBtn.TabIndex = 15;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // them_lhBtn
            // 
            this.them_lhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_lhBtn.Location = new System.Drawing.Point(266, 187);
            this.them_lhBtn.Name = "them_lhBtn";
            this.them_lhBtn.Size = new System.Drawing.Size(99, 28);
            this.them_lhBtn.TabIndex = 16;
            this.them_lhBtn.Text = "Thêm LH";
            this.them_lhBtn.UseVisualStyleBackColor = true;
            this.them_lhBtn.Click += new System.EventHandler(this.them_lhBtn_Click);
            // 
            // ListLHBtn
            // 
            this.ListLHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLHBtn.Location = new System.Drawing.Point(0, 239);
            this.ListLHBtn.Name = "ListLHBtn";
            this.ListLHBtn.Size = new System.Drawing.Size(99, 28);
            this.ListLHBtn.TabIndex = 17;
            this.ListLHBtn.Text = "List LH";
            this.ListLHBtn.UseVisualStyleBackColor = true;
            this.ListLHBtn.Click += new System.EventHandler(this.ListLHBtn_Click);
            // 
            // listMHBtn
            // 
            this.listMHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMHBtn.Location = new System.Drawing.Point(105, 239);
            this.listMHBtn.Name = "listMHBtn";
            this.listMHBtn.Size = new System.Drawing.Size(99, 28);
            this.listMHBtn.TabIndex = 18;
            this.listMHBtn.Text = "List MH";
            this.listMHBtn.UseVisualStyleBackColor = true;
            // 
            // searchLHText
            // 
            this.searchLHText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLHText.Location = new System.Drawing.Point(460, 54);
            this.searchLHText.Name = "searchLHText";
            this.searchLHText.Size = new System.Drawing.Size(149, 26);
            this.searchLHText.TabIndex = 19;
            // 
            // searchLHBtn
            // 
            this.searchLHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLHBtn.Location = new System.Drawing.Point(615, 56);
            this.searchLHBtn.Name = "searchLHBtn";
            this.searchLHBtn.Size = new System.Drawing.Size(139, 28);
            this.searchLHBtn.TabIndex = 20;
            this.searchLHBtn.Text = "Tìm Kiếm LH";
            this.searchLHBtn.UseVisualStyleBackColor = true;
            this.searchLHBtn.Click += new System.EventHandler(this.searchLHBtn_Click);
            // 
            // suaText
            // 
            this.suaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaText.Location = new System.Drawing.Point(460, 94);
            this.suaText.Name = "suaText";
            this.suaText.Size = new System.Drawing.Size(149, 26);
            this.suaText.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 571);
            this.Controls.Add(this.suaText);
            this.Controls.Add(this.searchLHBtn);
            this.Controls.Add(this.searchLHText);
            this.Controls.Add(this.listMHBtn);
            this.Controls.Add(this.ListLHBtn);
            this.Controls.Add(this.them_lhBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.searchMHBtn);
            this.Controls.Add(this.searchMHText);
            this.Controls.Add(this.them_mhBtn);
            this.Controls.Add(this.lhText);
            this.Controls.Add(this.hsdText);
            this.Controls.Add(this.nsxText);
            this.Controls.Add(this.thText);
            this.Controls.Add(this.mhText);
            this.Controls.Add(this.LH);
            this.Controls.Add(this.HSD);
            this.Controls.Add(this.NSX);
            this.Controls.Add(this.TH);
            this.Controls.Add(this.MH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MH;
        private System.Windows.Forms.Label TH;
        private System.Windows.Forms.Label NSX;
        private System.Windows.Forms.Label HSD;
        private System.Windows.Forms.Label LH;
        private System.Windows.Forms.TextBox mhText;
        private System.Windows.Forms.TextBox thText;
        private System.Windows.Forms.TextBox nsxText;
        private System.Windows.Forms.TextBox hsdText;
        private System.Windows.Forms.TextBox lhText;
        private System.Windows.Forms.Button them_mhBtn;
        private System.Windows.Forms.TextBox searchMHText;
        private System.Windows.Forms.Button searchMHBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button them_lhBtn;
        private System.Windows.Forms.Button ListLHBtn;
        private System.Windows.Forms.Button listMHBtn;
        private System.Windows.Forms.TextBox searchLHText;
        private System.Windows.Forms.Button searchLHBtn;
        private System.Windows.Forms.TextBox suaText;
    }
}

