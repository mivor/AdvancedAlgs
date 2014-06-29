using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Fractal.CustomControls
{
    public class Fractal : Canvas
    {
        private readonly int[] _transform = { 0, 1, 2 };

        public static readonly DependencyProperty MarginDividerProperty = DependencyProperty.Register(
            "MarginDivider", typeof(int), typeof(Fractal), new PropertyMetadata(default(int), PropertyChangedCallback));
        public static readonly DependencyProperty MinLengthProperty = DependencyProperty.Register(
            "MinLength", typeof(int), typeof(Fractal), new PropertyMetadata(default(int), PropertyChangedCallback));
        public static readonly DependencyProperty RectangleBrushProperty = DependencyProperty.Register(
            "RectangleBrush", typeof(Brush), typeof(Fractal), new PropertyMetadata(default(Brush), PropertyChangedCallback));

        public int MarginDivider
        {
            get { return (int)GetValue(MarginDividerProperty); }
            set { SetValue(MarginDividerProperty, value); }
        }

        public int MinLength
        {
            get { return (int)GetValue(MinLengthProperty); }
            set { SetValue(MinLengthProperty, value); }
        }

        public Brush RectangleBrush
        {
            get { return (Brush)GetValue(RectangleBrushProperty); }
            set { SetValue(RectangleBrushProperty, value); }
        }


        public Fractal()
        {
            Draw(new Point(0, 0), Math.Min(ActualWidth, ActualHeight));

            SizeChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, EventArgs eventArgs)
        {
            Children.Clear();
            Draw(new Point(0, 0), Math.Min(ActualWidth, ActualHeight));
        }

        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var fractral = (Fractal)dependencyObject;
            fractral.OnPropertyChanged(fractral, new EventArgs());
        }

        private void Draw(Point origin, double length)
        {
            if (length <= MinLength)
            {
                AddRectangle(origin, length);
                return;
            }

            length /= 3;
            var margin = GetMargin(length);
            var rectLength = length - margin * 2;

            for (var col = 0; col < _transform.Length; col++)
            {
                for (var row = 0; row < _transform.Length; row++)
                {
                    // don't draw in rectangle center
                    if (col == 1 && row == 1) continue;

                    var offset = new Point
                    {
                        X = origin.X + margin + length * _transform[col],
                        Y = origin.Y + margin + length * _transform[row]
                    };
                    Draw(offset, rectLength);
                }
            }
        }

        private void AddRectangle(Point offset, double length)
        {
            var rect = new Rectangle
            {
                Stroke = RectangleBrush,
                Width = length,
                Height = length,
                RenderTransform = new TranslateTransform(offset.X, offset.Y)
            };

            Children.Add(rect);
        }

        private double GetMargin(double length)
        {
            return length / MarginDivider;
        }
    }
}