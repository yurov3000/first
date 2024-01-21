// Использование пространства имён
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// класс с главным методом программы
class InputConsoleDemo 
{
    // Главный метод программы
    static void Main() 
    {
        string txt, txtMes, txtTitle = "Расчёт соседних чисел";
        int res1, res2, txtInt;

        txt = Interaction.InputBox("Введите любое число");

        txtInt = Int32.Parse(txt);
        res1 = txtInt - 1;
        res2 = txtInt + 1;

        txtMes = $"Тройка чисел: {res1} - {txtInt} - {res2}";

        MessageBox.Show(txtMes, txtTitle, MessageBoxButtons.OK);
    }
}


// Закончили на 60 странице. Васильев C#.