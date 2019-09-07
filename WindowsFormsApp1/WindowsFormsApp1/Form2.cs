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
    public partial class Form2 : Form
    {
        Player defender;
        Player attacker;
        float leftOver;

        public Form2(Player Defender, Player Attacker)
        {
            InitializeComponent();

            defender = Defender;
            attacker = Attacker;

            if (isVictory()) attackerLable.Visible = true;
            else defenderLable.Visible = true;
        }

        String getUnitsLeft(int numberOfUnits, float unitPoints)
        {
            if (leftOver < 0)
                return "0 (-" + numberOfUnits + ")";

            if (leftOver - (numberOfUnits * unitPoints) < 0)
            {
                int unitsLeft = (int)(numberOfUnits * unitPoints - leftOver / unitPoints);
                leftOver = leftOver - (numberOfUnits * unitPoints);
                return unitsLeft.ToString() + " (-" + (numberOfUnits - unitsLeft).ToString() + ")";
            }
            leftOver = leftOver - (numberOfUnits * unitPoints);
            return numberOfUnits.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(isVictory())
            {
                // Defender:
                d_a1.Text = "0 (-" + defender.a1.ToString() + ")";
                d_a2.Text = "0 (-" + defender.a2.ToString() + ")";
                d_a3.Text = "0 (-" + defender.a3.ToString() + ")";
                d_a4.Text = "0 (-" + defender.a4.ToString() + ")";

                d_b1.Text = "0 (-" + defender.b1.ToString() + ")";
                d_b2.Text = "0 (-" + defender.b2.ToString() + ")";
                d_b3.Text = "0 (-" + defender.b3.ToString() + ")";
                d_b4.Text = "0 (-" + defender.b4.ToString() + ")";

                d_c1.Text = "0 (-" + defender.c1.ToString() + ")";
                d_c2.Text = "0 (-" + defender.c2.ToString() + ")";
                d_c3.Text = "0 (-" + defender.c3.ToString() + ")";
                d_c4.Text = "0 (-" + defender.c4.ToString() + ")";

                d_d1.Text = "0 (-" + defender.d1.ToString() + ")";
                d_d2.Text = "0 (-" + defender.d2.ToString() + ")";
                d_d3.Text = "0 (-" + defender.d3.ToString() + ")";

                // Attacker:
                leftOver = getPoints(attacker) - getPoints(defender);

                a1.Text = getUnitsLeft(attacker.a1, 1);
                a2.Text = getUnitsLeft(attacker.a2, 4);
                a3.Text = getUnitsLeft(attacker.a3, (float)0.7);
                a4.Text = getUnitsLeft(attacker.a4, (float)1.2);

                b1.Text = getUnitsLeft(attacker.b1, (float)0.2);
                b2.Text = getUnitsLeft(attacker.b2, (float)1.2);
                b3.Text = getUnitsLeft(attacker.b3, (float)0.4);
                b4.Text = getUnitsLeft(attacker.b4, (float)0.1);

                c1.Text = getUnitsLeft(attacker.c1, 5);
                c2.Text = getUnitsLeft(attacker.c2, 7);
                c3.Text = getUnitsLeft(attacker.c3, 3);
                c4.Text = getUnitsLeft(attacker.c4, 6);

                d1.Text = getUnitsLeft(attacker.d1, (float)2.5);
                d2.Text = getUnitsLeft(attacker.d2, (float)0.2);
                d3.Text = getUnitsLeft(attacker.d3, (float)0.3);
            }

            else
            {
                // Attacker:
                a1.Text = "0 (-" + attacker.a1.ToString() + ")";
                a2.Text = "0 (-" + attacker.a2.ToString() + ")";
                a3.Text = "0 (-" + attacker.a3.ToString() + ")";
                a4.Text = "0 (-" + attacker.a4.ToString() + ")";

                b1.Text = "0 (-" + attacker.b1.ToString() + ")";
                b2.Text = "0 (-" + attacker.b2.ToString() + ")";
                b3.Text = "0 (-" + attacker.b3.ToString() + ")";
                b4.Text = "0 (-" + attacker.b4.ToString() + ")";

                c1.Text = "0 (-" + attacker.c1.ToString() + ")";
                c2.Text = "0 (-" + attacker.c2.ToString() + ")";
                c3.Text = "0 (-" + attacker.c3.ToString() + ")";
                c4.Text = "0 (-" + attacker.c4.ToString() + ")";

                d1.Text = "0 (-" + attacker.d1.ToString() + ")";
                d2.Text = "0 (-" + attacker.d2.ToString() + ")";
                d3.Text = "0 (-" + attacker.d3.ToString() + ")";

                // Defender:
                leftOver = getPoints(defender) - getPoints(attacker);

                d_a1.Text = getUnitsLeft(defender.a1, 1);
                d_a2.Text = getUnitsLeft(defender.a2, 4);
                d_a3.Text = getUnitsLeft(defender.a3, (float)0.7);
                d_a4.Text = getUnitsLeft(defender.a4, (float)1.2);

                d_b1.Text = getUnitsLeft(defender.b1, (float)0.2);
                d_b2.Text = getUnitsLeft(defender.b2, (float)1.2);
                d_b3.Text = getUnitsLeft(defender.b3, (float)0.4);
                d_b4.Text = getUnitsLeft(defender.b4, (float)0.1);

                d_c1.Text = getUnitsLeft(defender.c1, 5);
                d_c2.Text = getUnitsLeft(defender.c2, 7);
                d_c3.Text = getUnitsLeft(defender.c3, 3);
                d_c4.Text = getUnitsLeft(defender.c4, 6);

                d_d1.Text = getUnitsLeft(defender.d1, (float)2.5);
                d_d2.Text = getUnitsLeft(defender.d2, (float)0.2);
                d_d3.Text = getUnitsLeft(defender.d3, (float)0.3);
            }
        }

        public float getPoints(Player player)
        {
            return (float)(player.a1 * 1 + player.a2 * 4 + player.a3 * 0.7 + player.a4 * 1.2
                 + player.b1 * 0.2 + player.b2 * 1.2 + player.b3 * 0.4 + player.b4 * 0.1
                 + player.c1 * 5 + player.c2 * 7 + player.c3 * 3 + player.c4 * 6
                 + player.d1 * 2.5 + player.d2 * 0.2 + player.d3 * 0.3);
        }

        public bool isVictory()
        {
            float attackerPoints = getPoints(attacker);
            float defenderPoints = getPoints(defender);

            return attackerPoints > defenderPoints;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
