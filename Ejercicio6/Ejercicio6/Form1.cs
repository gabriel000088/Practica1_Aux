using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear(); //limpia el listBox

            int valorIngresado=0,contador=0,contador2=0;
            int no=0;
            int op = 2;

            valorIngresado = Convert.ToInt32(IngresarNumero.Text);

            if (comboBox_Opcion.SelectedIndex == 0) //seleccion "Numeros Primos"
            {
                String cad = " ";
                for (int i = 2; i <= valorIngresado; i++) 
                {
                    for (int j = 1; j <= i; j++) 
                    {
                        if (i % j == 0)  
                        {
                            contador++;  
                        }
                    }
                    if (contador == 2) 
                    {
                        //cad += op + ", "; 
                        listBoxNumeros.Items.Add(op);
                    }
                    contador = 0; 
                    op++;   
                }
            }

            else if (comboBox_Opcion.SelectedIndex == 1) //seleccion "Numeros Perfectos"
            {
                for (int i = 1; i <= valorIngresado; i++) 
                {
                    for (int j = 1; j < i; j++) 
                    {
                        if (i % j == 0)
                        {
                            contador2 += j;
                        }
                    }
                    if (contador2 == i)
                    {
                        listBoxNumeros.Items.Add(i); 
                    }
                    contador2 = 0;
                }
            }
            else if (comboBox_Opcion.SelectedIndex == 2) // Seleccion "Serie Fibonacci"
            {
                int a = 1;
                int b = 1;

                while (a <= valorIngresado)
                {
                    listBoxNumeros.Items.Add(a);
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
