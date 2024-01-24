// Использование пространства имён
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// класс с главным методом программы
class Demo
{
    const string txtTitle = "Перевод в другие системы счисления";
    static void Main()
    {
        byte num, baseInt;
        string txtMes;

        num = (byte) Int32.Parse(
            Interaction.InputBox("Введите число")
            );

        baseInt = (byte)Int32.Parse(
            Interaction.InputBox("Введите систему счисления \n" +
                                 " доступные системы: 2, 8, 16")
            );

        txtMes = $"Перевод выполнен: \n \n{Convert.ToString(num,baseInt)}";
        MessageBox.Show(txtMes,txtTitle,MessageBoxButtons.OK);
        
    }
}
