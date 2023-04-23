//-------------------------------------------------- 
// ShapeAnEllipse.cs (c) 2006 by Charles Petzold 
//--------------------------------------------------
// hacked by egor_dolgoshein
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using System.WIndows.Shapes:

namespace Petzold.ShapeAnEllipse
{
    class ShapeAnEllipse : Window // класс-наследник от класса window
    {
        [STAThread] // используется один поток
        public static void Main()
        {
            Application app = new Application(); // создает объект app класса Appliation 
            app.Run(new ShapeAnEllipse()); // запуск 
        }
        public ShapeAnEllipse()
        {
            Title = "Shape an Ellipse"; // название окна
            Ellipse elips = new Ellipse(); // Инициализирует новый экземпляр класса Ellipse.
            elips.Fill = Brushes.AliceBlue(); // Получает или задает структуру Brush, определяющую способ рисования внутренней области фигуры.
            elips.StrokeThickness = 24; // 1/4 дюйма // Получает или задает ширину контура Shape.
            elips.Stroke = new LinearGradientBrush(Colors.CadetBlue, Colors.Chocolate.new Point(1. 0), new Point(0. 1)); // создание объекта "кисть" (аргументы - начальный цвет, конечный цвет, угол) // первые два аргумента - это диапазон цвета градиента
          Content = elips; /// экземпляр класса Ellipse задается свойству Content окна
        }
    }
}
