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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sun sun;
        int angle = 0;
        public MainWindow()
        {
            InitializeComponent();
            Draw();


        }

        void Draw()
        {
            canvas.Children.Clear();

            sun = new Sun();
            canvas.Children.Add(sun);

            Cloud cloud = new Cloud();
            canvas.Children.Add(cloud);
            Canvas.SetRight(cloud, 60);
            Canvas.SetTop(cloud, -100);

            TextBlock tb = new TextBlock();
            tb.Text = "Я не умею рисовать :(";
            tb.FontSize = 30;
            tb.Foreground = Brushes.DeepSkyBlue;
            canvas.Children.Add(tb);
            tb.LayoutTransform = new RotateTransform(15);

            Ellipse polyana = new Ellipse();
            polyana.Fill = new SolidColorBrush(Color.FromRgb(100, 230, 100));
            polyana.Height = 206;
            polyana.Width = 898;
            canvas.Children.Add(polyana);
            Canvas.SetLeft(polyana, -10);
            Canvas.SetBottom(polyana, -100);
            this.MaxWidth = 700;

            Tree tree1 = new Tree();
            canvas.Children.Add(tree1);
            Canvas.SetBottom(tree1, 0);
            Canvas.SetLeft(tree1, -20);

            Tree tree2 = new Tree();
            canvas.Children.Add(tree2);
            Canvas.SetBottom(tree2, 0);
            Canvas.SetRight(tree2, 50);




        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                Draw();
                sun.LayoutTransform = new RotateTransform(angle += 15);
                
            }
        }
    }
}
