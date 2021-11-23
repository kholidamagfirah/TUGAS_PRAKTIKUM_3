using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin, 14.00-16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = jadwal = "Selasa, 14.00-16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = jadwal = "Rabu, 09.00-11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = jadwal = "Kamis, 09.00-11.00";
            }
            else if (rbJadwal5.Checked)
            {
                jadwal = jadwal = "Jumat, 09.00-11.00";
            }
            else if (rbJadwal6.Checked)
            {
                jadwal = jadwal = "Sabtu & Minggu, 13.00-17.00";
            }
            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show
                 ("Nama : " + teksNama.Text +
                "\nJenis Kelamin : " + cbJenisKelamin.Text +
                "\nTanggal Lahir : " + dtTanggalLahir.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
