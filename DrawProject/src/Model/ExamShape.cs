using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShape : Shape
    {
        public ExamShape(RectangleF rect) : base(rect)
        {
        }

        public ExamShape(ExamShape exam) : base(exam) { }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawLine(Pens.Green, Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Red, Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Blue, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height);
            grfx.ResetTransform();

        }
    }
}
