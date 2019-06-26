using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }       
        //Despues
        private async void button1_Click(object sender, EventArgs e)
        {
            //async y await esperan el resultado del otro metodo
            int i = await calculoDespues();

            lbl1.Text = "Numero es: " + i;
        }

        //Antes
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int i = calculoDespues();

        //    lbl1.Text = "Numero es: " + i;
        //}

        private static async Task<Int32> calculoDespues() 
        {
            Int32 resul =0;
            //await y async siempre van junatos para sincronizar
            // y tiene que devolverse con formato Task
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                for (int i = 0; i < 100; i++)
                {
                    resul = i;
                }
            });            

            return resul;
        }

        private static  Int32 calculoAntes()
        {
            Int32 resul = 0;            
                Thread.Sleep(10000);
                for (int i = 0; i < 100; i++)
                {
                    resul = i;
                } 
            return resul;
        }

        private void btnoperacion_Click(object sender, EventArgs e)
        {
            Int32 a = Convert.ToInt32(text1.Text);
            Int32 b = Convert.ToInt32(text2.Text);
            Int32 C = a + b;
            textresult.Text = C.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            textresult.Text = "";
            lbl1.Text = "";
        }
    }
}
