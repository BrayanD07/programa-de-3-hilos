using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList();
        Thread hilo1;
        Thread hilo2;
        Thread hilo3;
        

        public void btnIngresar_datos_Click(object sender, EventArgs e)
        {

        }

        public void MyrMnr(int[] vector)
        {
            
            
            int n = vector.Length - 1;
            int c;
            int aux = 0;

            for (int a = 0; a <= n; a++)
            {
                for (int b = 0; b <= n; b++)
                {
                    if (b + 1 < n || b + 1 == n)
                    {
                        if (vector[b] < vector[b + 1])
                        {
                            aux = vector[b];
                            vector[b] = vector[b + 1];
                            vector[b + 1] = aux;
                        }
                    }
                }
            }
            listBox1.Items.Clear();
            for (c = 0; c <= n; c++)
            {
                listBox1.Items.Add(vector[c].ToString());
            }

        }

        public void MnrMyr(int[] vector)
        {
           
            int n = vector.Length - 1;
            int c;
            int aux = 0;

            for (int a = 0; a <= n; a++)
            {
                for (int b = 0; b <= n; b++)
                {
                    if (b + 1 < n || b + 1 == n)
                    {
                        if (vector[b] > vector[b + 1])
                        {
                            aux = vector[b];
                            vector[b] = vector[b + 1];
                            vector[b + 1] = aux;
                        }
                    }
                }
            }
            listBox2.Items.Clear();
            for (c = 0; c <= n; c++)
            {
                listBox2.Items.Add(vector[c].ToString());
            }
        }

        public void revez(int[] vector)
        {
           

            int n = vector.Length - 1;
            int c = 0;
            for (int a = 0; a < n; a++)
            {
                c = vector[a];
                vector[a] = vector[a + 1];
                vector[a + 1] = c;
            }


            listBox3.Items.Clear();
            for (c = 0; c <= n; c++)
            {
                listBox3.Items.Add(vector[c].ToString());
            }
            c++;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] vector = (int[])list.ToArray(typeof(int));
            object[] vector2 = new object[vector.Length];

            

            //MnrMyr(vector);
            revez(vector);
            MyrMnr(vector);
            Thread a = new Thread(MnrMyr(vector));
            a.Start();
        }
        
    }
}
