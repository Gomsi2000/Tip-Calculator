namespace Tip_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totaltip = new System.Windows.Forms.Label();
            this.totalbill = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.minustip = new System.Windows.Forms.Button();
            this.plustip = new System.Windows.Forms.Button();
            this.people = new System.Windows.Forms.TextBox();
            this.minuspeople = new System.Windows.Forms.Button();
            this.pluspeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bill Per Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // totaltip
            // 
            this.totaltip.AutoSize = true;
            this.totaltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltip.Location = new System.Drawing.Point(518, 47);
            this.totaltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totaltip.Name = "totaltip";
            this.totaltip.Size = new System.Drawing.Size(0, 29);
            this.totaltip.TabIndex = 7;
            // 
            // totalbill
            // 
            this.totalbill.AutoSize = true;
            this.totalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbill.Location = new System.Drawing.Point(520, 167);
            this.totalbill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalbill.Name = "totalbill";
            this.totalbill.Size = new System.Drawing.Size(0, 39);
            this.totalbill.TabIndex = 8;
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(17, 58);
            this.bill.Multiline = true;
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(160, 34);
            this.bill.TabIndex = 9;
            this.bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bill_KeyPress);
            // 
            // tip
            // 
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.Location = new System.Drawing.Point(46, 150);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Size = new System.Drawing.Size(89, 34);
            this.tip.TabIndex = 11;
            this.tip.Text = "0%";
            this.tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // minustip
            // 
            this.minustip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minustip.Location = new System.Drawing.Point(12, 150);
            this.minustip.Name = "minustip";
            this.minustip.Size = new System.Drawing.Size(37, 34);
            this.minustip.TabIndex = 12;
            this.minustip.Text = "-";
            this.minustip.UseVisualStyleBackColor = true;
            this.minustip.Click += new System.EventHandler(this.button1_Click);
            // 
            // plustip
            // 
            this.plustip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plustip.Location = new System.Drawing.Point(135, 150);
            this.plustip.Name = "plustip";
            this.plustip.Size = new System.Drawing.Size(37, 34);
            this.plustip.TabIndex = 13;
            this.plustip.Text = "+";
            this.plustip.UseVisualStyleBackColor = true;
            this.plustip.Click += new System.EventHandler(this.plustip_Click);
            // 
            // people
            // 
            this.people.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people.Location = new System.Drawing.Point(46, 250);
            this.people.Multiline = true;
            this.people.Name = "people";
            this.people.ReadOnly = true;
            this.people.Size = new System.Drawing.Size(89, 34);
            this.people.TabIndex = 14;
            this.people.Text = "1";
            this.people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuspeople
            // 
            this.minuspeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuspeople.Location = new System.Drawing.Point(12, 250);
            this.minuspeople.Name = "minuspeople";
            this.minuspeople.Size = new System.Drawing.Size(37, 34);
            this.minuspeople.TabIndex = 15;
            this.minuspeople.Text = "-";
            this.minuspeople.UseVisualStyleBackColor = true;
            this.minuspeople.Click += new System.EventHandler(this.minuspeople_Click);
            // 
            // pluspeople
            // 
            this.pluspeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluspeople.Location = new System.Drawing.Point(135, 250);
            this.pluspeople.Name = "pluspeople";
            this.pluspeople.Size = new System.Drawing.Size(37, 34);
            this.pluspeople.TabIndex = 16;
            this.pluspeople.Text = "+";
            this.pluspeople.UseVisualStyleBackColor = true;
            this.pluspeople.Click += new System.EventHandler(this.pluspeople_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 323);
            this.Controls.Add(this.pluspeople);
            this.Controls.Add(this.minuspeople);
            this.Controls.Add(this.people);
            this.Controls.Add(this.plustip);
            this.Controls.Add(this.minustip);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.totalbill);
            this.Controls.Add(this.totaltip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totaltip;
        private System.Windows.Forms.Label totalbill;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button minustip;
        private System.Windows.Forms.Button plustip;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Button minuspeople;
        private System.Windows.Forms.Button pluspeople;
    }
}

