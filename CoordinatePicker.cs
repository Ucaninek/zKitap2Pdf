using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zKitap2Pdf
{
    public partial class CoordinatePicker : Form
    {
        private string[] CoordinateNames { get; set; }
        public List<Point> Coordinates { get; set; } = new();

        public CoordinatePicker(string[] coordinateNames)
        {
            this.CoordinateNames = coordinateNames;
            InitializeComponent();
        }

        private void CoordinatePicker_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Rectangle screenRect = getScreenRect();
            this.Location = screenRect.Location;
            this.Size = screenRect.Size;
        }

        private static Rectangle getScreenRect() //get the rectangle of all screens
        {
            Rectangle rect = new();
            foreach(Screen s in Screen.AllScreens)
            {
                Rectangle.Union(rect, s.Bounds);
            }

            return rect;
        }
    }
}
