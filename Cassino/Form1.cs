using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassino
{
    public partial class Form1 : Form
    {
        int[] roulette;
        int[] cycles;
        Label[] screen;
        Random r;
        public Form1()
        {
            InitializeComponent();
            roulette = new int[3];
            cycles = new int[3];
            screen = new Label[] { lblN1, lblN2, lblN3 };
            r = new Random();
            for (int i = 0; i < roulette.Length; i++)
            {
                roulette[i] = r.Next(0, 10);
                Atualizar(i);
            }
        }
        void Atualizar(int i)
        {
            screen[i].Text = roulette[i].ToString();
        }

        private void btGirar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cycles.Length; i++)
            {
                cycles[i] = r.Next(1, 21);
                screen[i].ForeColor = Color.Black;
            }
            Array.Sort(cycles);
            btGirar.Enabled = false;
            timer.Enabled = true;
        }
        void verificarVitoria()
        {
            if (lblN1.Text == lblN2.Text && lblN2.Text == lblN3.Text)
            {
                lblN1.ForeColor = Color.Green;
                lblN2.ForeColor = Color.Green;
                lblN3.ForeColor = Color.Green;
                MessageBox.Show("VOCE GANHOU!!!!");
            }
            else
            {
                if (chbVitorias.Checked)
                {
                    jogadas.Add($"{roulette[0]}-{roulette[1]}-{roulette[2]}");
                }
                else
                {
                    lbxUltimos.Items.Add($"{roulette[0]}-{roulette[1]}-{roulette[2]}");
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool stopped = true;
            for (int i = 0; i < cycles.Length; i++)
            {
                if (cycles[i] > 0)
                {
                    cycles[i]--;
                    if (cycles[i] == 0)
                        screen[i].ForeColor = Color.Red;
                    roulette[i]++;
                    if (roulette[i] == 10)
                        roulette[i] = 0;
                    Atualizar(i);
                    stopped &= false;
                }
                else
                {
                    stopped &= true;
                }
            }
            if (stopped)
            {
                timer.Enabled = false;
                btGirar.Enabled = true;
                verificarVitoria();
            }

        }

        List<string> jogadas;
        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVitorias.Checked)
            {
                jogadas = new List<string>();
                foreach (string item in lbxUltimos.Items)
                {
                    jogadas.Add(item);
                }

                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    string[] nums = item.Split('-');
                    if (nums[0] == nums[1] && nums[1] == nums[2])
                        lbxUltimos.Items.Add(item);
                }
            }
            else
            {
                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    lbxUltimos.Items.Add(item);
                }

            }
        }
    }
}
