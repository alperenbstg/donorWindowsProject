using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form3 : Form
    {


        private List<Donor> donors = new List<Donor>();
        private string filePath = "donors.txt";
        private int currentIndex = 0;

        public Form3()
        {
            InitializeComponent();
            loadDonorsFromFile();
            displayDonorInformation();
            numberOfTotalandCurrentDonors();



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void loadDonorsFromFile()
        {

            if (File.Exists(filePath))
            {

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        Donor donor = new Donor()
                        {
                            Id = int.Parse(parts[0]),
                            Name = parts[1],
                            Surname = parts[2],
                            socialID = parts[3],
                            phoneNumber = parts[4],
                            Email = parts[5],
                            bloodType = parts[6],
                            DonationDate = parts[7],
                            photoPath = parts[8]

                        };

                        donors.Add(donor);
                    }
                }


            }


        }

        private void idText_Click(object sender, EventArgs e)
        {

        }

        private void displayDonorInformation()
        {
            if (donors.Count > 0)
            {
                Donor currentDonor = donors[currentIndex];
                string stringID = currentDonor.Id.ToString();

                idText.Text = stringID;
                nameText.Text = currentDonor.Name;
                surnameText.Text = currentDonor.Surname;
                socailIdText.Text = currentDonor.socialID;
                phoneText.Text = currentDonor.phoneNumber;
                emailText.Text = currentDonor.Email;
                dateText.Text = currentDonor.DonationDate;
                pictureBox1.ImageLocation = currentDonor.photoPath;


            }
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex < donors.Count - 1)
            {
                currentIndex++;
                displayDonorInformation();

                numberOfTotalandCurrentDonors();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                displayDonorInformation();

                numberOfTotalandCurrentDonors();
            }
        }

        private void totalRecord_Click(object sender, EventArgs e)
        {

            numberOfTotalandCurrentDonors();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (donors.Count > 0)
            {
                donors.RemoveAt(currentIndex);
                SaveDonorsToFile();
                numberOfTotalandCurrentDonors();


                if (donors.Count == 0)
                {

                    currentIndex = 0;


                }

                else if (currentIndex >= donors.Count)
                {

                    currentIndex = donors.Count - 1;
                    displayDonorInformation();



                }

                else { displayDonorInformation(); }

            }
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


        private void numberOfTotalandCurrentDonors()
        {

            string suAnKullanici = (currentIndex + 1).ToString();
            string totalKullanici = donors.Count.ToString();
            totalRecord.Text = suAnKullanici + "--" + totalKullanici;
        }

    }
}
