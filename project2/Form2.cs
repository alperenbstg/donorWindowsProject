using project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project2
{
    public partial class Form2 : Form
    {
        private List<Donor> donors = new List<Donor>();
        private string filePath = "donors.txt";

        public Form2()
        {
            InitializeComponent();
            today.Text = DateTime.Now.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void today_Click(object sender, EventArgs e)
        {
            today.Visible = true;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {


            Donor donor = new Donor()
            {
                Id = generateUniqueId(),
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Email = emailTextBox.Text,
                DonationDate = today.Text,
                photoPath = pictureBox1.ImageLocation,
                socialID = socialIdTextBox.Text,
                phoneNumber = pNumberTextBox.Text,
                bloodType = bType.SelectedItem.ToString()
            };

            donors.Add(donor);
            SaveDonorsToFile();
        }


        private void SaveDonorsToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (Donor donor in donors)
                {
                    writer.WriteLine($"{donor.Id},{donor.Name},{donor.Surname},{donor.socialID},{donor.phoneNumber},{donor.Email},{donor.bloodType},{donor.DonationDate},{donor.photoPath}");


                }


            }



        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void bType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private int generateUniqueId()
        {
            Random random = new Random();
            int id = random.Next(10000, 99999);
            while (IsIdAlreadyUsed(id))
            {
                id = random.Next(10000, 99999);
            }
            return id;
        }

        private bool IsIdAlreadyUsed(int id)
        {
            foreach (Donor donor in donors)
            {
                if (donor.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
