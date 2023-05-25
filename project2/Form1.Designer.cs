namespace project2
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
            label1 = new Label();
            addDonner = new Button();
            allRecords = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 0;
            label1.Text = "Blood Bank";
            label1.Click += label1_Click;
            // 
            // addDonner
            // 
            addDonner.Location = new Point(88, 97);
            addDonner.Name = "addDonner";
            addDonner.Size = new Size(180, 53);
            addDonner.TabIndex = 1;
            addDonner.Text = "Add Donner";
            addDonner.UseVisualStyleBackColor = true;
            addDonner.Click += addDonner_Click;
            // 
            // allRecords
            // 
            allRecords.Location = new Point(88, 185);
            allRecords.Name = "allRecords";
            allRecords.Size = new Size(180, 53);
            allRecords.TabIndex = 2;
            allRecords.Text = "All Records";
            allRecords.UseVisualStyleBackColor = true;
            allRecords.Click += allRecords_Click;
            // 
            // exit
            // 
            exit.Location = new Point(88, 349);
            exit.Name = "exit";
            exit.Size = new Size(180, 53);
            exit.TabIndex = 3;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(372, 454);
            Controls.Add(exit);
            Controls.Add(allRecords);
            Controls.Add(addDonner);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addDonner;
        private Button allRecords;
        private Button exit;
    }
}