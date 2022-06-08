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
    }
}
