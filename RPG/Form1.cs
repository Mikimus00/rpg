using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Hero selected_hero = (Hero)listBox1.SelectedItem;
            textBox1.Text = selected_hero.Name;
            textBox1.Text += selected_hero.HP;
            
            comboBox1.DataSource = new BindingSource(selected_hero.Skill, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hero selectedhero = (Hero)listBox2.SelectedItem;
            textBox2.Text = selectedhero.Name;
            textBox2.Text += selectedhero.HP;

            comboBox2.DataSource = new BindingSource(selectedhero.Skill, null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game.Instance.hod = 1;
            if (Game.Instance.hod % 2 == 0)
            {
                Game.Instance.comanda = 2;
            }
            else Game.Instance.comanda = 1;
            label1.Text = "Ход команды " + Game.Instance.comanda.ToString();

            listBox1.DataSource = new BindingSource(Game.Instance.Team1, null);
            listBox2.DataSource = new BindingSource(Game.Instance.Team2, null);
            
            foreach(var hero in Game.Instance.Team1)
            {
                hero.OnDeath += DeathMessage;
            }
            foreach (var hero in Game.Instance.Team2)
            {
                hero.OnDeath += DeathMessage;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Hero h1 = (Hero)listBox1.SelectedItem;
            Hero h2 = (Hero)listBox2.SelectedItem;
            Game.Instance.hod++;
            if (Game.Instance.hod / 2 == 0)
            {
                h1.attack(h2);
            }
            else h2.attack(h1);
            
            textBox2.Text = h2.Name;
            textBox2.Text += h2.HP;
            textBox1.Text = h1.Name;
            textBox1.Text += h1.HP;
            listBox1.DataSource = new BindingSource(Game.Instance.Team1, null);
            listBox1.DataSource = new BindingSource(Game.Instance.Team1,null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var hero in Game.Instance.Team1)
            {
                hero.OnDeath -= DeathMessage;
            }
            foreach (var hero in Game.Instance.Team2)
            {
                hero.OnDeath -= DeathMessage;
            }
            using (Stream stream = File.Open("saveload.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Game.Instance.Team1);
            }
            using (Stream stream = File.Open("saveload2.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Game.Instance.Team2);
            }
            
        } 
        
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedskill = (KeyValuePair<string, Hero.skills>)comboBox2.SelectedItem;
            if (selectedskill.Key == "Вылечить")
            {
                comboBox1.Enabled = false;
                listBox1.DataSource = new BindingSource(Game.Instance.Team2, null);
            }
            if (selectedskill.Key == "Атаковать")
            {
                comboBox1.Enabled = true;
                listBox1.DataSource = new BindingSource(Game.Instance.Team1, null);

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedskill = (KeyValuePair<string, Hero.skills>)comboBox1.SelectedItem;
            if (selectedskill.Key == "Вылечить")
            {
                comboBox2.Enabled = false;
                listBox2.DataSource = new BindingSource(Game.Instance.Team1, null);
            }
            if (selectedskill.Key == "Атаковать")
            {
                comboBox2.Enabled = true;
                listBox2.DataSource = new BindingSource(Game.Instance.Team2, null);

            }
        }
        public void DeathMessage(Hero h)
        {
            Game.Instance.Team1.RemoveAll(Hero => Hero == h);
            Game.Instance.Team2.RemoveAll(Hero => Hero == h);
                textBox3.Text += String.Format(h.Name + " умер");
                listBox1.DataSource = new BindingSource(Game.Instance.Team1, null);
                listBox2.DataSource = new BindingSource(Game.Instance.Team2, null);
        }
    }
}
