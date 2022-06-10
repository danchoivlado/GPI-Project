﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ExamShapeFive : Shape
    {
        public ExamShapeFive(RectangleF elp) : base(elp)
        {
        }

        public ExamShapeFive(ElipseShape elipsa) : base(elipsa)
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
            float r, x0, y0, x1, y1, x2, y2, x3, y3, x4, y4;


            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawLine(Pens.Black, Rectangle.X + Rectangle.Width / 2, Rectangle.Y, Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height);
            grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);

            r = Rectangle.Width / 2;
            x0 = Rectangle.X + r;
            y0 = Rectangle.Y + Rectangle.Height / 2;
            x1 = (float)(x0 + r * Math.Cos(230 * (Math.PI / 180)));
            y1 = (float)(y0 + r * Math.Sin(230 * (Math.PI / 180)));

            x2 = (float)(x0 + r * Math.Cos(130 * (Math.PI / 180)));
            y2 = (float)(y0 + r * Math.Sin(130 * (Math.PI / 180)));

            x3 = (float)(x0 + r * Math.Cos(-45 * (Math.PI / 180)));
            y3 = (float)(y0 + r * Math.Sin(-45 * (Math.PI / 180)));

            x4 = (float)(x0 + r * Math.Cos(-45 * (Math.PI / 180)));
            y4 = (float)(y0 + r * Math.Sin(45 * (Math.PI / 180)));

            grfx.DrawLine(Pens.Black, x1, y1, x2, y2);
            grfx.DrawLine(Pens.Black, x3, y3, x4, y4);

            grfx.ResetTransform();

        }
    }
}