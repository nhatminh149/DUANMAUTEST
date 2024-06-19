namespace DUANMAUTEST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            texTim = new TextBox();
            texNgay14 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            texLoai14 = new TextBox();
            texMo14 = new TextBox();
            texTen14 = new TextBox();
            groupBox2 = new GroupBox();
            butThem = new Button();
            butSua = new Button();
            butXoa = new Button();
            butClear = new Button();
            butHienThi = new Button();
            dtgv = new DataGridView();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(texTim);
            groupBox1.Controls.Add(texNgay14);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(texLoai14);
            groupBox1.Controls.Add(texMo14);
            groupBox1.Controls.Add(texTen14);
            groupBox1.Location = new Point(14, 25);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(720, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 241);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 11;
            label3.Text = "Loại hàng";
            // 
            // texTim
            // 
            texTim.Location = new Point(135, 393);
            texTim.Name = "texTim";
            texTim.PlaceholderText = "Tìm kiếm";
            texTim.Size = new Size(474, 47);
            texTim.TabIndex = 10;
            texTim.TextChanged += texTim_TextChanged;
            // 
            // texNgay14
            // 
            texNgay14.Location = new Point(134, 312);
            texNgay14.Name = "texNgay14";
            texNgay14.Size = new Size(475, 47);
            texNgay14.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 315);
            label4.Name = "label4";
            label4.Size = new Size(192, 41);
            label4.TabIndex = 8;
            label4.Text = "Ngày đăng kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 167);
            label2.Name = "label2";
            label2.Size = new Size(93, 41);
            label2.TabIndex = 6;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 107);
            label1.Name = "label1";
            label1.Size = new Size(66, 41);
            label1.TabIndex = 5;
            label1.Text = "Tên";
            // 
            // texLoai14
            // 
            texLoai14.Location = new Point(134, 242);
            texLoai14.Margin = new Padding(3, 4, 3, 4);
            texLoai14.Name = "texLoai14";
            texLoai14.Size = new Size(475, 47);
            texLoai14.TabIndex = 2;
            // 
            // texMo14
            // 
            texMo14.Location = new Point(134, 164);
            texMo14.Margin = new Padding(3, 4, 3, 4);
            texMo14.Name = "texMo14";
            texMo14.Size = new Size(475, 47);
            texMo14.TabIndex = 1;
            // 
            // texTen14
            // 
            texTen14.Location = new Point(134, 104);
            texTen14.Margin = new Padding(3, 4, 3, 4);
            texTen14.Name = "texTen14";
            texTen14.Size = new Size(475, 47);
            texTen14.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(butThem);
            groupBox2.Controls.Add(butSua);
            groupBox2.Controls.Add(butXoa);
            groupBox2.Controls.Add(butClear);
            groupBox2.Controls.Add(butHienThi);
            groupBox2.Location = new Point(759, 25);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(779, 488);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // butThem
            // 
            butThem.Location = new Point(25, 132);
            butThem.Margin = new Padding(3, 4, 3, 4);
            butThem.Name = "butThem";
            butThem.Size = new Size(740, 66);
            butThem.TabIndex = 4;
            butThem.Text = "Thêm ";
            butThem.UseVisualStyleBackColor = true;
            butThem.Click += butThem_Click;
            // 
            // butSua
            // 
            butSua.Location = new Point(25, 198);
            butSua.Margin = new Padding(3, 4, 3, 4);
            butSua.Name = "butSua";
            butSua.Size = new Size(740, 63);
            butSua.TabIndex = 3;
            butSua.Text = "Sửa";
            butSua.UseVisualStyleBackColor = true;
            butSua.Click += butSua_Click;
            // 
            // butXoa
            // 
            butXoa.Location = new Point(25, 261);
            butXoa.Margin = new Padding(3, 4, 3, 4);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(740, 69);
            butXoa.TabIndex = 2;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            butXoa.Click += butXoa_Click;
            // 
            // butClear
            // 
            butClear.Location = new Point(25, 330);
            butClear.Margin = new Padding(3, 4, 3, 4);
            butClear.Name = "butClear";
            butClear.Size = new Size(740, 67);
            butClear.TabIndex = 1;
            butClear.Text = "Clear";
            butClear.UseVisualStyleBackColor = true;
            butClear.Click += butClear_Click;
            // 
            // butHienThi
            // 
            butHienThi.Location = new Point(25, 62);
            butHienThi.Margin = new Padding(3, 4, 3, 4);
            butHienThi.Name = "butHienThi";
            butHienThi.Size = new Size(740, 70);
            butHienThi.TabIndex = 0;
            butHienThi.Text = "Hiển thị thông tin";
            butHienThi.UseVisualStyleBackColor = true;
            butHienThi.Click += butHienThi_Click;
            // 
            // dtgv
            // 
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Location = new Point(12, 595);
            dtgv.Margin = new Padding(3, 4, 3, 4);
            dtgv.Name = "dtgv";
            dtgv.RowHeadersWidth = 82;
            dtgv.Size = new Size(1526, 378);
            dtgv.TabIndex = 2;
            dtgv.CellClick += dtgv_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(710, 531);
            label6.Name = "label6";
            label6.Size = new Size(98, 41);
            label6.TabIndex = 3;
            label6.Text = "BẢNG";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 986);
            Controls.Add(label6);
            Controls.Add(dtgv);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox texTuoi;
        private TextBox texMau;
        private TextBox texLoai14;
        private TextBox texMo14;
        private TextBox texTen14;
        private GroupBox groupBox2;
        private Button butThem;
        private Button butSua;
        private Button butXoa;
        private Button butClear;
        private Button butHienThi;
        private DataGridView dtgv;
        private Label label6;
        private TextBox texNgay14;
        private TextBox texTim;
        private Label label3;
    }
}
