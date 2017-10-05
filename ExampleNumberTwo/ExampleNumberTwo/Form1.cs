using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleNumberTwo
{
//    Задание 3 Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы.Необходимо создать следующие обработчики:
// ■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: вну- три прямоугольника, снаружи, на границе прямоугольника.Домашнее задание №1 Домашнее задание № Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться; 
//■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вашего окна; 
//■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна текущие координаты мыши x и y

    public partial class Form1 : Form
    {
        bool controlPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (controlPressed == false)
                {
                    MessageBox.Show("Текущая кнопка Снаружи Прямоугольника");
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (controlPressed == false)
                {
                    if (((e.X>=242 && e.X <= 252) || (e.X>=10 && e.X <= 0)) && (e.Y >= 0 && e.Y <= 177))
                        MessageBox.Show("Текущая кнопка на границе Прямоугольника");
                    else
                        MessageBox.Show("Текущая кнопка Внутри Прямоугольника");
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            controlPressed = e.Control;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Text = String.Format("Ширина={0} Высота={1}", ClientSize.Width, ClientSize.Height);
            }
            else
                Text = String.Format("X={0} Y={1}", e.X, e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                Text = String.Format("Ширина={0} Высота={1}", ClientSize.Width, ClientSize.Height);
            }
            else
            Text = String.Format("X={0} Y={1}", e.X, e.Y);
        }
    }
}
