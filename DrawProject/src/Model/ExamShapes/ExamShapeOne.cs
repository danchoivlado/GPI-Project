using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShapeOne : Shape
    {
        public ExamShapeOne(RectangleF elp) : base(elp)
        {
        }

        public ExamShapeOne(ExamShapeOne elipsa) : base(elipsa)
        {
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                float a = Width / 2;
                float b = Height / 2;
                float x0 = Location.X + a;
                float y0 = Location.Y + b;

                return Math.Pow((point.X - x0) / a, 2) + Math.Pow((point.Y - y0) / b, 2) - 1 <= 0;
            }
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.X, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Gray, Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);

            grfx.ResetTransform();

        }
    }
}
