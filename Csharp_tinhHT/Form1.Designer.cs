namespace Csharp_tinhHT
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncv = new System.Windows.Forms.Button();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltinh = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hkbdt = new System.Windows.Forms.CheckBox();
            this.hkbcv = new System.Windows.Forms.CheckBox();
            this.lbltinh2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁN KÍNH";
            // 
            // btncv
            // 
            this.btncv.BackColor = System.Drawing.Color.Lime;
            this.btncv.Location = new System.Drawing.Point(61, 301);
            this.btncv.Name = "btncv";
            this.btncv.Size = new System.Drawing.Size(115, 40);
            this.btncv.TabIndex = 1;
            this.btncv.Text = "CHU VI";
            this.btncv.UseVisualStyleBackColor = false;
            this.btncv.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbchuvi.Location = new System.Drawing.Point(20, 27);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(82, 24);
            this.rdbchuvi.TabIndex = 3;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "CHU VI";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            this.rdbchuvi.CheckedChanged += new System.EventHandler(this.rdbchuvi_CheckedChanged);
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdientich.Location = new System.Drawing.Point(20, 64);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(107, 24);
            this.rdbdientich.TabIndex = 4;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "DIỆN TÍCH";
            this.rdbdientich.UseVisualStyleBackColor = true;
            this.rdbdientich.CheckedChanged += new System.EventHandler(this.rdbdientich_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.lbltinh);
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Location = new System.Drawing.Point(389, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbltinh
            // 
            this.lbltinh.AutoSize = true;
            this.lbltinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinh.Location = new System.Drawing.Point(47, 128);
            this.lbltinh.Name = "lbltinh";
            this.lbltinh.Size = new System.Drawing.Size(0, 24);
            this.lbltinh.TabIndex = 16;
            // 
            // txtR
            // 
            this.txtR.BackColor = System.Drawing.Color.Gold;
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(144, 92);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(163, 35);
            this.txtR.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(17, 195);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 24);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "KẾT QUẢ";
            this.lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(144, 184);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(220, 35);
            this.txtKQ.TabIndex = 11;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // btndt
            // 
            this.btndt.BackColor = System.Drawing.Color.Lime;
            this.btndt.Location = new System.Drawing.Point(249, 301);
            this.btndt.Name = "btndt";
            this.btndt.Size = new System.Drawing.Size(115, 40);
            this.btndt.TabIndex = 13;
            this.btndt.Text = "DIỆN TÍCH";
            this.btndt.UseVisualStyleBackColor = false;
            this.btndt.Click += new System.EventHandler(this.btndt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(810, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(440, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = " TÍNH NĂNG 1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.hkbdt);
            this.groupBox2.Controls.Add(this.hkbcv);
            this.groupBox2.Controls.Add(this.lbltinh2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(662, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 146);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // hkbdt
            // 
            this.hkbdt.AutoSize = true;
            this.hkbdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkbdt.Location = new System.Drawing.Point(33, 77);
            this.hkbdt.Name = "hkbdt";
            this.hkbdt.Size = new System.Drawing.Size(108, 24);
            this.hkbdt.TabIndex = 22;
            this.hkbdt.Text = "DIỆN TÍCH";
            this.hkbdt.UseVisualStyleBackColor = true;
            // 
            // hkbcv
            // 
            this.hkbcv.AutoSize = true;
            this.hkbcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkbcv.Location = new System.Drawing.Point(33, 33);
            this.hkbcv.Name = "hkbcv";
            this.hkbcv.Size = new System.Drawing.Size(83, 24);
            this.hkbcv.TabIndex = 21;
            this.hkbcv.Text = "CHU VI";
            this.hkbcv.UseVisualStyleBackColor = true;
            // 
            // lbltinh2
            // 
            this.lbltinh2.AutoSize = true;
            this.lbltinh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinh2.Location = new System.Drawing.Point(35, 104);
            this.lbltinh2.Name = "lbltinh2";
            this.lbltinh2.Size = new System.Drawing.Size(15, 24);
            this.lbltinh2.TabIndex = 20;
            this.lbltinh2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(713, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = " TÍNH NĂNG 2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncv;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbltinh2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hkbdt;
        private System.Windows.Forms.CheckBox hkbcv;
    }
}

