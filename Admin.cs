using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EarthCove
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            //Showing Dashboard & Hiding Other Panels initially
            this.panel7.Show();
            this.panel11.Hide();
            this.panel12.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            //Making look like selected Dashboard
            this.panel3.BackColor = Color.FromArgb(33, 37, 43);
            this.DashboardLabel.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox3.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*if(this.panel1.Visible)
            {
                this.panel1.Hide();
            }
            else
            {
                this.panel1.Show();
            }*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {
            this.panel7.Show();
            this.panel11.Hide();
            this.panel12.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            //this.panel7.Location = new Point(170, 45);

            //Dashboard looking selected
            this.panel3.BackColor = Color.FromArgb(33, 37, 43);
            this.DashboardLabel.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox3.BackColor = Color.FromArgb(255, 255, 255);

            //////////////Other looking deselected//////////////
            //Manage User deselect effect
            this.panel4.BackColor = Color.FromArgb(44, 53, 61);
            this.label6.ForeColor = Color.LightGray;
            this.pictureBox7.BackColor = Color.FromArgb(44, 53, 61);
            //Manage provider deselect effect
            this.panel5.BackColor = Color.FromArgb(44, 53, 61);
            this.label7.ForeColor = Color.LightGray;
            this.pictureBox8.BackColor = Color.FromArgb(44, 53, 61);
            //Packages deselect effect
            this.panel13.BackColor = Color.FromArgb(44, 53, 61);
            this.label8.ForeColor = Color.LightGray;
            this.pictureBox9.BackColor = Color.FromArgb(44, 53, 61);
            //Hot Deals deselect effect
            this.panel14.BackColor = Color.FromArgb(44, 53, 61);
            this.label9.ForeColor = Color.LightGray;
            this.pictureBox10.BackColor = Color.FromArgb(44, 53, 61);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.panel11.Show();
            this.panel7.Hide();
            this.panel12.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            //this.panel11.Location = new Point(170, 45);

            //Manage User selected effect
            this.panel4.BackColor = Color.FromArgb(33, 37, 43);
            this.label6.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox7.BackColor = Color.FromArgb(255, 255, 255);

            //////////////Other looking deselected//////////////
            //Dashboard deselect effect
            this.panel3.BackColor = Color.FromArgb(44, 53, 61);
            this.DashboardLabel.ForeColor = Color.LightGray;
            this.pictureBox3.BackColor = Color.FromArgb(44, 53, 61);
            //Manage provider deselect effect
            this.panel5.BackColor = Color.FromArgb(44, 53, 61);
            this.label7.ForeColor = Color.LightGray;
            this.pictureBox8.BackColor = Color.FromArgb(44, 53, 61);
            //Packages deselect effect
            this.panel13.BackColor = Color.FromArgb(44, 53, 61);
            this.label8.ForeColor = Color.LightGray;
            this.pictureBox9.BackColor = Color.FromArgb(44, 53, 61);
            //Hot Deals deselect effect
            this.panel14.BackColor = Color.FromArgb(44, 53, 61);
            this.label9.ForeColor = Color.LightGray;
            this.pictureBox10.BackColor = Color.FromArgb(44, 53, 61);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.panel12.Show();
            this.panel11.Hide();
            this.panel7.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            //this.panel12.Location = new Point(170, 45);

            //Manage Provider selected effect
            this.panel5.BackColor = Color.FromArgb(33, 37, 43);
            this.label7.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox8.BackColor = Color.FromArgb(255, 255, 255);

            //////////////Other looking deselected//////////////
            //Dashboard deselect effect
            this.panel3.BackColor = Color.FromArgb(44, 53, 61);
            this.DashboardLabel.ForeColor = Color.LightGray;
            this.pictureBox3.BackColor = Color.FromArgb(44, 53, 61);
            //Manage user deselect effect
            this.panel4.BackColor = Color.FromArgb(44, 53, 61);
            this.label6.ForeColor = Color.LightGray;
            this.pictureBox7.BackColor = Color.FromArgb(44, 53, 61);
            //Packages deselect effect
            this.panel13.BackColor = Color.FromArgb(44, 53, 61);
            this.label8.ForeColor = Color.LightGray;
            this.pictureBox9.BackColor = Color.FromArgb(44, 53, 61);
            //Hot Deals deselect effect
            this.panel14.BackColor = Color.FromArgb(44, 53, 61);
            this.label9.ForeColor = Color.LightGray;
            this.pictureBox10.BackColor = Color.FromArgb(44, 53, 61);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.panel15.Show();
            this.panel12.Hide();
            this.panel11.Hide();
            this.panel7.Hide();
            this.panel16.Hide();

            //Packages Selected Effect
            this.panel13.BackColor = Color.FromArgb(33, 37, 43);
            this.label8.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox9.BackColor = Color.FromArgb(255, 255, 255);

            //////////////Other looking deselected//////////////
            //Dashboard deselect effect
            this.panel3.BackColor = Color.FromArgb(44, 53, 61);
            this.DashboardLabel.ForeColor = Color.LightGray;
            this.pictureBox3.BackColor = Color.FromArgb(44, 53, 61);
            //Manage user deselect effect
            this.panel4.BackColor = Color.FromArgb(44, 53, 61);
            this.label6.ForeColor = Color.LightGray;
            this.pictureBox7.BackColor = Color.FromArgb(44, 53, 61);
            //Manage provider deselect effect
            this.panel5.BackColor = Color.FromArgb(44, 53, 61);
            this.label7.ForeColor = Color.LightGray;
            this.pictureBox8.BackColor = Color.FromArgb(44, 53, 61);
            //Hot Deals deselect effect
            this.panel14.BackColor = Color.FromArgb(44, 53, 61);
            this.label9.ForeColor = Color.LightGray;
            this.pictureBox10.BackColor = Color.FromArgb(44, 53, 61);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.panel16.Show();
            this.panel15.Hide();
            this.panel12.Hide();
            this.panel11.Hide();
            this.panel7.Hide();

            this.panel14.BackColor = Color.FromArgb(33, 37, 43);
            this.label9.ForeColor = Color.FromArgb(255, 255, 255);
            this.pictureBox10.BackColor = Color.FromArgb(255, 255, 255);

            //////////////Other looking deselected//////////////
            //Dashboard deselect effect
            this.panel3.BackColor = Color.FromArgb(44, 53, 61);
            this.DashboardLabel.ForeColor = Color.LightGray;
            this.pictureBox3.BackColor = Color.FromArgb(44, 53, 61);
            //Manage User deselect effect
            this.panel4.BackColor = Color.FromArgb(44, 53, 61);
            this.label6.ForeColor = Color.LightGray;
            this.pictureBox7.BackColor = Color.FromArgb(44, 53, 61);
            //Manage provider deselect effect
            this.panel5.BackColor = Color.FromArgb(44, 53, 61);
            this.label7.ForeColor = Color.LightGray;
            this.pictureBox8.BackColor = Color.FromArgb(44, 53, 61);
            //Packages deselect effect
            this.panel13.BackColor = Color.FromArgb(44, 53, 61);
            this.label8.ForeColor = Color.LightGray;
            this.pictureBox9.BackColor = Color.FromArgb(44, 53, 61);
        }
    }
}
