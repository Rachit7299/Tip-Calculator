
namespace WindowsFormsApp1
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
            this.bill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tip_perc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.no_of_people = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tip_per_person = new System.Windows.Forms.Label();
            this.tip_person = new System.Windows.Forms.Label();
            this.total_bill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tip_perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(30, 42);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(100, 20);
            this.bill.TabIndex = 1;
            this.bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            // 
            // tip_perc
            // 
            this.tip_perc.Location = new System.Drawing.Point(33, 104);
            this.tip_perc.Name = "tip_perc";
            this.tip_perc.Size = new System.Drawing.Size(120, 20);
            this.tip_perc.TabIndex = 3;
            this.tip_perc.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of People";
            // 
            // no_of_people
            // 
            this.no_of_people.Location = new System.Drawing.Point(33, 184);
            this.no_of_people.Name = "no_of_people";
            this.no_of_people.Size = new System.Drawing.Size(120, 20);
            this.no_of_people.TabIndex = 5;
            this.no_of_people.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.no_of_people.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 56);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.MinimumSize = new System.Drawing.Size(44, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 145);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.MinimumSize = new System.Drawing.Size(44, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(295, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Per Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(295, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Per Person";
            // 
            // tip_per_person
            // 
            this.tip_per_person.AutoSize = true;
            this.tip_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_per_person.Location = new System.Drawing.Point(442, 64);
            this.tip_per_person.Name = "tip_per_person";
            this.tip_per_person.Size = new System.Drawing.Size(0, 31);
            this.tip_per_person.TabIndex = 10;
            // 
            // tip_person
            // 
            this.tip_person.AutoSize = true;
            this.tip_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_person.Location = new System.Drawing.Point(409, 56);
            this.tip_person.Name = "tip_person";
            this.tip_person.Size = new System.Drawing.Size(44, 31);
            this.tip_person.TabIndex = 11;
            this.tip_person.Text = "$0";
            // 
            // total_bill
            // 
            this.total_bill.AutoSize = true;
            this.total_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bill.Location = new System.Drawing.Point(409, 143);
            this.total_bill.Name = "total_bill";
            this.total_bill.Size = new System.Drawing.Size(44, 31);
            this.total_bill.TabIndex = 12;
            this.total_bill.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.total_bill);
            this.Controls.Add(this.tip_person);
            this.Controls.Add(this.tip_per_person);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.no_of_people);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tip_perc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tip_perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tip_perc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown no_of_people;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tip_per_person;
        private System.Windows.Forms.Label tip_person;
        private System.Windows.Forms.Label total_bill;
    }
}

