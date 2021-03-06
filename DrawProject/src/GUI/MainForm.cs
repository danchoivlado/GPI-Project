using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            DialogProcessor.ReDraw(sender, e);
        }

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
            DialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                var sel = DialogProcessor.ContainsPoint(e.Location);

                if (sel != null)
                {
                    if (DialogProcessor.Selection.Contains(sel))
                        DialogProcessor.Selection.Remove(sel);
                    else
                        DialogProcessor.Selection.Add(sel);

                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    DialogProcessor.IsDragging = true;
                    DialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (DialogProcessor.IsDragging)
            {
                if (DialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                DialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DialogProcessor.IsDragging = false;
        }

        private void elipseStrButton_Click(object sender, EventArgs e)
        {
            DialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void triangleStrBtn_Click(object sender, EventArgs e)
        {
            DialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                DialogProcessor.ConvertToStream(DialogProcessor.ShapeList, saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogProcessor.ShapeList = (List<Shape>)DialogProcessor.ConvertStream(openFileDialog1.FileName);
                viewPort.Invalidate();
            }
        }

        private void fillColorStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;

                foreach (var item in DialogProcessor.Selection)
                {
                    if (item.GetType().Equals(typeof(ShapeGroup)))
                    {
                        ((ShapeGroup)item).GroupFillColor(color);
                    }

                    item.FillColor = color;
                }

                InvalidateViewPort("Последно действие: Промяна на вътрешният цвят");
            }
        }

        private void InvalidateViewPort(string lastActionText)
        {
            statusBar.Items[0].Text = lastActionText;
            viewPort.Invalidate();
        }

        private void borderColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;

                foreach (var item in DialogProcessor.Selection)
                {
                    if (item.GetType().Equals(typeof(ShapeGroup)))
                    {
                        ((ShapeGroup)item).GroupBorderColor(color);
                    }
                    item.BorderColor = color;
                }

                InvalidateViewPort("Последно действие: Промяна на цвета на рамката");
            }
        }

        private void exampleFigure_Click(object sender, EventArgs e)
        {
            DialogProcessor.AddRandomExample();

            InvalidateViewPort("Последно действие: Рисуване на фигура");
        }

        private void groupSelectedButton_Click(object sender, EventArgs e)
        {
            if (DialogProcessor.Selection.Count >= 2)
            {
                DialogProcessor.GroupSelected();
                InvalidateViewPort("Групиране");
            }
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            DialogProcessor.RemoveGroup();
            InvalidateViewPort("Премахваме групата");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resize_Click(object sender, EventArgs e)
        {
            float width;
            float height;
            if (float.TryParse(widthTextBox.Text == "" ? "-1" : widthTextBox.Text, out width) && float.TryParse(heightTextBox.Text == "" ? "-1" : heightTextBox.Text, out height))
            {
                width = width < 0 ? -1 : width;
                height = height < 0 ? -1 : height;
                DialogProcessor.SetSize(width, height);
            }
            else
            {
                MessageBox.Show("Invalid numbers");

            }
            InvalidateViewPort("Resize");
        }

        private void borderWidthButton_Click(object sender, EventArgs e)
        {
            float borderWidth;
            if (float.TryParse(bordeWodthTextBox.Text == "" ? "1" : bordeWodthTextBox.Text, out borderWidth))
                DialogProcessor.SetBorderWidth(borderWidth);
            else
                MessageBox.Show("Invalid numbers");
            InvalidateViewPort("Промяна на дебелината на линията");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DialogProcessor.SetOpacity(trackBar1.Value);
            InvalidateViewPort("Добавяне на прозрачност");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogProcessor.Copy();
            InvalidateViewPort("Копиране");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogProcessor.Paste();
                InvalidateViewPort("Поставяне");
            }
            catch (Exception)
            {
                MessageBox.Show("Не сте копирали нищо");
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogProcessor.Delete();
            InvalidateViewPort("Изтриване");

        }
    }
}
