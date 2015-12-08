// FileName   : frmTriangle.cs
// By         : Jennifer Klimova
// Date       : December, 08 2015
// Description: The Triangle program allows the user to input sides, or angles, and get 
//              the hypotenuse, the area, or the missing angle.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        // Event Name    : btnHypotenuse_Click()
        // Parameters    : object sender : gets information
        //               : EventArgs e   : object that can store information
        // Description   : this is called when the user clicks the hypotenuse button to get the hypotenuse
        // Return        : n/A
        private void btnHypotenuse_Click(object sender, EventArgs e)
        {
            // Variables
            double side1;
            double side2;
            double hypotenuse;
            lblStatus1.Visible = false;

            // Parses out the information (makes sure it is a number)
            if ((double.TryParse(txtSide1.Text, out side1)) && double.TryParse(txtSide2.Text, out side2))
            {
                // Call the FindHypotenuse function
                hypotenuse = Triangles.FindHypotenuse(side1, side2);

                // Conversion
                string convert = hypotenuse.ToString("N2");
                hypotenuse = double.Parse(convert);

                txtHypotenuse.Text = hypotenuse.ToString();
                txtSide1.Text = "";
                txtSide2.Text = "";
            }
            else
            {
                lblStatus1.Visible = true;
            }
        }

        // Event Name    : btnArea_Click()
        // Parameters    : object sender : gets information
        //               : EventArgs e   : object that can store information
        // Description   : this is called when the user clicks the area button to get the area
        // Return        : n/A
        private void btnArea_Click(object sender, EventArgs e)
        {
            // Variables
            double side1;
            double side2;
            double area;
            lblStatus1.Visible = false;

            // Parses out the information (makes sure it is a number)
            if ((double.TryParse(txtSide1.Text, out side1)) && double.TryParse(txtSide2.Text, out side2))
            {
                // Call the FindArea function
                area = Triangles.FindArea(side1, side2);

                // Convert
                string convert = area.ToString("N2");
                area = double.Parse(convert);

                txtArea.Text = area.ToString();
                txtSide1.Text = "";
                txtSide2.Text = "";
            }
            else
            {
                lblStatus1.Visible = true;
            }
        }

        // Event Name    : btnAngle_Click()
        // Parameters    : object sender : gets information
        //               : EventArgs e   : object that can store information
        // Description   : this is called when the user clicks the angle button to get the angle
        // Return        : n/A
        private void btnAngle_Click(object sender, EventArgs e)
        {
            // Variables
            double angle1;
            double angle2;
            double angle;
            lblStatus1.Visible = false;

            // Parses out the information (makes sure it is a number)
            if ((double.TryParse(txtAngle1.Text, out angle1)) && double.TryParse(txtAngle2.Text, out angle2))
            {
                // Call FindAngle Function
                angle = Triangles.FindAngle(angle1, angle2);

                // Convert
                string convert = angle.ToString("N2");
                angle = double.Parse(convert);

                txtAngle3.Text = angle.ToString();
                txtAngle1.Text = "";
                txtAngle2.Text = "";
            }
            else
            {
                lblStatus1.Visible = true;
            }
        }
    }
}
