namespace Demo.Forms
{
    partial class MinhHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            this.cmbEdit2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(118, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(341, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "1,2,4,20,4,3,0,-12";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(118, 62);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(341, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(34, 150);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(74, 23);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(131, 150);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(74, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(226, 150);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(74, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(328, 150);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(74, 23);
            this.btnAsc.TabIndex = 7;
            this.btnAsc.Text = "Ascending";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(424, 150);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(74, 23);
            this.btnDes.TabIndex = 8;
            this.btnDes.Text = "Descending";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(334, 108);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(100, 20);
            this.txtRandom.TabIndex = 9;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(440, 105);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(74, 23);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cmbEdit
            // 
            this.cmbEdit.FormattingEnabled = true;
            this.cmbEdit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbEdit.Location = new System.Drawing.Point(193, 105);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbEdit.TabIndex = 11;
            this.cmbEdit.Text = "1";
            this.cmbEdit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbEdit2
            // 
            this.cmbEdit2.FormattingEnabled = true;
            this.cmbEdit2.Location = new System.Drawing.Point(34, 107);
            this.cmbEdit2.Name = "cmbEdit2";
            this.cmbEdit2.Size = new System.Drawing.Size(121, 21);
            this.cmbEdit2.TabIndex = 12;
            this.cmbEdit2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // MinhHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 196);
            this.Controls.Add(this.cmbEdit2);
            this.Controls.Add(this.cmbEdit);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MinhHang";
            this.Text = "MinhHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ComboBox cmbEdit;
        private System.Windows.Forms.ComboBox cmbEdit2;
    }
}