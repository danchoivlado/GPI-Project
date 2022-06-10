using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShapeTwo : Shape
    {
        public ExamShapeTwo(RectangleF rect) : base(rect)
        {
        }

        public ExamShapeTwo(ExamShapeTwo rectangle) : base(rectangle)
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

            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + Height, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            grfx.DrawLine(Pens.Black, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);
            grfx.ResetTransform();

        }
    }
}
