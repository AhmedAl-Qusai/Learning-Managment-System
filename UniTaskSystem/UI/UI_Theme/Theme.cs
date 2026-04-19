using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UniTaskSystem.UI.UI_Theme
{
    public static class Theme
    {
        // ألوان بسيطة ومريحة (تقدر تغيرها لاحقاً)
        public static readonly Color Bg = Color.White;
        public static readonly Color Surface = Color.FromArgb(245, 247, 250);
        public static readonly Color Primary = Color.FromArgb(32, 78, 207);
        public static readonly Color Text = Color.FromArgb(30, 30, 30);
        public static readonly Color Muted = Color.FromArgb(110, 110, 110);

        public static readonly Font FontBase = new Font("Segoe UI", 10f, FontStyle.Regular);
        public static readonly Font FontBold = new Font("Segoe UI", 10f, FontStyle.Bold);
        public static readonly Font FontTitle = new Font("Segoe UI", 14f, FontStyle.Bold);

        public static void ApplyForm(Form f)
        {
            f.BackColor = Bg;
            f.Font = FontBase;
        }

        public static void StyleGrid(DataGridView g)
        {
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Bg;
            g.EnableHeadersVisualStyles = false;

            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            g.DefaultCellStyle.Font = FontBase;
            g.DefaultCellStyle.ForeColor = Text;
            g.DefaultCellStyle.BackColor = Bg;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 255);
            g.DefaultCellStyle.SelectionForeColor = Text;
            g.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.ColumnHeadersDefaultCellStyle.Font = FontBold;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            g.ColumnHeadersDefaultCellStyle.BackColor = Surface;
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.AlternatingRowsDefaultCellStyle.BackColor = Surface;
            g.RowTemplate.Height = 38;
        }
    }
}
