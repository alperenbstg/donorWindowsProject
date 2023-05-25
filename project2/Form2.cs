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

        private int generateUniqueId()
        {
            Random random = new Random();
            int id = random.Next(10000, 99999);
            while (donors.Any(x => x.Id == id))
            {
                id = random.Next(10000, 99999);

            }
            return id;
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
                photoPath = string.Empty,
                socialID = socialIdTextBox.Text,
                phoneNumber = pNumberTextBox.Text,
              //  bloodType = secilenEleman
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
                    writer.WriteLine($"{donor.Id},{donor.Name},{donor.Surname},{donor.socialID},{donor.phoneNumber},{donor.Email},{donor.bloodType},{donor.DonationDate}");


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
    }
}
