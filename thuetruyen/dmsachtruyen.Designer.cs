
namespace thuetruyen
{
    partial class dmsachtruyen
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbonxb = new System.Windows.Forms.ComboBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiasach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrsachtruyen = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lbltenthu = new System.Windows.Forms.Label();
            this.lblmaloai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrsachtruyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 119;
            // 
            // cbonxb
            // 
            this.cbonxb.FormattingEnabled = true;
            this.cbonxb.Location = new System.Drawing.Point(460, 161);
            this.cbonxb.Name = "cbonxb";
            this.cbonxb.Size = new System.Drawing.Size(155, 24);
            this.cbonxb.TabIndex = 118;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(460, 125);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(155, 22);
            this.txttensach.TabIndex = 117;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(460, 202);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(155, 22);
            this.txtsoluong.TabIndex = 116;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // txtgiasach
            // 
            this.txtgiasach.Location = new System.Drawing.Point(460, 241);
            this.txtgiasach.Name = "txtgiasach";
            this.txtgiasach.Size = new System.Drawing.Size(155, 22);
            this.txtgiasach.TabIndex = 115;
            this.txtgiasach.TextChanged += new System.EventHandler(this.txtgiasach_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Giá sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "Số lượng";
            // 
            // dtgrsachtruyen
            // 
            this.dtgrsachtruyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrsachtruyen.Location = new System.Drawing.Point(110, 318);
            this.dtgrsachtruyen.Name = "dtgrsachtruyen";
            this.dtgrsachtruyen.RowHeadersWidth = 51;
            this.dtgrsachtruyen.RowTemplate.Height = 24;
            this.dtgrsachtruyen.Size = new System.Drawing.Size(935, 146);
            this.dtgrsachtruyen.TabIndex = 111;
            this.dtgrsachtruyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrsachtruyen_CellContentClick);
            this.dtgrsachtruyen.Click += new System.EventHandler(this.dtgrsachtruyen_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(796, 482);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 110;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(673, 482);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 109;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(552, 482);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 108;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(445, 482);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 107;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(331, 482);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 106;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(224, 482);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 105;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(460, 88);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(155, 22);
            this.txtmasach.TabIndex = 104;
            // 
            // lbltenthu
            // 
            this.lbltenthu.AutoSize = true;
            this.lbltenthu.Location = new System.Drawing.Point(374, 125);
            this.lbltenthu.Name = "lbltenthu";
            this.lbltenthu.Size = new System.Drawing.Size(67, 17);
            this.lbltenthu.TabIndex = 103;
            this.lbltenthu.Text = "Tên sách";
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(375, 164);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(36, 17);
            this.lblmaloai.TabIndex = 102;
            this.lblmaloai.Text = "NXB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 59);
            this.label1.TabIndex = 101;
            this.label1.Text = "DANH MỤC SÁCH TRUYỆN";
            // 
            // dmsachtruyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbonxb);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtgiasach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrsachtruyen);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lbltenthu);
            this.Controls.Add(this.lblmaloai);
            this.Controls.Add(this.label1);
            this.Name = "dmsachtruyen";
            this.Text = "Danh mục sách truyện";
            this.Load += new System.EventHandler(this.dmsachtruyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrsachtruyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbonxb;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiasach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrsachtruyen;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lbltenthu;
        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.Label label1;
    }
}

