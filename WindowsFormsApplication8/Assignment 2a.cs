using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**

 *

 * Name: Dylan Fyvie

 * Teacher: Mr. Hardmen

 * Assignment #2a, Program #

 * Date Last Modified: 10/26/2016

 *

 */

namespace WindowsFormsApplication8
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNameQuest_TextChanged(object sender, EventArgs e)
        {
            //This is getting and declaring the name of the user
            //String userName = (txbNameQuest.text) need to be in every place where i use username and a varible
            String userName = (txbNameQuest.Text);

            lblResult.Text = ("Hello " + userName + " How Is Your Day");

        

    }
        //Each Of these are diplaying An emotion to the user
        private void rdbStupidious_CheckedChanged(object sender, EventArgs e)
        {
            String userName = (txbNameQuest.Text);
            
            lblDisplay.Text = (userName + " Your Not Stupidious You Just Want To Click This Button");
        }

        private void rdbGood_CheckedChanged(object sender, EventArgs e)
        {
            String userName = (txbNameQuest.Text);

            lblDisplay.Text = (userName +" Thats Wonderful");
        }

        private void rdbGrinch_CheckedChanged(object sender, EventArgs e)
        {

            String userName = (txbNameQuest.Text);
            lblDisplay.Text = (userName +" Just Dont Steal Christmas");

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
