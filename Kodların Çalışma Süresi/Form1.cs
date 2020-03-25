using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace Kodların_Çalışma_Süresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); // StopWatch nesnemizi oluşturduk.

            int j = 0;
            TimeSpan x; // StopWatch dan gelecek süreyi tutacak nesnemiz.

            sw.Start(); // Süreyi Başlattık.

            for (int i = 0; i < 100000000; i++)
            {
                j = j + i; 
            }

            x=sw.Elapsed; // Süreyi Sonlandırdık ve Değeri aldık.

            label2.Text = x.ToString();
        }

    }
}
