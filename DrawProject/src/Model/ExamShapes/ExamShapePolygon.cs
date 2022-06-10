using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShapePolygon : Shape
    {

        public ExamShapePolygon(RectangleF tri) : base(tri)
        {
        }

        public ExamShapePolygon(ExamShapePolygon triangle) : base(triangle)
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
            int point = ((int)Rectangle.Width / 2) / 2;

            Point[] p = { new Point((int)Rectangle.X, (int)Rectangle.Y)
                    , new Point((int)Rectangle.X + point,(int)Rectangle.Y + (int)Rectangle.Height)

                    , new Point(((int)Rectangle.X + (int)Rectangle.Width) - point,(int)Rectangle.Y + (int)Rectangle.Height)
                    , new Point((int)Rectangle.X + (int)Rectangle.Width, (int)Rectangle.Y)

            };
            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), p);
            grfx.DrawPolygon(new Pen(BorderColor, BorderWidth), p);
            grfx.DrawLine(Pens.Black, Rectangle.X + Rectangle.Width / 2, Rectangle.Y, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            grfx.DrawLine(Pens.Black, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width - 28, Rectangle.Y + Rectangle.Height / 2);
            grfx.DrawLine(Pens.Black, Rectangle.X + point, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);

            grfx.ResetTransform();

        }
    }
}
