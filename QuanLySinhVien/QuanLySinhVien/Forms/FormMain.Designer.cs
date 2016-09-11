namespace QuanLySinhVien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcBổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trơGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.imgList_Large = new System.Windows.Forms.ImageList(this.components);
            this.imgList_Small = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiYeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBtn_Nu = new System.Windows.Forms.RadioButton();
            this.radBtn_Nam = new System.Windows.Forms.RadioButton();
            this.chk_Khong = new System.Windows.Forms.CheckBox();
            this.chk_Co = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolSB_Them = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolSB_Capnhat = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hêThôngToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.trơGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lớnToolStripMenuItem,
            this.nhỏToolStripMenuItem});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.thoátToolStripMenuItem.Text = "Hiển thị danh sách";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lớnToolStripMenuItem
            // 
            this.lớnToolStripMenuItem.Name = "lớnToolStripMenuItem";
            this.lớnToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.lớnToolStripMenuItem.Text = "Lớn";
            this.lớnToolStripMenuItem.Click += new System.EventHandler(this.lớnToolStripMenuItem_Click);
            // 
            // nhỏToolStripMenuItem
            // 
            this.nhỏToolStripMenuItem.Name = "nhỏToolStripMenuItem";
            this.nhỏToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.nhỏToolStripMenuItem.Text = "Nhỏ";
            this.nhỏToolStripMenuItem.Click += new System.EventHandler(this.nhỏToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.họcBổngToolStripMenuItem,
            this.điểmToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sinhViênToolStripMenuItem.Text = "Thông tin";
            // 
            // họcBổngToolStripMenuItem
            // 
            this.họcBổngToolStripMenuItem.Name = "họcBổngToolStripMenuItem";
            this.họcBổngToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.họcBổngToolStripMenuItem.Text = "Học bổng";
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.điểmToolStripMenuItem.Text = "Điểm ";
            // 
            // trơGiupToolStripMenuItem
            // 
            this.trơGiupToolStripMenuItem.Name = "trơGiupToolStripMenuItem";
            this.trơGiupToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trơGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(999, 602);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 602);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh đại diện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstView.LargeImageList = this.imgList_Large;
            this.lstView.Location = new System.Drawing.Point(3, 16);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(214, 583);
            this.lstView.SmallImageList = this.imgList_Small;
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imgList_Large
            // 
            this.imgList_Large.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Large.ImageStream")));
            this.imgList_Large.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Large.Images.SetKeyName(0, "1.jpg");
            this.imgList_Large.Images.SetKeyName(1, "2.jpg");
            this.imgList_Large.Images.SetKeyName(2, "4.jpg");
            this.imgList_Large.Images.SetKeyName(3, "5.png");
            this.imgList_Large.Images.SetKeyName(4, "6.jpg");
            this.imgList_Large.Images.SetKeyName(5, "7.jpg");
            this.imgList_Large.Images.SetKeyName(6, "8.jpg");
            this.imgList_Large.Images.SetKeyName(7, "9.jpg");
            this.imgList_Large.Images.SetKeyName(8, "10.jpg");
            // 
            // imgList_Small
            // 
            this.imgList_Small.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList_Small.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList_Small.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 337);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.HoTen,
            this.Lop,
            this.ngaySinh,
            this.gioiTinh,
            this.queQuan,
            this.diemTB,
            this.nguoiYeu});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(779, 318);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // maSV
            // 
            this.maSV.HeaderText = "Mã SV";
            this.maSV.Name = "maSV";
            this.maSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // queQuan
            // 
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.Name = "queQuan";
            this.queQuan.ReadOnly = true;
            // 
            // diemTB
            // 
            this.diemTB.HeaderText = "Điểm TB";
            this.diemTB.Name = "diemTB";
            this.diemTB.ReadOnly = true;
            // 
            // nguoiYeu
            // 
            this.nguoiYeu.HeaderText = "Người yêu";
            this.nguoiYeu.Name = "nguoiYeu";
            this.nguoiYeu.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtn_Nu);
            this.groupBox2.Controls.Add(this.radBtn_Nam);
            this.groupBox2.Controls.Add(this.chk_Khong);
            this.groupBox2.Controls.Add(this.chk_Co);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDiem);
            this.groupBox2.Controls.Add(this.txtQue);
            this.groupBox2.Controls.Add(this.dateTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKhoa);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.toolStrip);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radBtn_Nu
            // 
            this.radBtn_Nu.AutoSize = true;
            this.radBtn_Nu.Location = new System.Drawing.Point(537, 63);
            this.radBtn_Nu.Name = "radBtn_Nu";
            this.radBtn_Nu.Size = new System.Drawing.Size(39, 17);
            this.radBtn_Nu.TabIndex = 20;
            this.radBtn_Nu.TabStop = true;
            this.radBtn_Nu.Text = "Nữ";
            this.radBtn_Nu.UseVisualStyleBackColor = true;
            // 
            // radBtn_Nam
            // 
            this.radBtn_Nam.AutoSize = true;
            this.radBtn_Nam.Location = new System.Drawing.Point(458, 63);
            this.radBtn_Nam.Name = "radBtn_Nam";
            this.radBtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.radBtn_Nam.TabIndex = 19;
            this.radBtn_Nam.TabStop = true;
            this.radBtn_Nam.Text = "Nam";
            this.radBtn_Nam.UseVisualStyleBackColor = true;
            // 
            // chk_Khong
            // 
            this.chk_Khong.AutoSize = true;
            this.chk_Khong.Location = new System.Drawing.Point(537, 204);
            this.chk_Khong.Name = "chk_Khong";
            this.chk_Khong.Size = new System.Drawing.Size(57, 17);
            this.chk_Khong.TabIndex = 17;
            this.chk_Khong.Text = "Không";
            this.chk_Khong.UseVisualStyleBackColor = true;
            // 
            // chk_Co
            // 
            this.chk_Co.AutoSize = true;
            this.chk_Co.Location = new System.Drawing.Point(458, 204);
            this.chk_Co.Name = "chk_Co";
            this.chk_Co.Size = new System.Drawing.Size(39, 17);
            this.chk_Co.TabIndex = 16;
            this.chk_Co.Text = "Có";
            this.chk_Co.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Người yêu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(386, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Điểm TB";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(458, 150);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(79, 20);
            this.txtDiem.TabIndex = 8;
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(458, 106);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(231, 20);
            this.txtQue.TabIndex = 5;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(92, 198);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(108, 20);
            this.dateTime.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã SV";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ và tên";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(92, 65);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(231, 20);
            this.txtKhoa.TabIndex = 2;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(92, 150);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(108, 20);
            this.txtLop.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(92, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(231, 20);
            this.txtTen.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSB_Them,
            this.toolSB_Sua,
            this.toolSB_Xoa,
            this.toolSB_Luu,
            this.toolSB_Capnhat});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(285, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolSB_Them
            // 
            this.toolSB_Them.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Them.Image")));
            this.toolSB_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Them.Name = "toolSB_Them";
            this.toolSB_Them.Size = new System.Drawing.Size(58, 22);
            this.toolSB_Them.Text = "Thêm";
            // 
            // toolSB_Sua
            // 
            this.toolSB_Sua.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Sua.Image")));
            this.toolSB_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Sua.Name = "toolSB_Sua";
            this.toolSB_Sua.Size = new System.Drawing.Size(46, 22);
            this.toolSB_Sua.Text = "Sửa";
            this.toolSB_Sua.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolSB_Xoa
            // 
            this.toolSB_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Xoa.Image")));
            this.toolSB_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Xoa.Name = "toolSB_Xoa";
            this.toolSB_Xoa.Size = new System.Drawing.Size(47, 22);
            this.toolSB_Xoa.Text = "Xóa";
            // 
            // toolSB_Luu
            // 
            this.toolSB_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Luu.Image")));
            this.toolSB_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Luu.Name = "toolSB_Luu";
            this.toolSB_Luu.Size = new System.Drawing.Size(47, 22);
            this.toolSB_Luu.Text = "Lưu";
            // 
            // toolSB_Capnhat
            // 
            this.toolSB_Capnhat.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_Capnhat.Image")));
            this.toolSB_Capnhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_Capnhat.Name = "toolSB_Capnhat";
            this.toolSB_Capnhat.Size = new System.Drawing.Size(75, 22);
            this.toolSB_Capnhat.Text = "Cập nhật";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(999, 626);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Phần mềm quản lý sinh viên (v1.0)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolSB_Sua;
        private System.Windows.Forms.ToolStripButton toolSB_Xoa;
        private System.Windows.Forms.ToolStripButton toolSB_Capnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ToolStripButton toolSB_Them;
        private System.Windows.Forms.ToolStripButton toolSB_Luu;
        private System.Windows.Forms.RadioButton radBtn_Nu;
        private System.Windows.Forms.RadioButton radBtn_Nam;
        private System.Windows.Forms.CheckBox chk_Khong;
        private System.Windows.Forms.CheckBox chk_Co;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ToolStripMenuItem trơGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcBổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ImageList imgList_Large;
        private System.Windows.Forms.ToolStripMenuItem lớnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhỏToolStripMenuItem;
        private System.Windows.Forms.ImageList imgList_Small;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiYeu;
    }
}

