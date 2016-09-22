namespace Array
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(99, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(407, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array input";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(99, 87);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(407, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(36, 186);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(137, 186);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(235, 186);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(332, 186);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 7;
            this.btnAsc.Text = "Ascending";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(325, 138);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(100, 20);
            this.txtRandom.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(431, 135);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(431, 186);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(75, 23);
            this.btnDes.TabIndex = 8;
            this.btnDes.Text = "Desending";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
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
            this.cmbEdit.Location = new System.Drawing.Point(99, 142);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbEdit.TabIndex = 13;
            this.cmbEdit.Text = "1";
            this.cmbEdit.SelectedIndexChanged += new System.EventHandler(this.cmbEdit_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.cmbEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mảng số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEdit;
    }
}

