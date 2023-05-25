namespace project2
{
    partial class Form3
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
            records = new Label();
            Record = new GroupBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            totalRecord = new Label();
            dateText = new Label();
            bTypeText = new Label();
            emailText = new Label();
            phoneText = new Label();
            socailIdText = new Label();
            surnameText = new Label();
            nameText = new Label();
            idText = new Label();
            donationDate = new Label();
            bloodType = new Label();
            email = new Label();
            phoneNumber = new Label();
            socailID = new Label();
            surname = new Label();
            name = new Label();
            id = new Label();
            delete = new Button();
            backMainMenu = new Button();
            Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // records
            // 
            records.AutoSize = true;
            records.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            records.Location = new Point(576, 9);
            records.Name = "records";
            records.Size = new Size(146, 46);
            records.TabIndex = 0;
            records.Text = "Records";
            // 
            // Record
            // 
            Record.Controls.Add(pictureBox1);
            Record.Controls.Add(button2);
            Record.Controls.Add(button1);
            Record.Controls.Add(totalRecord);
            Record.Controls.Add(dateText);
            Record.Controls.Add(bTypeText);
            Record.Controls.Add(emailText);
            Record.Controls.Add(phoneText);
            Record.Controls.Add(socailIdText);
            Record.Controls.Add(surnameText);
            Record.Controls.Add(nameText);
            Record.Controls.Add(idText);
            Record.Controls.Add(donationDate);
            Record.Controls.Add(bloodType);
            Record.Controls.Add(email);
            Record.Controls.Add(phoneNumber);
            Record.Controls.Add(socailID);
            Record.Controls.Add(surname);
            Record.Controls.Add(name);
            Record.Controls.Add(id);
            Record.Location = new Point(44, 84);
            Record.Name = "Record";
            Record.Size = new Size(1195, 509);
            Record.TabIndex = 1;
            Record.TabStop = false;
            Record.Text = "Record";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(756, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 291);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1035, 41);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(63, 41);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // totalRecord
            // 
            totalRecord.AutoSize = true;
            totalRecord.Location = new Point(562, 50);
            totalRecord.Name = "totalRecord";
            totalRecord.Size = new Size(58, 20);
            totalRecord.TabIndex = 16;
            totalRecord.Text = "label17";
            totalRecord.Click += totalRecord_Click;
            // 
            // dateText
            // 
            dateText.AutoSize = true;
            dateText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateText.Location = new Point(268, 432);
            dateText.Name = "dateText";
            dateText.Size = new Size(51, 20);
            dateText.TabIndex = 15;
            dateText.Text = "label2";
            // 
            // bTypeText
            // 
            bTypeText.AutoSize = true;
            bTypeText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bTypeText.Location = new Point(268, 390);
            bTypeText.Name = "bTypeText";
            bTypeText.Size = new Size(60, 20);
            bTypeText.TabIndex = 14;
            bTypeText.Text = "label10";
            // 
            // emailText
            // 
            emailText.AutoSize = true;
            emailText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailText.Location = new Point(268, 347);
            emailText.Name = "emailText";
            emailText.Size = new Size(51, 20);
            emailText.TabIndex = 13;
            emailText.Text = "label2";
            // 
            // phoneText
            // 
            phoneText.AutoSize = true;
            phoneText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneText.Location = new Point(268, 307);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(60, 20);
            phoneText.TabIndex = 12;
            phoneText.Text = "label12";
            // 
            // socailIdText
            // 
            socailIdText.AutoSize = true;
            socailIdText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            socailIdText.Location = new Point(268, 262);
            socailIdText.Name = "socailIdText";
            socailIdText.Size = new Size(60, 20);
            socailIdText.TabIndex = 11;
            socailIdText.Text = "label13";
            // 
            // surnameText
            // 
            surnameText.AutoSize = true;
            surnameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            surnameText.Location = new Point(268, 220);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(60, 20);
            surnameText.TabIndex = 10;
            surnameText.Text = "label14";
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameText.Location = new Point(268, 177);
            nameText.Name = "nameText";
            nameText.Size = new Size(51, 20);
            nameText.TabIndex = 9;
            nameText.Text = "label2";
            // 
            // idText
            // 
            idText.AutoSize = true;
            idText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idText.Location = new Point(268, 137);
            idText.Name = "idText";
            idText.Size = new Size(60, 20);
            idText.TabIndex = 8;
            idText.Text = "label16";
            idText.Click += idText_Click;
            // 
            // donationDate
            // 
            donationDate.AutoSize = true;
            donationDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            donationDate.Location = new Point(63, 432);
            donationDate.Name = "donationDate";
            donationDate.Size = new Size(111, 20);
            donationDate.TabIndex = 7;
            donationDate.Text = "Donation Date";
            // 
            // bloodType
            // 
            bloodType.AutoSize = true;
            bloodType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bloodType.Location = new Point(63, 390);
            bloodType.Name = "bloodType";
            bloodType.Size = new Size(83, 20);
            bloodType.TabIndex = 6;
            bloodType.Text = "BloodType";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(63, 347);
            email.Name = "email";
            email.Size = new Size(53, 20);
            email.TabIndex = 5;
            email.Text = "E-mail";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumber.Location = new Point(63, 307);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(115, 20);
            phoneNumber.TabIndex = 4;
            phoneNumber.Text = "Phone Number";
            // 
            // socailID
            // 
            socailID.AutoSize = true;
            socailID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            socailID.Location = new Point(63, 262);
            socailID.Name = "socailID";
            socailID.Size = new Size(69, 20);
            socailID.TabIndex = 3;
            socailID.Text = "Social ID";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            surname.Location = new Point(63, 220);
            surname.Name = "surname";
            surname.Size = new Size(71, 20);
            surname.TabIndex = 2;
            surname.Text = "Surname";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(63, 177);
            name.Name = "name";
            name.Size = new Size(51, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            id.Location = new Point(63, 137);
            id.Name = "id";
            id.Size = new Size(25, 20);
            id.TabIndex = 0;
            id.Text = "ID";
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(107, 609);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 19;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // backMainMenu
            // 
            backMainMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backMainMenu.Location = new Point(956, 609);
            backMainMenu.Name = "backMainMenu";
            backMainMenu.Size = new Size(217, 29);
            backMainMenu.TabIndex = 20;
            backMainMenu.Text = "Back To Main Menu";
            backMainMenu.UseVisualStyleBackColor = true;
            backMainMenu.Click += backMainMenu_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1290, 662);
            Controls.Add(backMainMenu);
            Controls.Add(delete);
            Controls.Add(Record);
            Controls.Add(records);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            Record.ResumeLayout(false);
            Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label records;
        private GroupBox Record;
        private Button button2;
        private Button button1;
        private Label totalRecord;
        private Label dateText;
        private Label bTypeText;
        private Label emailText;
        private Label phoneText;
        private Label socailIdText;
        private Label surnameText;
        private Label nameText;
        private Label idText;
        private Label donationDate;
        private Label bloodType;
        private Label email;
        private Label phoneNumber;
        private Label socailID;
        private Label surname;
        private Label name;
        private Label id;
        private Button delete;
        private Button backMainMenu;
        private PictureBox pictureBox1;
    }
}