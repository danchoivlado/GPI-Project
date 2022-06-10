using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model.ExamShapes
{
    public class ExamShapeFour : Shape
    {
        public ExamShapeFour(RectangleF rect) : base(rect)
        {
        }

        public ExamShapeFour(ExamShapeFour rectangle) : base(rectangle)
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

            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width, Rectangle.Y);
            grfx.ResetTransform();

        }
    }
}
