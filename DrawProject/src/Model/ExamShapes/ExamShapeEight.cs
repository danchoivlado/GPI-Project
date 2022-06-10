using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShapeEight : Shape
    {
        public ExamShapeEight(RectangleF tri) : base(tri)
        {
        }

        public ExamShapeEight(ExamShapeEight triangle) : base(triangle)
        {
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);

            Point[] p = { new Point((int)Rectangle.X + ((int)Rectangle.Width / 2), (int)Rectangle.Y),
                new Point((int)Rectangle.X, (int)Rectangle.Y + (int)Rectangle.Height/2),
                new Point((int)Rectangle.X + (int)Rectangle.Width/2, (int)(Rectangle.Y + Rectangle.Height)),
                new Point((int)Rectangle.X + (int)Rectangle.Width, (int)(Rectangle.Y+ Rectangle.Height/2))};
            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), p);
            grfx.DrawPolygon(new Pen(BorderColor, BorderWidth), p);

            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);
            grfx.DrawLine(Pens.Black, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height);

            grfx.ResetTransform();

        }
    }
}
