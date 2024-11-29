namespace Subway
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
            six_check = new CheckBox();
            twelve_check = new CheckBox();
            Cheese_tomato_check = new CheckBox();
            bacon_pepperoni_check = new CheckBox();
            tuna_mayo_check = new CheckBox();
            Turkey_ham_check = new CheckBox();
            chicken_check = new CheckBox();
            Steak_check = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Takeout_no = new CheckBox();
            takeout_yes = new CheckBox();
            label4 = new Label();
            total_label = new Label();
            eating_label = new Label();
            SuspendLayout();
            // 
            // six_check
            // 
            six_check.AutoSize = true;
            six_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            six_check.Location = new Point(80, 49);
            six_check.Name = "six_check";
            six_check.Size = new Size(136, 32);
            six_check.TabIndex = 0;
            six_check.Text = "Six inch Sub";
            six_check.UseVisualStyleBackColor = true;
            six_check.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // twelve_check
            // 
            twelve_check.AutoSize = true;
            twelve_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            twelve_check.Location = new Point(257, 49);
            twelve_check.Name = "twelve_check";
            twelve_check.Size = new Size(169, 32);
            twelve_check.TabIndex = 1;
            twelve_check.Text = "Twelve inch Sub";
            twelve_check.UseVisualStyleBackColor = true;
            twelve_check.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Cheese_tomato_check
            // 
            Cheese_tomato_check.AutoSize = true;
            Cheese_tomato_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Cheese_tomato_check.Location = new Point(11, 124);
            Cheese_tomato_check.Name = "Cheese_tomato_check";
            Cheese_tomato_check.Size = new Size(200, 32);
            Cheese_tomato_check.TabIndex = 2;
            Cheese_tomato_check.Text = "Cheese and tomato";
            Cheese_tomato_check.UseVisualStyleBackColor = true;
            Cheese_tomato_check.CheckedChanged += Cheese_tomato_check_CheckedChanged;
            // 
            // bacon_pepperoni_check
            // 
            bacon_pepperoni_check.AutoSize = true;
            bacon_pepperoni_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bacon_pepperoni_check.Location = new Point(11, 162);
            bacon_pepperoni_check.Name = "bacon_pepperoni_check";
            bacon_pepperoni_check.Size = new Size(218, 32);
            bacon_pepperoni_check.TabIndex = 3;
            bacon_pepperoni_check.Text = "Bacon and pepperoni";
            bacon_pepperoni_check.UseVisualStyleBackColor = true;
            bacon_pepperoni_check.CheckedChanged += bacon_pepperoni_check_CheckedChanged;
            // 
            // tuna_mayo_check
            // 
            tuna_mayo_check.AutoSize = true;
            tuna_mayo_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tuna_mayo_check.Location = new Point(11, 200);
            tuna_mayo_check.Name = "tuna_mayo_check";
            tuna_mayo_check.Size = new Size(165, 32);
            tuna_mayo_check.TabIndex = 4;
            tuna_mayo_check.Text = "Tuna and mayo";
            tuna_mayo_check.UseVisualStyleBackColor = true;
            tuna_mayo_check.CheckedChanged += tuna_mayo_check_CheckedChanged;
            // 
            // Turkey_ham_check
            // 
            Turkey_ham_check.AutoSize = true;
            Turkey_ham_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Turkey_ham_check.Location = new Point(263, 124);
            Turkey_ham_check.Name = "Turkey_ham_check";
            Turkey_ham_check.Size = new Size(170, 32);
            Turkey_ham_check.TabIndex = 5;
            Turkey_ham_check.Text = "Turkey and ham";
            Turkey_ham_check.UseVisualStyleBackColor = true;
            Turkey_ham_check.CheckedChanged += Turkey_ham_check_CheckedChanged;
            // 
            // chicken_check
            // 
            chicken_check.AutoSize = true;
            chicken_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chicken_check.Location = new Point(263, 162);
            chicken_check.Name = "chicken_check";
            chicken_check.Size = new Size(168, 32);
            chicken_check.TabIndex = 6;
            chicken_check.Text = "Chicken teriyaki";
            chicken_check.UseVisualStyleBackColor = true;
            chicken_check.CheckedChanged += chicken_check_CheckedChanged;
            // 
            // Steak_check
            // 
            Steak_check.AutoSize = true;
            Steak_check.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Steak_check.Location = new Point(263, 200);
            Steak_check.Name = "Steak_check";
            Steak_check.Size = new Size(179, 32);
            Steak_check.TabIndex = 7;
            Steak_check.Text = "Steak and cheese";
            Steak_check.UseVisualStyleBackColor = true;
            Steak_check.CheckedChanged += Steak_check_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 8;
            label1.Text = "Bread length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 9;
            label2.Text = "Filling:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(170, 235);
            label3.Name = "label3";
            label3.Size = new Size(115, 37);
            label3.TabIndex = 12;
            label3.Text = "Takeout:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Takeout_no
            // 
            Takeout_no.AutoSize = true;
            Takeout_no.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Takeout_no.Location = new Point(257, 275);
            Takeout_no.Name = "Takeout_no";
            Takeout_no.Size = new Size(58, 32);
            Takeout_no.TabIndex = 11;
            Takeout_no.Text = "No";
            Takeout_no.UseVisualStyleBackColor = true;
            Takeout_no.CheckedChanged += Takeout_no_CheckedChanged;
            // 
            // takeout_yes
            // 
            takeout_yes.AutoSize = true;
            takeout_yes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            takeout_yes.Location = new Point(153, 275);
            takeout_yes.Name = "takeout_yes";
            takeout_yes.Size = new Size(58, 32);
            takeout_yes.TabIndex = 10;
            takeout_yes.Text = "Yes";
            takeout_yes.UseVisualStyleBackColor = true;
            takeout_yes.CheckedChanged += takeout_yes_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(128, 310);
            label4.Name = "label4";
            label4.Size = new Size(206, 37);
            label4.TabIndex = 13;
            label4.Text = "Order summary:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_label
            // 
            total_label.AutoSize = true;
            total_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            total_label.Location = new Point(118, 356);
            total_label.Name = "total_label";
            total_label.Size = new Size(111, 28);
            total_label.TabIndex = 14;
            total_label.Text = "Price: £0.00";
            total_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eating_label
            // 
            eating_label.AutoSize = true;
            eating_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            eating_label.Location = new Point(80, 384);
            eating_label.Name = "eating_label";
            eating_label.Size = new Size(133, 28);
            eating_label.TabIndex = 15;
            eating_label.Text = "Eating in: N/A";
            eating_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 448);
            Controls.Add(eating_label);
            Controls.Add(total_label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Takeout_no);
            Controls.Add(takeout_yes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Steak_check);
            Controls.Add(chicken_check);
            Controls.Add(Turkey_ham_check);
            Controls.Add(tuna_mayo_check);
            Controls.Add(bacon_pepperoni_check);
            Controls.Add(Cheese_tomato_check);
            Controls.Add(twelve_check);
            Controls.Add(six_check);
            Name = "Form1";
            Text = "Subway ordering";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox six_check;
        private CheckBox twelve_check;
        private CheckBox Cheese_tomato_check;
        private CheckBox bacon_pepperoni_check;
        private CheckBox tuna_mayo_check;
        private CheckBox Turkey_ham_check;
        private CheckBox chicken_check;
        private CheckBox Steak_check;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox Takeout_no;
        private CheckBox takeout_yes;
        private Label label4;
        private Label total_label;
        private Label eating_label;
    }
}