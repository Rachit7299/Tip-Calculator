
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
            this.bill = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tip_perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            // 
            // tip_perc
            // 
            this.tip_perc.Location = new System.Drawing.Point(44, 128);
            this.tip_perc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tip_perc.Name = "tip_perc";
            this.tip_perc.Size = new System.Drawing.Size(160, 22);
            this.tip_perc.TabIndex = 3;
            this.tip_perc.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of People";
            // 
            // no_of_people
            // 
            this.no_of_people.Location = new System.Drawing.Point(44, 226);
            this.no_of_people.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.no_of_people.Name = "no_of_people";
            this.no_of_people.Size = new System.Drawing.Size(160, 22);
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
            this.label4.Location = new System.Drawing.Point(392, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MaximumSize = new System.Drawing.Size(133, 123);
            this.label4.MinimumSize = new System.Drawing.Size(59, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MaximumSize = new System.Drawing.Size(133, 123);
            this.label5.MinimumSize = new System.Drawing.Size(59, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(393, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Per Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(393, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Per Person";
            // 
            // tip_per_person
            // 
            this.tip_per_person.AutoSize = true;
            this.tip_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_per_person.Location = new System.Drawing.Point(589, 79);
            this.tip_per_person.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tip_per_person.Name = "tip_per_person";
            this.tip_per_person.Size = new System.Drawing.Size(0, 39);
            this.tip_per_person.TabIndex = 10;
            // 
            // tip_person
            // 
            this.tip_person.AutoSize = true;
            this.tip_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_person.Location = new System.Drawing.Point(545, 69);
            this.tip_person.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tip_person.Name = "tip_person";
            this.tip_person.Size = new System.Drawing.Size(55, 39);
            this.tip_person.TabIndex = 11;
            this.tip_person.Text = "$0";
            // 
            // total_bill
            // 
            this.total_bill.AutoSize = true;
            this.total_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bill.Location = new System.Drawing.Point(545, 176);
            this.total_bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_bill.Name = "total_bill";
            this.total_bill.Size = new System.Drawing.Size(55, 39);
            this.total_bill.TabIndex = 12;
            this.total_bill.Text = "$0";
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(39, 52);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(165, 22);
            this.bill.TabIndex = 13;
            this.bill.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bill);
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
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tip_perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.NumericUpDown bill;
    }
}

