using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : IDraw, IColor
    {
        private int diameter = 0;
        private int locX = 0;
        private int locY = 0;
        private Ellipse circle = null;
        public Circle(int d)
        {
            diameter = d;
        }

        public void Draw(Canvas canvas)
        {
            if (circle != null)
                canvas.Children.Remove(circle);
            else
                circle = new Ellipse();

            circle.Height = diameter;
            circle.Width = diameter;
            Canvas.SetTop(circle, locY);
            Canvas.SetLeft(circle, locX);
            canvas.Children.Add(circle);
        }

        public void SetColor(Color color)
        {
            if (circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                circle.Fill = brush;
            }
        }

        public void SetLocation(int xCoord, int yCoord)
        {
            locX = xCoord;
            locY = yCoord;
        }
    }
}
