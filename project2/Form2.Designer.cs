namespace project2
{
    partial class Form2
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
            addVolunteer = new Label();
            dateDonation = new Label();
            name = new Label();
            surname = new Label();
            socialId = new Label();
            phoneNumber = new Label();
            email = new Label();
            bloodType = new Label();
            saveButton = new Button();
            backToMainMenu = new Button();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            socialIdTextBox = new TextBox();
            pNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            today = new Label();
            bType = new ComboBox();
            pictureBox1 = new PictureBox();
            addphoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addVolunteer
            // 
            addVolunteer.AutoSize = true;
            addVolunteer.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            addVolunteer.Location = new Point(268, 9);
            addVolunteer.Name = "addVolunteer";
            addVolunteer.Size = new Size(279, 46);
            addVolunteer.TabIndex = 0;
            addVolunteer.Text = "Add a Volunteer";
            // 
            // dateDonation
            // 
            dateDonation.AutoSize = true;
            dateDonation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateDonation.Location = new Point(29, 101);
            dateDonation.Name = "dateDonation";
            dateDonation.Size = new Size(134, 20);
            dateDonation.TabIndex = 1;
            dateDonation.Text = "Date of Donation:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(29, 147);
            name.Name = "name";
            name.Size = new Size(55, 20);
            name.TabIndex = 2;
            name.Text = "Name:";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            surname.Location = new Point(29, 192);
            surname.Name = "surname";
            surname.Size = new Size(75, 20);
            surname.TabIndex = 3;
            surname.Text = "Surname:";
            // 
            // socialId
            // 
            socialId.AutoSize = true;
            socialId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            socialId.Location = new Point(29, 233);
            socialId.Name = "socialId";
            socialId.Size = new Size(81, 20);
            socialId.TabIndex = 4;
            socialId.Text = "Socaial ID:";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumber.Location = new Point(29, 280);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(120, 20);
            phoneNumber.TabIndex = 5;
            phoneNumber.Text = "Phone Number:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(29, 326);
            email.Name = "email";
            email.Size = new Size(57, 20);
            email.TabIndex = 6;
            email.Text = "E-mail:";
            // 
            // bloodType
            // 
            bloodType.AutoSize = true;
            bloodType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bloodType.Location = new Point(29, 364);
            bloodType.Name = "bloodType";
            bloodType.Size = new Size(87, 20);
            bloodType.TabIndex = 7;
            bloodType.Text = "Blood Type";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(29, 496);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // backToMainMenu
            // 
            backToMainMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backToMainMenu.Location = new Point(709, 496);
            backToMainMenu.Name = "backToMainMenu";
            backToMainMenu.Size = new Size(171, 29);
            backToMainMenu.TabIndex = 9;
            backToMainMenu.Text = "Back To Main Menu";
            backToMainMenu.UseVisualStyleBackColor = true;
            backToMainMenu.Click += backToMainMenu_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(232, 147);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(205, 27);
            nameTextBox.TabIndex = 11;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(232, 192);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(205, 27);
            surnameTextBox.TabIndex = 12;
            // 
            // socialIdTextBox
            // 
            socialIdTextBox.Location = new Point(232, 233);
            socialIdTextBox.Name = "socialIdTextBox";
            socialIdTextBox.Size = new Size(205, 27);
            socialIdTextBox.TabIndex = 13;
            // 
            // pNumberTextBox
            // 
            pNumberTextBox.Location = new Point(232, 280);
            pNumberTextBox.Name = "pNumberTextBox";
            pNumberTextBox.Size = new Size(205, 27);
            pNumberTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(232, 326);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(205, 27);
            emailTextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // today
            // 
            today.AutoSize = true;
            today.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            today.Location = new Point(265, 103);
            today.Name = "today";
            today.Size = new Size(42, 20);
            today.TabIndex = 17;
            today.Text = "tarih";
            today.Click += today_Click;
            // 
            // bType
            // 
            bType.FormattingEnabled = true;
            bType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            bType.Location = new Point(232, 364);
            bType.Name = "bType";
            bType.Size = new Size(151, 28);
            bType.TabIndex = 18;
            bType.SelectedIndexChanged += bType_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(581, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 299);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // addphoto
            // 
            addphoto.Location = new Point(711, 420);
            addphoto.Name = "addphoto";
            addphoto.Size = new Size(141, 35);
            addphoto.TabIndex = 20;
            addphoto.Text = "add photo";
            addphoto.UseVisualStyleBackColor = true;
            addphoto.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(989, 559);
            Controls.Add(addphoto);
            Controls.Add(pictureBox1);
            Controls.Add(bType);
            Controls.Add(today);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            Controls.Add(pNumberTextBox);
            Controls.Add(socialIdTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(backToMainMenu);
            Controls.Add(saveButton);
            Controls.Add(bloodType);
            Controls.Add(email);
            Controls.Add(phoneNumber);
            Controls.Add(socialId);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(dateDonation);
            Controls.Add(addVolunteer);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addVolunteer;
        private Label dateDonation;
        private Label name;
        private Label surname;
        private Label socialId;
        private Label phoneNumber;
        private Label email;
        private Label bloodType;
        private Button saveButton;
        private Button backToMainMenu;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private TextBox socialIdTextBox;
        private TextBox pNumberTextBox;
        private TextBox emailTextBox;
        private Label label1;
        private Label today;
        private ComboBox bType;
        private PictureBox pictureBox1;
        private Button addphoto;
        private OpenFileDialog openFileDialog1;
    }
}