//---------------------------------------------- 
// TypeYourTitle.cs (c) 2006 by Charles Petzold 
//----------------------------------------------

using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.TypeYourTitle
{
    public class TypeYourTitle : Window //создан класс TypeYourTitle типа Window
    {         
        [STAThread]  // используется один поток       
        public static void Main()         
        {             
            Application app = new Application(); //создает объект app класса Appliation           
            app.Run(new TypeYourTitle()); // запуск
        }         
        protected override void OnTextInput (TextCompositionEventArgs args)         
        {             
            base.OnTextInput(args);             
            if (args.Text == "\b" && Title.Length > 0) // применяем метод Backspace, если есть хотя бы один символ                 
                Title = Title.Substring(0, Title .Length - 1); //нажатие Backspace приводит к удалению символа из строки           
          else if (args.Text.Length > 0 && !Char .IsControl(args.Text[0]))//  в противном случае                
                Title += args.Text; // присоединение текста к содержимому 
        }     
    } 
} 
