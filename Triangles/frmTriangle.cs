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

        private void btnHypotenuse_Click(object sender, EventArgs e)
        {
            double side1;
            double side2;
            double hypotenuse;
            lblStatus1.Visible = false;

            if ((double.TryParse(txtSide1.Text, out side1)) && double.TryParse(txtSide2.Text, out side2))
            {
                //hypotenuse = ((sideOne * sideOne) + (sideTwo * sideTwo));

                hypotenuse = Triangles.FindHypotenuse(side1, side2);

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

        private void btnArea_Click(object sender, EventArgs e)
        {
            double side1;
            double side2;
            double area;
            lblStatus1.Visible = false;

            if ((double.TryParse(txtSide1.Text, out side1)) && double.TryParse(txtSide2.Text, out side2))
            {
                //hypotenuse = ((sideOne * sideOne) + (sideTwo * sideTwo));

                area = Triangles.FindArea(side1, side2);

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

        private void btnAngle_Click(object sender, EventArgs e)
        {
            double angle1;
            double angle2;
            double angle;
            lblStatus1.Visible = false;

            if ((double.TryParse(txtAngle1.Text, out angle1)) && double.TryParse(txtAngle2.Text, out angle2))
            {
                angle = Triangles.FindAngle(angle1, angle2);

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
