using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{

    [Serializable]

    public class ShapeGroup : Shape
    {

        public ShapeGroup(RectangleF rect) : base(rect)
        {
        }

        public ShapeGroup(RectangleShape rectangle) : base(rectangle)
        {
        }

        protected List<Shape> subItem = new List<Shape>();
        public List<Shape> SubItem
        {
            get { return subItem; }
            set { subItem = value; }
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                foreach (var item in SubItem)
                {
                    if (item.Contains(point)) return true;
                }
                return true;
            }
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (var item in SubItem)
            {
                item.DrawSelf(grfx);
            }
        }
        public override void Move(float dx, float dy)
        {
            base.Move(dx, dy); // използваме базовия метод за да преместим цялата група 
            foreach (var item in SubItem) // а тук вече по отделно местим всеки един елемент в дадената група
            {
                item.Move(dx * 2, dy * 2);
            }
        }
        public void GroupFillColor(Color color)
        {
            FillColor = color;

            foreach (var item in SubItem)
            {
                item.FillColor = color;
            }
        }
        public void GroupBorderColor(Color color)
        {
            BorderColor = color;

            foreach (var item in SubItem)
            {
                item.BorderColor = color;
            }
        }

        public void GroupOpacity(int opacity)
        {
            Opacity = opacity;
            foreach (var item in SubItem)
            {
                item.Opacity = opacity;
            }
        }
        public void GroupTranslate(PointF point)
        {
            foreach (var item in SubItem)
            {
                item.Location = new PointF(this.Location.X + (item.Location.X - point.X), this.Location.Y - (point.Y - item.Location.Y));
            }
        }
        public void GroupReSizeWidth(float width)
        {
            Width = width;
            float maxX = float.MinValue;
            float minX = float.MaxValue;
            foreach (var item in SubItem)
            {
                item.Width = width;
                if (minX > item.Location.X)
                {
                    minX = item.Location.X;
                }
                if (maxX < item.Location.X + item.Width)
                {
                    maxX = item.Location.X + item.Width;
                }

            }
            this.Rectangle = new RectangleF(minX, this.Rectangle.Y, maxX - minX, this.Rectangle.Height);
        }

        public void GroupReSizeHeight(float height)
        {
            Height = height;
            float maxY = float.NegativeInfinity;
            float minY = float.PositiveInfinity;
            foreach (var item in SubItem)
            {
                item.Height = height;
                if (minY > item.Location.Y)
                {
                    minY = item.Location.Y;
                }
                if (maxY < item.Location.Y + item.Height)
                {
                    maxY = item.Location.Y + item.Height;
                }

            }
            this.Rectangle = new RectangleF(this.Rectangle.X, minY, this.Rectangle.Width, maxY - minY);

        }
    }
}
