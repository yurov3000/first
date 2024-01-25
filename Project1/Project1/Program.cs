// пространство имён
using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


// Класс с главным методом
class Demo
{
    // Константы
    const string txtTitle = "Перевод в другие системы счисления";

    // Гланый метод
    static void Main()
    {
        byte num, baseInt;
        string txtMes, txtInt, txtBaseInt;
        MessageBoxIcon icon;
        bool flag = true;

        // создали цикл для непрерывного выполнения программы
        while (flag)
        {
            txtInt = Interaction.InputBox("Введите число");

            // Проверка на пустую строку
            if (txtInt != "")
            {
                // Перевод из полученной строки в число
                num = (byte)Int32.Parse(txtInt);

                // Вводим систему счисления
                txtBaseInt = Interaction.InputBox("Введите систему счисления \n" +
                                         " доступные системы: 2, 8, 16");
                // проверка на пустой ввод графы системы счисления
                if (txtBaseInt != "")
                {
                    // формируем иконку сообщения
                    icon = MessageBoxIcon.Information;
                    // переводим строку от пользователя в число
                    baseInt = (byte)Int32.Parse(txtBaseInt);

                    txtMes = $"Перевод выполнен: \n \n{Convert.ToString(num, baseInt)}";
                    MessageBox.Show(txtMes, txtTitle, MessageBoxButtons.OK, icon);
                }
                else
                {
                    // формируем и выводим строку ошибки
                    icon = MessageBoxIcon.Error;
                    MessageBox.Show("Вы не ввели систему счисления!", txtTitle, MessageBoxButtons.OK, icon);
                }

            }
            else
            {
                // формируем и выводим строку ошибки
                icon = MessageBoxIcon.Error;
                MessageBox.Show("Вы не ввели число!", txtTitle, MessageBoxButtons.OK, icon);
                flag = false;
                break;

            }
        }
        
        
    }
}
