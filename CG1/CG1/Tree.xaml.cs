using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CG1
{
    /// <summary>
    /// Interaction logic for Tree.xaml
    /// </summary>
    public partial class Tree : UserControl
    {
        static Random rand = new Random();
        public Tree()
        {
            InitializeComponent();
            Rectangle trunk = new Rectangle();

            trunk.Width = 30 - rand.Next(11);
            trunk.Height = 35 - rand.Next(11);
            trunk.Fill = Brushes.Brown;
            canvas.Children.Add(trunk);
            Canvas.SetBottom(trunk, 0);

            int numOfTriangles = 3 + rand.Next(3);
            Polygon[] triangles = new Polygon[numOfTriangles];
            int level = (int)trunk.Height - 5;
            int maxwidth = 0;
            for (int i = 0; i < numOfTriangles; i++)
            {
                int width = 75 + 8 * (numOfTriangles) - 17 * (i + 1);
                maxwidth = maxwidth > width ? maxwidth : width;
                int height = 45 - 6 * (i + 1);

                Point baseL = new Point(0, 0);
                Point baseR = new Point(width, 0);
                Point heightPoint = new Point(width / 2, -height);

                triangles[i] = new Polygon();
                triangles[i].Points.Add(baseL);
                triangles[i].Points.Add(baseR);
                triangles[i].Points.Add(heightPoint);
                triangles[i].Fill = Brushes.Green;
                canvas.Children.Add(triangles[i]);
                Canvas.SetBottom(triangles[i], level);
                level += height - 8;

            }
            Canvas.SetLeft(trunk, -trunk.Width / 2 + maxwidth / 2);
            foreach (Polygon triangle in triangles)
            {
                Canvas.SetLeft(triangle, -triangle.Points[1].X / 2 + maxwidth / 2);
            }

        }
    }
}
