namespace QuanLyQuanNetBTL
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btTIm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nạpTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tênAzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tênZaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giờChơiBéĐếnLớnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giờChơiLớnĐếnBéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btThem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ZapfHumnst Dm BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quán net ZingNing";
            // 
            // btThem
            // 
            this.btThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btThem.Location = new System.Drawing.Point(638, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(159, 73);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Tạo tài khoản";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btTIm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(523, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(170, 22);
            this.txtTim.TabIndex = 1;
            // 
            // btTIm
            // 
            this.btTIm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTIm.Location = new System.Drawing.Point(713, 33);
            this.btTIm.Name = "btTIm";
            this.btTIm.Size = new System.Drawing.Size(75, 23);
            this.btTIm.TabIndex = 0;
            this.btTIm.Text = "Tìm";
            this.btTIm.UseVisualStyleBackColor = true;
            this.btTIm.Click += new System.EventHandler(this.btTIm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.taikhoan,
            this.matkhau,
            this.Column4,
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 291);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // taikhoan
            // 
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            // 
            // matkhau
            // 
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giờ chơi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nạpTiềnToolStripMenuItem,
            this.sửaThôngTinToolStripMenuItem,
            this.xóaTàiKhoảnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 76);
            // 
            // nạpTiềnToolStripMenuItem
            // 
            this.nạpTiềnToolStripMenuItem.Name = "nạpTiềnToolStripMenuItem";
            this.nạpTiềnToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.nạpTiềnToolStripMenuItem.Text = "Nạp tiền";
            this.nạpTiềnToolStripMenuItem.Click += new System.EventHandler(this.nạpTiềnToolStripMenuItem_Click);
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.sửaThôngTinToolStripMenuItem.Text = "Sửa thông tin";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiKhoảnToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 159);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lọcToolStripMenuItem
            // 
            this.lọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tênAzToolStripMenuItem,
            this.tênZaToolStripMenuItem,
            this.giờChơiBéĐếnLớnToolStripMenuItem,
            this.giờChơiLớnĐếnBéToolStripMenuItem});
            this.lọcToolStripMenuItem.Name = "lọcToolStripMenuItem";
            this.lọcToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.lọcToolStripMenuItem.Text = "Lọc";
            // 
            // tênAzToolStripMenuItem
            // 
            this.tênAzToolStripMenuItem.Name = "tênAzToolStripMenuItem";
            this.tênAzToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tênAzToolStripMenuItem.Text = "Tên a->z";
            this.tênAzToolStripMenuItem.Click += new System.EventHandler(this.tênAzToolStripMenuItem_Click);
            // 
            // tênZaToolStripMenuItem
            // 
            this.tênZaToolStripMenuItem.Name = "tênZaToolStripMenuItem";
            this.tênZaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tênZaToolStripMenuItem.Text = "Tên z->a";
            this.tênZaToolStripMenuItem.Click += new System.EventHandler(this.tênZaToolStripMenuItem_Click);
            // 
            // giờChơiBéĐếnLớnToolStripMenuItem
            // 
            this.giờChơiBéĐếnLớnToolStripMenuItem.Name = "giờChơiBéĐếnLớnToolStripMenuItem";
            this.giờChơiBéĐếnLớnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giờChơiBéĐếnLớnToolStripMenuItem.Text = "Giờ chơi bé đến lớn";
            this.giờChơiBéĐếnLớnToolStripMenuItem.Click += new System.EventHandler(this.giờChơiBéĐếnLớnToolStripMenuItem_Click);
            // 
            // giờChơiLớnĐếnBéToolStripMenuItem
            // 
            this.giờChơiLớnĐếnBéToolStripMenuItem.Name = "giờChơiLớnĐếnBéToolStripMenuItem";
            this.giờChơiLớnĐếnBéToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giờChơiLớnĐếnBéToolStripMenuItem.Text = "Giờ chơi lớn đến bé";
            this.giờChơiLớnĐếnBéToolStripMenuItem.Click += new System.EventHandler(this.giờChơiLớnĐếnBéToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý quán net ZingNing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btTIm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nạpTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tênAzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tênZaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giờChơiBéĐếnLớnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giờChơiLớnĐếnBéToolStripMenuItem;
    }
}

