using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Голова
        int nastr = 1;
        int color = 1;
        int hat = 0;
        int ochki = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            nastr = 3;
            // Коричневые
            if ((color == 1) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDark;
            if ((color == 1) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDarkGlasses;
            if ((color == 1) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkHat;
            if ((color == 1) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkGlassesHat;


            // Белые
            if ((color == 2) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhite;
            if ((color == 2) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhiteGlasses;
            if ((color == 2) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteHat;
            if ((color == 2) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteGlassesHat;


            // Розовые
            if ((color == 3) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPink;
            if ((color == 3) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPinkGlasses;
            if ((color == 3) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkHat;
            if ((color == 3) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkGlassesHat;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            nastr = 1;
            // Коричневые
            if ((color == 1) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDark;
            if ((color == 1) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDarkGlasses;
            if ((color == 1) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkHat;
            if ((color == 1) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkGlassesHat;


            // Белые
            if ((color == 2) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhite;
            if ((color == 2) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhiteGlasses;
            if ((color == 2) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteHat;
            if ((color == 2) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteGlassesHat;


            // Розовые
            if ((color == 3) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePink;
            if ((color == 3) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePinkGlasses;
            if ((color == 3) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkHat;
            if ((color == 3) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkGlassesHat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nastr = 2;
            // Коричневые
            if ((color == 1) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDark;
            if ((color == 1) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDarkGlasses;
            if ((color == 1) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkHat;
            if ((color == 1) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkGlassesHat;


            // Белые
            if ((color == 2) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhite;
            if ((color == 2) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhiteGlasses;
            if ((color == 2) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteHat;
            if ((color == 2) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteGlassesHat;


            // Розовые
            if ((color == 3) && (ochki == 0) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPink;
            if ((color == 3) && (ochki == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPinkGlasses;
            if ((color == 3) && (ochki == 0) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkHat;
            if ((color == 3) && (ochki == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkGlassesHat;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.redtshirttwo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.darktshirt;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.bluetshirt;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.redtshirt;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.greentshirt;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.blackPants;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.blueShorts;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.bluePants;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.brownPants;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.greenPants;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.gumshoes;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.crocs;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.slippers;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.sneakers;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.justLegs;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button5.Visible = true;
                button9.Visible = true;
            }
            else
            {
                button5.Visible = false;
                button9.Visible = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ochki = 1;
                // Коричневые
                if ((color == 1) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDarkGlasses;
                if ((color == 1) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkGlassesHat;
                if ((color == 1) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDarkGlasses;
                if ((color == 1) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkGlassesHat;
                if ((color == 1) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDarkGlasses;
                if ((color == 1) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkGlassesHat;


                // Белые
                if ((color == 2) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhiteGlasses;
                if ((color == 2) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteGlassesHat;
                if ((color == 2) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhiteGlasses;
                if ((color == 2) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteGlassesHat;
                if ((color == 2) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhiteGlasses;
                if ((color == 2) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteGlassesHat;


                // Розовые
                if ((color == 3) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePinkGlasses;
                if ((color == 3) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkGlassesHat;
                if ((color == 3) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPinkGlasses;
                if ((color == 3) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkGlassesHat;
                if ((color == 3) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPinkGlasses;
                if ((color == 3) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkGlassesHat;
            }
            else
            {
                ochki = 0;
                // Коричневые
                if ((color == 1) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDark;
                if ((color == 1) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkHat;
                if ((color == 1) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDarkGlasses;
                if ((color == 1) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkHat;
                if ((color == 1) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDark;
                if ((color == 1) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkHat;


                // белые
                if ((color == 2) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhite;
                if ((color == 2) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteHat;
                if ((color == 2) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhiteGlasses;
                if ((color == 2) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteHat;
                if ((color == 2) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhite;
                if ((color == 2) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteHat;


                // розовые
                if ((color == 3) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePink;
                if ((color == 3) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkHat;
                if ((color == 3) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPinkGlasses;
                if ((color == 3) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkHat;
                if ((color == 3) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPink;
                if ((color == 3) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkHat;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                hat = 1;
                // Коричневые
                if ((color == 1) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smileDarkHat;
                if ((color == 1) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smileDarkGlassesHat;
                if ((color == 1) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyDarkHat;
                if ((color == 1) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyDarkGlassesHat;
                if ((color == 1) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadDarkHat;
                if ((color == 1) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadDarkGlassesHat;


                if ((color == 2) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smileWhiteHat;
                if ((color == 2) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteGlassesHat;
                if ((color == 2) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyWhiteHat;
                if ((color == 2) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteGlassesHat;
                if ((color == 2) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadWhiteHat;
                if ((color == 2) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteGlassesHat;


                if ((color == 3) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smilePinkHat;
                if ((color == 3) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smilePinkGlassesHat;
                if ((color == 3) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyPinkHat;
                if ((color == 3) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyPinkGlassesHat;
                if ((color == 3) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadPinkHat;
                if ((color == 3) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadPinkGlassesHat;
            }
            else
            {
                hat = 0;
                // Коричневые
                if ((color == 1) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smileDark;
                if ((color == 1) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smileDarkGlasses;
                if ((color == 1) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyDark;
                if ((color == 1) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyDarkGlasses;
                if ((color == 1) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadDark;
                if ((color == 1) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadDarkGlasses;


                // Белые
                if ((color == 2) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smileWhite;
                if ((color == 2) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteGlasses;
                if ((color == 2) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyWhite;
                if ((color == 2) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteGlasses;
                if ((color == 2) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadWhite;
                if ((color == 2) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteGlasses;


                // Розовые
                if ((color == 3) && (nastr == 1) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.smilePink;
                if ((color == 3) && (nastr == 1) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.smilePinkGlasses;
                if ((color == 3) && (nastr == 2) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.happyPink;
                if ((color == 3) && (nastr == 2) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.happyPinkGlasses;
                if ((color == 3) && (nastr == 3) && (ochki == 0)) button1.BackgroundImage = Properties.Resources.sadPink;
                if ((color == 3) && (nastr == 3) && (ochki == 1)) button1.BackgroundImage = Properties.Resources.sadPinkGlasses;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            color = 2;

            if ((ochki == 1) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhiteGlasses;
            if ((ochki == 1) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteGlassesHat;
            if ((ochki == 1) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhiteGlasses;
            if ((ochki == 1) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteGlassesHat;
            if ((ochki == 1) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhiteGlasses;
            if ((ochki == 1) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteGlassesHat;


            if ((ochki == 0) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileWhite;
            if ((ochki == 0) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileWhiteHat;
            if ((ochki == 0) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyWhite;
            if ((ochki == 0) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyWhiteHat;
            if ((ochki == 0) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadWhite;
            if ((ochki == 0) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadWhiteHat;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            color = 1;


            if ((ochki == 1) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDarkGlasses;
            if ((ochki == 1) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkGlassesHat;
            if ((ochki == 1) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDarkGlasses;
            if ((ochki == 1) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkGlassesHat;
            if ((ochki == 1) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDarkGlasses;
            if ((ochki == 1) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkGlassesHat;


            if ((ochki == 0) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smileDark;
            if ((ochki == 0) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smileDarkHat;
            if ((ochki == 0) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyDark;
            if ((ochki == 0) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyDarkHat;
            if ((ochki == 0) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadDark;
            if ((ochki == 0) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadDarkHat;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color = 3;

            if ((ochki == 1) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePinkGlasses;
            if ((ochki == 1) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkGlassesHat;
            if ((ochki == 1) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPinkGlasses;
            if ((ochki == 1) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkGlassesHat;
            if ((ochki == 1) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPinkGlasses;
            if ((ochki == 1) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkGlassesHat;


            if ((ochki == 0) && (nastr == 1) && (hat == 0)) button1.BackgroundImage = Properties.Resources.smilePink;
            if ((ochki == 0) && (nastr == 1) && (hat == 1)) button1.BackgroundImage = Properties.Resources.smilePinkHat;
            if ((ochki == 0) && (nastr == 2) && (hat == 0)) button1.BackgroundImage = Properties.Resources.happyPink;
            if ((ochki == 0) && (nastr == 2) && (hat == 1)) button1.BackgroundImage = Properties.Resources.happyPinkHat;
            if ((ochki == 0) && (nastr == 3) && (hat == 0)) button1.BackgroundImage = Properties.Resources.sadPink;
            if ((ochki == 0) && (nastr == 3) && (hat == 1)) button1.BackgroundImage = Properties.Resources.sadPinkHat;

        }
    }
}
