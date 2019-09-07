using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Player defender = new Player("Defender");
        Player attacker = new Player("Attacker");

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked) setPlayer(defender);
            else if (radioButton1.Checked) setPlayer(attacker);

            

            this.Hide();
            Form2 f = new Form2(defender, attacker);
            f.ShowDialog();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setPlayer(attacker);
            initFields();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setPlayer(defender);
            initFields();
        }

        public void setPlayer(Player player)
        {
            player.a1 = (int)a1.Value;
            player.a2 = (int)a2.Value;
            player.a3 = (int)a3.Value;
            player.a4 = (int)a4.Value;

            player.b1 = (int)b1.Value;
            player.b2 = (int)b2.Value;
            player.b3 = (int)b3.Value;
            player.b4 = (int)b4.Value;

            player.c1 = (int)c1.Value;
            player.c2 = (int)c2.Value;
            player.c3 = (int)c3.Value;
            player.c4 = (int)c4.Value;

            player.d1 = (int)d1.Value;
            player.d2 = (int)d2.Value;
            player.d3 = (int)d3.Value;
        }

        public void initFields()
        {
            a1.Value = 0;
            a2.Value = 0;
            a3.Value = 0;
            a4.Value = 0;

            b1.Value = 0;
            b2.Value = 0;
            b3.Value = 0;
            b4.Value = 0;

            c1.Value = 0;
            c2.Value = 0;
            c3.Value = 0;
            c4.Value = 0;

            d1.Value = 0;
            d2.Value = 0;
            d3.Value = 0;
        }
    }
    public class Player
    {
        public int a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3;
        public String name;

        public Player(String Name)
        {
            name = Name;
        }

        public String toString()
        {
            return a1.ToString() + ", " + a2.ToString() + ", " + a3.ToString() + ", " + a4.ToString() + "\n" +
                   b1.ToString() + ", " + b2.ToString() + ", " + b3.ToString() + ", " + b4.ToString() + "\n" +
                   c1.ToString() + ", " + c2.ToString() + ", " + c3.ToString() + ", " + c4.ToString() + "\n" +
                   d1.ToString() + ", " + d2.ToString() + ", " + d3.ToString(); ;
        }
    }
}
