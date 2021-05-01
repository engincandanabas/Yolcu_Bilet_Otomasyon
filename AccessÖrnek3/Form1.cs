using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessÖrnek3
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database3.mdb");
        OleDbCommand komut = new OleDbCommand();
        
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From Bilgiler";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["SeferNO"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Bilgiler (Seferno,Tarih,Saat,AdSoyad,Telefon,Koltukno,Ucret,Cinsiyet) values ('"+textEdit1.Text.ToString()+"','"+textEdit2.Text.ToString()+"','"+textEdit3.Text.ToString()+"','"+textEdit4.Text.ToString()+"','"+textEdit5.Text.ToString()+"','"+textEdit6.Text.ToString()+"','"+textEdit7.Text.ToString()+"','"+comboBoxEdit1.Text.ToString()+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";
            textEdit7.Text = "";
            comboBoxEdit1.Text = "";

        }
        
        private void button0_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "1";
            button1.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "2";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "3";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "4";
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "5";
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "6";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "7";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "8";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "9";
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "10";
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "11";
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "12";
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "13";
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "14";
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "15";
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "16";
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textEdit6.Text = "17";
            button17.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Bilgiler where AdSoyad='" + textEdit4.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";
            textEdit7.Text = "";
            comboBoxEdit1.Text = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = ("update Bilgiler set Seferno='" + textEdit1.Text + "',Tarih='" + textEdit2.Text + "',Saat='" + textEdit3.Text + "',Telefon='" + textEdit5.Text + "',Koltukno='" + textEdit6.Text + "',Ucret='" + textEdit7.Text + "',Cinsiyet='" + comboBoxEdit1.Text + "' where AdSoyad='" + textEdit4.Text + "'");
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dnbse\OneDrive\Belgeler\Database3.mdb