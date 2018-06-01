/********************************************************************
 * Original from SDEV 240                                           *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 652, Exercise 2):                             *
 * Create a project named RecentlyVisitedSites that contains a      *
 * Form with a list of three LinkLabels that link to any three Web  *
 * sites you choose. When a user clicks a LinkLabel, link to that   *
 * . When a user’s mouse hovers over a LinkLabel, display a brief   *
 * message that explains the site’s purpose. After a user clicks a  *
 * link, move the most recently selected link to the top of the     *
 * list, and move the other two links down, making sure to retain   *
 * the correct explanation with each link.                          *
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EhrmanHarleyRecentlyVisitedSites
{
    public partial class RecentlyVisitedSites : Form
    {
        FlowLayoutPanel panel = new FlowLayoutPanel();


        public RecentlyVisitedSites()
        {
            InitializeComponent();

            panel.FlowDirection = FlowDirection.TopDown;

            lblPoorlyDrawnLines.LinkClicked += linkLabel1_LinkClicked;
            lblTrashBird.LinkClicked += linkLabel2_LinkClicked;
            lblTheJoyOfSeex.LinkClicked += linkLabel3_LinkClicked;

            Controls.Add(panel);
            panel.Controls.Add(lblPoorlyDrawnLines);
            panel.Controls.Add(lblTrashBird);
            panel.Controls.Add(lblTheJoyOfSeex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.poorlydrawnlines.com/");
            panel.Controls.SetChildIndex(lblPoorlyDrawnLines, 0);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.webtoons.com/en/comedy/trash-bird/list?title_no=473&page=16");
            panel.Controls.SetChildIndex(lblTrashBird, 0);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://thejoyofseex.com/");
            panel.Controls.SetChildIndex(lblTheJoyOfSeex, 0);
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            lblDescription.Text = "Poorly Drawn Lines is a webcomic updated every Monday, Wednesday, and Friday.";
        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            lblDescription.Text = "Trash Bird is another comic written by Reza Farazmand.";
        }

        private void linkLabel3_MouseHover(object sender, EventArgs e)
        {
            lblDescription.Text = "The Joy of Seex is illustrations by Daniel Seex.";
        }
    }
}
