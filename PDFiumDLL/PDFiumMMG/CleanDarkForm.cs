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

namespace MMG.FormDecoration
{
    public partial class CleanDarkForm : Form
    {
        private const int WM_PAINT = 0x000F;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_LBUTTONUP = 0x0202;
        private const int SWP_NOMOVEZ = 0x0004;
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        private bool isDragging = false;
        private Point initialMousePosition;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);
        
        public CleanDarkForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                /*case WM_PAINT:
                    using (Graphics g = Graphics.FromHwnd(m.HWnd))
                    {
                        g.DrawRectangle(Pens.Red, 50, 50, 100, 150);
                    }
                    break;*/

                case WM_LBUTTONDOWN:
                    isDragging = true;
                    initialMousePosition = new Point(m.LParam.ToInt32());
                    break;

                case WM_MOUSEMOVE:
                    if (isDragging)
                    {
                        Point currentMousePosition = new Point(m.LParam.ToInt32());
                        int deltaX = currentMousePosition.X - initialMousePosition.X;
                        int deltaY = currentMousePosition.Y - initialMousePosition.Y;

                        int newX = Left + deltaX;
                        int newY = Top + deltaY;

                        SetWindowPos(m.HWnd, HWND_TOPMOST, newX, newY, Width, Height, SWP_NOMOVEZ);
                        InvalidateRect(m.HWnd, IntPtr.Zero, true);
                    }
                    break;

                case WM_LBUTTONUP:
                    isDragging = false;
                    break;
            }

            base.WndProc(ref m);
        }

        protected Color borderColor = Color.Black;
        protected Color footerLineColor = Color.LimeGreen;
        protected void CleanDarkForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(borderColor, 1))
            using (Pen footerBorderPen = new Pen(footerLineColor, 2))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                e.Graphics.DrawLine(footerBorderPen, 3, this.ClientSize.Height - 4, this.ClientSize.Width - 3, this.ClientSize.Height - 4);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CleanDarkForm_Shown(object sender, EventArgs e)
        {
            closeButton.Location = new Point(this.ClientSize.Width - 37, 7);
            this.FormBorderStyle = FormBorderStyle.None;
            this.titleLabel.Text = this.Text;
        }
    }
}
