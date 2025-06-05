namespace QuanLyQuanNetBTL
{
    partial class FormNap
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFNHUY = new System.Windows.Forms.Button();
            this.btFNOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGio, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ chơi";
            // 
            // txtTien
            // 
            this.txtTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTien.Location = new System.Drawing.Point(190, 3);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(182, 22);
            this.txtTien.TabIndex = 2;
            // 
            // txtGio
            // 
            this.txtGio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGio.Location = new System.Drawing.Point(190, 64);
            this.txtGio.Name = "txtGio";
            this.txtGio.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(182, 22);
            this.txtGio.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btFNHUY);
            this.panel1.Controls.Add(this.btFNOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 102);
            this.panel1.TabIndex = 1;
            // 
            // btFNHUY
            // 
            this.btFNHUY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFNHUY.Location = new System.Drawing.Point(275, 24);
            this.btFNHUY.Name = "btFNHUY";
            this.btFNHUY.Size = new System.Drawing.Size(88, 43);
            this.btFNHUY.TabIndex = 1;
            this.btFNHUY.Text = "Cancel";
            this.btFNHUY.UseVisualStyleBackColor = true;
            // 
            // btFNOK
            // 
            this.btFNOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFNOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFNOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFNOK.Location = new System.Drawing.Point(177, 24);
            this.btFNOK.Name = "btFNOK";
            this.btFNOK.Size = new System.Drawing.Size(88, 43);
            this.btFNOK.TabIndex = 0;
            this.btFNOK.Text = "OK";
            this.btFNOK.UseVisualStyleBackColor = false;
            this.btFNOK.Click += new System.EventHandler(this.btFNOK_Click);
            // 
            // FormNap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNap";
            this.Text = "Nạp tiền";
            this.Load += new System.EventHandler(this.FormNap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFNHUY;
        private System.Windows.Forms.Button btFNOK;
    }
}