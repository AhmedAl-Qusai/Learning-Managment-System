using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UniTaskSystem.UI.Helpers
{
    public class RoundedPanel : Panel
    {
        public int Radius { get; set; }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.Radius = 28;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectPath(rect, Radius))
            using (SolidBrush b = new SolidBrush(this.BackColor))
            using (Pen p = new Pen(Color.FromArgb(220, 230, 240), 1))
            {
                e.Graphics.FillPath(b, path);
                e.Graphics.DrawPath(p, path);
            }

            this.Region = new Region(GetRoundedRectPath(new Rectangle(0, 0, this.Width, this.Height), Radius));

            base.OnPaint(e);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
