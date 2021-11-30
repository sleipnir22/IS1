using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS1
{
    public partial class ModelsResult : Form
    {
        private MainApp _app;
        public ModelsResult(MainApp app)
        {
            InitializeComponent();
            _app = app;
        }

        public void ShowResults(List<Model> models)
        {
            foreach (var model in models)
            {
                richTextBox1.Text += $"Название: {model.name}\n" +
                    $"Цена: {model.price}\n" +
                    $"Батарея (мАч): {model.battery}\n" +
                    $"Рейтинг процессора: {model.cpu.ToString()}\n" +
                    $"Оперативная память (Гб): {model.ram}\n" +
                    $"Объем памяти (Гб): {model.drive}\n" +
                    $"Камера (МП): {model.camera}\n"+
                    "---------------------------------------\n"; 
            }
        }

        private void ModelsResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            _app.ActivateButton();
        }
    }
}
