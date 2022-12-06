namespace WindowsFormsApp2
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
            this.exit = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.deCode = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.coun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randomkey = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(645, 247);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(99, 43);
            this.exit.TabIndex = 0;
            this.exit.Text = "thoat";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(192, 57);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(570, 41);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "Key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deCode
            // 
            this.deCode.Location = new System.Drawing.Point(42, 247);
            this.deCode.Name = "deCode";
            this.deCode.Size = new System.Drawing.Size(92, 41);
            this.deCode.TabIndex = 4;
            this.deCode.Text = "Ma hoa";
            this.deCode.UseVisualStyleBackColor = true;
            this.deCode.Click += new System.EventHandler(this.deCode_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Giai ma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(442, 247);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(92, 41);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "Xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 41);
            this.button6.TabIndex = 7;
            this.button6.Text = "load file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(129, 315);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(633, 50);
            this.output.TabIndex = 9;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(565, 137);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyTextBox.Size = new System.Drawing.Size(179, 88);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // coun
            // 
            this.coun.Location = new System.Drawing.Point(231, 158);
            this.coun.Multiline = true;
            this.coun.Name = "coun";
            this.coun.Size = new System.Drawing.Size(53, 41);
            this.coun.TabIndex = 10;
            this.coun.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "nhâp bac cua ma tran: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "nhập phần tử của ma trận n*n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đoạn text muốn mã hóa hoặc giải mã (không có khoảng trống)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "kết quả";
            // 
            // randomkey
            // 
            this.randomkey.Location = new System.Drawing.Point(458, 165);
            this.randomkey.Name = "randomkey";
            this.randomkey.Size = new System.Drawing.Size(101, 34);
            this.randomkey.TabIndex = 15;
            this.randomkey.Text = "random key";
            this.randomkey.UseVisualStyleBackColor = true;
            this.randomkey.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(129, 383);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(633, 55);
            this.save.TabIndex = 16;
            this.save.Text = "luu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.randomkey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coun);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.deCode);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Hill_Cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit_x);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deCode;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox coun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button randomkey;
        private System.Windows.Forms.Button save;
    }
}

