using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseApp
{

    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        public Form1()
        {
            InitializeComponent();

            var timer = new Timer();
            timer.Interval = 10;//60000; // Move mouse every 60 seconds
            timer.Tick += (sender, args) =>
            {
                // Get the current cursor position
                var currentPosition = Cursor.Position;

                // Change the cursor position
                SetCursorPos(currentPosition.X + 100, currentPosition.Y + 10);
                SetCursorPos(currentPosition.X + 10, currentPosition.Y + 100);

                // Set the cursor back to the original position
                Cursor.Position = currentPosition;
            };
            timer.Start();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
