using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UniTaskSystem.UI.Helpers
{
    public class RoundedButton : Button
    {
        public int Radius { get; set; }
        public bool Outline { get; set; }
        public Color OutlineColor { get; set; }

        public RoundedButton()
        {
            this.Radius = 14;
            this.Outline = false;
            this.OutlineColor = Color.FromArgb(25, 118, 210);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(25, 118, 210);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.Height = 48;
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectPath(rect, Radius))
            {
                if (Outline)
                {
                    using (SolidBrush bg = new SolidBrush(Color.White))
                        pevent.Graphics.FillPath(bg, path);

                    using (Pen pen = new Pen(OutlineColor, 2))
                        pevent.Graphics.DrawPath(pen, path);

                    this.ForeColor = OutlineColor;
                }
                else
                {
                    using (SolidBrush bg = new SolidBrush(this.BackColor))
                        pevent.Graphics.FillPath(bg, path);
                }

                this.Region = new Region(path);
            }

            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                rect,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
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
