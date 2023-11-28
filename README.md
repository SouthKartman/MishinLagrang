# MishinLagrang

![image](https://github.com/SouthKartman/MishinLagrang/assets/93534577/4d95fc79-daef-4e65-984b-a0d9e668982b)



GraphPlotter is a simple and user-friendly mathematical program built with C# and WinForms. It is designed to graph mathematical functions on a two-dimensional coordinate plane.

## Features

- **Function Plotting:** GraphPlotter allows you to visualize mathematical functions on the coordinate plane. Simply input your function, and see its graph instantly.

- **Customization of Graph Appearance:** Easily customize line colors, styles, and point markers to make your graphs more visually appealing and informative.

- **Multiple Graphs on One Plot:** Ability to plot multiple graphs on the same coordinate plane for comparison and analysis.

## How to Use

1. **Download and Install:**
   - Clone the repository: `git clone https://github.com/yourusername/GraphPlotter.git`
   - Open the project in Visual Studio or your preferred C# IDE.
   - Build and run the application.

2. **Input Function:**
   - Launch the application and enter your mathematical function for graphing. Example: `y = x^2`.

3. **Adjust Parameters (Optional):**
   - Use the provided controls to customize the appearance of your graph.

4. **See the Result:**
   - Click the "Plot" button to view the graph of your function on the screen.

## Examples

```csharp
// Example usage in code (if applicable)
using System;
using System.Windows.Forms;
using GraphPlotterLib;

namespace GraphPlotterApp
{
    public partial class MainForm : Form
    {
        private Plotter plotter;

        public MainForm()
        {
            InitializeComponent();
            plotter = new Plotter();
        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            string function = FunctionTextBox.Text;
            plotter.Plot(function);
            plotter.Show();
        }
    }
}

Requirements
Visual Studio (or any C# IDE)
.NET Framework [version, if applicable]
License
This project is licensed under the [specify your license].

Notes
This application was created as a part of [mention any project or course, if applicable].
Any additional information you think is useful or important for users.




Одна из моих студенческих программ это простая и удобная математическая программа, написанная на [вашем языке программирования, например, Python], предназначенная для построения графиков функций на координатной плоскости.

Основные функции
Построение графиков функций: позволяет вам визуализировать математические функции на двумерной координатной плоскости. Просто введите свою функцию и увидьте ее график мгновенно.

Множественные графики на одной плоскости: Возможность строить несколько графиков на одной координатной плоскости для сравнения и анализа.

Как использовать
Установка зависимостей: [Пример команды для установки зависимостей, если необходимо]

Запуск программы: [Пример команды для запуска программы]

Ввод функции: Введите вашу математическую функцию для построения графика. Пример: y = x^2.

Настройка параметров (по желанию): Используйте доступные опции для настройки внешнего вида графика.

Получение результата: Увидите график вашей функции на экране.

