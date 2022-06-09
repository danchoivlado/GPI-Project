using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public static class DialogProcessor
    {
        #region Constructor

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private static List<Shape> selection = new List<Shape>();
        public static List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        private static List<Shape> shapeList = new List<Shape>();
        public static List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private static bool isDragging;
        public static bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private static PointF lastLocation;
        public static PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public static void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));

            rect.FillColor = Color.White;
            rect.BorderColor = Color.Black;
            rect.Opacity = 255;
            rect.BorderWidth = 1;

            ShapeList.Add(rect);
        }

        public static void AddRandomExample()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ExamShape exam = new ExamShape(new Rectangle(x, y, 300, 100));

            exam.FillColor = Color.White;
            exam.BorderColor = Color.Black;
            exam.Opacity = 255;
            exam.BorderWidth = 1;

            ShapeList.Add(exam);
        }

        public static void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ElipseShape elp = new ElipseShape(new Rectangle(x, y, 300, 150));
            elp.FillColor = Color.White;
            elp.BorderColor = Color.Black;
            elp.Opacity = 255;
            ShapeList.Add(elp);
        }

        public static void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape tri = new TriangleShape(new Rectangle(x, y, 100, 200));
            tri.FillColor = Color.White;
            tri.BorderColor = Color.Black;
            tri.Opacity = 255;

            ShapeList.Add(tri);
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public static Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    ShapeList[i].FillColor = Color.Green;

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public static void TranslateTo(PointF p)
        {
            foreach (var item in Selection)
            {

                item.Move(p.X - lastLocation.X, p.Y - lastLocation.Y);
                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);

            }
            lastLocation = p;
        }

        /// <summary>
        /// Прерисува всички елементи в shapeList върху e.Graphics 
        /// </summary>
        public static void ReDraw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Shape item in ShapeList)
            {
                item.DrawSelf(e.Graphics);
            }

            var grfx = e.Graphics;
            foreach (var item in Selection)
            {
                grfx.DrawRectangle(Pens.Black, item.Location.X - 3 - (item.BorderWidth / 2), item.Location.Y - 3 - (item.BorderWidth / 2), item.Width + 6 + (item.BorderWidth), item.Height + 6 + (item.BorderWidth));
                grfx.ResetTransform();
            }
        }

        public static void ConvertToStream(object obj, string filePath = null)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;
            if (filePath != null)
            {
                stream = new FileStream(filePath + ".bin",
                                  FileMode.Create);
            }
            else
            {
                stream = new FileStream("MyFile.bin",
                                        FileMode.Create,
                                        FileAccess.Write, FileShare.None);
            }
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public static object ConvertStremFromOtheFile(string filePath = null)
        {
            object obj;
            IFormatter formatter = new BinaryFormatter();
            Stream stream;
            if (filePath != null)
            {
                stream = new FileStream(filePath,
                                     FileMode.Open,
                                     FileAccess.Read, FileShare.None);
            }
            else
            {
                stream = new FileStream("MyFile.bin",
                                    FileMode.Open);
            }
            obj = formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }

        public static void GroupSelected()
        {
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;
            foreach (var item in Selection)
            {
                if (minX > item.Location.X)
                {
                    minX = item.Location.X;
                }
                if (minY > item.Location.Y)
                {
                    minY = item.Location.Y;
                }
                if (maxX < item.Location.X + item.Width)
                {
                    maxX = item.Location.X + item.Width;
                }
                if (maxY < item.Location.Y + item.Height)
                {
                    maxY = item.Location.Y + item.Height;
                }
            }
            var group = new ShapeGroup(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group.SubItem = Selection; // всяка 

            ClearShapeList();

            Selection = new List<Shape>();
            Selection.Add(group);
            ShapeList.Add(group);

        }

        public static void ClearShapeList()
        {
            foreach (var item in Selection)
            {
                ShapeList.Remove(item);
            }
        }

        public static void RemoveGroup()
        {
            for (int i = 0; i < Selection.Count; i++) // използваме фор цикъл понеже правим промени по листа който итерираме
            {
                if (Selection[i].GetType().Equals(typeof(ShapeGroup)))
                {
                    ShapeGroup group = (ShapeGroup)Selection[i];

                    ShapeList.AddRange(group.SubItem); // добавяме елементите от групата в нормален shape list 
                    ShapeList.Remove(Selection[i]);
                    Selection.Remove(Selection[i]);
                }
            }
        }

        public static void SetSize(float width, float height)
        {
            foreach (var item in Selection)

            {
                if (width > -1)
                {
                    if (item.GetType().Equals(typeof(ShapeGroup)))
                    {
                        ((ShapeGroup)item).GroupReSizeWidth(width);
                    }
                    else
                    {
                        item.Width = width;
                    }
                }
                if (height > -1)
                {
                    if (item.GetType().Equals(typeof(ShapeGroup)))
                    {
                        ((ShapeGroup)item).GroupReSizeHeight(height);
                    }
                    else
                    {
                        item.Height = height;
                    }
                }
            }
        }

        public static void SetBorderWidth(float borderWidth)
        {
            if (borderWidth >= 1)
            {
                foreach (var item in Selection)
                {
                    if (item.GetType().Equals(typeof(ShapeGroup)))
                    {
                        ((ShapeGroup)item).GroupBorderWidth(borderWidth);
                    }
                    item.BorderWidth = borderWidth;

                }
            }
        }
    }
}
