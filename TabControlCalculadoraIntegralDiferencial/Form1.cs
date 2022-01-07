using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlCalculadoraIntegralDiferencial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0, lineas=0;
        /*
         * explicar cómo declarar arreglos v: 
         * el por qué declaro el tipo aquí
         */
        double[,] funcion;
        string[] línea = null;
        double[] area;
        double[,] derivada;
        Pen ejes = new Pen(Color.Red, 1);
        Pen func = new Pen(Color.Blue, 2);
        Pen curva = new Pen(Color.Green, 2);
        Pen areas = new Pen(Color.DarkCyan, 1);
        Point origenArea;
        Point origenDerivada;
        Point[] fxAreas;
        Point[] fxFuncion;
        Point[] Diferencial;
        Graphics AreaFuncion;
        Graphics Derivada;
        //valor de margen, o area de trabajo para los bordes, en píxeles
        private int margen = 25;

        double max_fx = 0;
        double min_fx = 0;
        double max_x = 0;
        double min_x = 0;
        double max_dif = 0;
        double min_dif = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            origenArea = new Point(pnl_area.Width / 2, pnl_area.Height / 2);
            origenDerivada = new Point(pnl_derivada.Width / 2, pnl_derivada.Height / 2);
            AreaFuncion = pnl_area.CreateGraphics();
            Derivada = pnl_derivada.CreateGraphics();
            AreaFuncion.Clear(Color.WhiteSmoke);
            Derivada.Clear(Color.WhiteSmoke);
        }
        private void rtb_ingreso_TextChanged(object sender, EventArgs e)
        {
            lbl_prueba.Text = rtb_ingreso.Text;
            txt_prueba.Text = rtb_ingreso.Text;
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //tcl_Calculadora.SelectedIndex = 1;
            rtb_integral.Text = "";
            rtb_diferencial.Text = "";
            i = 0;
            lineas = 0;
            if(rtb_ingreso.TextLength!=0)
            {
                /*
                 * por cada caracter existente, detectará si existe salto de línea, 
                 * para determinar el número de líneas totales
                 */
                foreach (char salto in rtb_ingreso.Text)
                {
                    if (salto == '\n')
                    {
                        lineas++;
                    }
                }
                //y el tamaño acá v:
                funcion = new double[lineas, 2];
                //explicar esto v:
                línea = rtb_ingreso.Text.Split('\n');
                //crea el número de filas según el número de elementos de la variable lineas
                dgv_funcion.RowCount = lineas;
                dgv_area.RowCount = lineas - 1;
                dgv_derivada.RowCount = lineas - 1;
                // pasar de la tabla del rich text box, a una matriz de mx2
                for (i = 0; i <= lineas - 1; i++)
                {
                    string[] aux = línea[i].Split('\t');
                    funcion[i, 0] = Convert.ToDouble(aux[0]);
                    funcion[i, 1] = Convert.ToDouble(aux[1]);
                    //agregar los valores al DataGridView
                    dgv_funcion[0, i].Value = funcion[i, 0];
                    dgv_funcion[1, i].Value = funcion[i, 1];
                }
                //carpinteria de calculos v:
                area = new double[lineas - 1];
                derivada = new double[lineas - 1, 2];
                double suma = 0;
                for (i = 0; i <= lineas - 2; i++)
                {
                    area[i] = Math.Abs(funcion[i, 0] - funcion[i + 1, 0]) * (funcion[i, 1] + funcion[i + 1, 1]) / 2;
                    dgv_area[0, i].Value = area[i];
                    suma = suma + area[i];
                    derivada[i, 0] = (funcion[i, 0] + funcion[i + 1, 0]) / 2;
                    derivada[i, 1] = (funcion[i, 1] - funcion[i + 1, 1]) / (funcion[i, 0] - funcion[i + 1, 0]);
                    dgv_derivada[0, i].Value = derivada[i, 0];
                    dgv_derivada[1, i].Value = derivada[i, 1];
                }

//--------------------------------------------impresion de valores en los richtextbox de resultados v:
                #region impresion de valores en los richtextbox de resultados v:
                rtb_integral.Text = rtb_integral.Text + "El area bajo la curva es aprox:\t" + Convert.ToString(suma) + "\n\n";
                for (i = 0; i <= lineas - 2; i++)
                {
                    rtb_integral.Text = rtb_integral.Text + area[i] + "\n";
                    rtb_diferencial.Text = rtb_diferencial.Text + derivada[i, 0] + "\t\t" + derivada[i, 1] + "\n";
                }
                #endregion

//----------------------------------------------Impresion en una tabla dentro del RichTextBox
                #region Impresion en una tabla dentro del RichTextBox
                ////tomado de http://www.dotnetstuffs.com/how-to-add-text-in-a-created-table-in-a-richtextbox/
                //StringBuilder tableRtf = new StringBuilder();
                //tableRtf.Append(@"{\rtf1 ");
                //tableRtf.Append(@"\trowd");
                //tableRtf.Append(@"\cellx2000");
                //tableRtf.Append(@"\intbl  x");
                //tableRtf.Append(@"\cellx5000");
                //tableRtf.Append(@"\cell  f(x)");
                //tableRtf.Append(@"\intbl \cell \row"); //create row
                //for (i = 0; i < lineas - 1; i++)
                //{
                //    tableRtf.Append(@"\cellx2000  " + Convert.ToString(derivada[i, 0]));
                //    tableRtf.Append(@"\cellx5000                " + Convert.ToString(derivada[i, 1]));
                //    tableRtf.Append(@"\intbl \cell \row");
                //}
                //tableRtf.Append(@"\pard");
                //tableRtf.Append(@"}");
                //rtb_diferencial.Rtf = tableRtf.ToString();

                //StringBuilder tableRtf1 = new StringBuilder();
                //tableRtf1.Append(@"{\rtf1 ");
                //tableRtf1.Append(@"\trowd");
                //tableRtf1.Append(@"\cellx3000");
                //tableRtf1.Append(@"\intbl  Area");
                //tableRtf1.Append(@"\intbl \cell \row"); //create row
                //for (i = 0; i < lineas - 1; i++)
                //{
                //    tableRtf1.Append(@"\cellx3000    " + Convert.ToString(area[i]));
                //    tableRtf1.Append(@"\intbl \cell \row");
                //}
                //tableRtf1.Append(@"\pard");
                //tableRtf1.Append(@"\intbl  El area bajo la curva se aproxima a: " + Convert.ToString(suma));
                //tableRtf1.Append(@"}");
                //rtb_integral.Rtf = Convert.ToString(tableRtf1);
                #endregion
                graficar(funcion,derivada);
            }
        }
        private void btn_Funcion_Click(object sender, EventArgs e)
        {
            tcl_Calculadora.SelectedIndex = 0;
        }
        private void btn_derivada_Click(object sender, EventArgs e)
        {
            tcl_Calculadora.SelectedIndex = 2;
        }
        private void btn_integral_Click(object sender, EventArgs e)
        {
            tcl_Calculadora.SelectedIndex = 1;

        }
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            tcl_Calculadora.SelectedIndex = 0;
        }
        private void tcl_Calculadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_calcular_Click(sender, e);
        }
        void graficar (double [,]fx, double [,] dif_fx)
        {
            AreaFuncion.Clear(Color.WhiteSmoke);
            Derivada.Clear(Color.WhiteSmoke);
            if (fx.Length != 0)
            {
                double[] aux_fx = new double[fx.GetLength(0)];
                double[] aux_x = new double[fx.GetLength(0)];
                double[] aux_difx = new double[fx.GetLength(0) - 1];
                for (i = 0; i < fx.GetLength(0);i++ )
                {
                    aux_fx[i] = (fx[i,1]);
                    aux_x[i] = (fx[i, 0]);
                    if(i<fx.GetLength(0)-1)
                    {
                        aux_difx[i] = dif_fx[i, 1];
                    }
                }
                max_fx = max(aux_fx);
                min_fx = min(aux_fx);
                max_x = min(aux_x);
                min_x = max(aux_x);
                max_dif = max(max(aux_fx), max(aux_difx));
                min_dif = min(min(aux_fx), min(aux_difx));
                if(min_fx>0)
                {
                    min_fx = 0;
                }
                if(max_fx<0)
                {
                    max_fx = 0;
                }
                if (min_dif > 0)
                {
                    min_dif = 0;
                }
                if (max_dif < 0)
                {
                    max_dif = 0;
                }

                fxAreas = new Point[fx.GetLength(0)];
                fxFuncion = new Point[fx.GetLength(0)];
                Diferencial = new Point[fx.GetLength(0) - 1];

                for (i = 0; i < fx.GetLength(0); i++)
                {
                    fxAreas[i] = new Point(relacion(margen, max_x, min_x, pnl_area.Width, fx[i, 0]), relacion(margen, max_fx, min_fx, pnl_area.Height, fx[i, 1]));
                    fxFuncion[i] = new Point(relacion(margen, max_x, min_x, pnl_derivada.Width, fx[i, 0]), relacion(margen, max_dif, min_dif, pnl_derivada.Height, fx[i, 1]));
                    if(i<fx.GetLength(0)-1)
                        Diferencial[i] = new Point(relacion(margen,max_x,min_x,pnl_derivada.Width,dif_fx[i,0]),relacion(margen,max_dif,min_dif,pnl_derivada.Height,dif_fx[i,1]));
                    if(i>=1)
                    {
                        Point[] poligono = {
                                               new Point(relacion(margen, max_x, min_x, pnl_area.Width, fx[i, 0]),relacion(margen, max_fx, min_fx, pnl_area.Height, 0.0)),
                                               new Point(relacion(margen, max_x, min_x, pnl_area.Width, fx[i, 0]),relacion(margen, max_fx, min_fx, pnl_area.Height, fx[i, 1])),
                                               new Point(relacion(margen, max_x, min_x, pnl_area.Width, fx[i-1, 0]),relacion(margen, max_fx, min_fx, pnl_area.Height, fx[i-1, 1])),
                                               new Point(relacion(margen, max_x, min_x, pnl_area.Width, fx[i-1, 0]),relacion(margen, max_fx, min_fx, pnl_area.Height, 0.0))
                                           };
                        AreaFuncion.FillPolygon(Brushes.LightCyan, poligono);
                        AreaFuncion.DrawPolygon(areas, poligono);
                    }
                }
                AreaFuncion.DrawLine(ejes, 0, relacion(margen, max_fx, min_fx, pnl_area.Height, 0.0), pnl_area.Width, relacion(margen, max_fx, min_fx, pnl_area.Height, 0.0));
                AreaFuncion.DrawLine(ejes, pnl_area.Width / 2, 0, pnl_area.Width / 2, pnl_area.Height);
                AreaFuncion.DrawCurve(func, fxAreas);

                Derivada.DrawLine(ejes, 0, relacion(margen, max_dif, min_dif, pnl_derivada.Height, 0.0), pnl_derivada.Width, relacion(margen, max_dif, min_dif, pnl_derivada.Height, 0.0));
                Derivada.DrawLine(ejes, pnl_derivada.Width / 2, 0, pnl_derivada.Width / 2, pnl_derivada.Height);
                Derivada.DrawCurve(func, fxFuncion);
                Derivada.DrawCurve(curva, Diferencial);
            }
        }
        double max(double[]array)
        {
            double m = array[0];
            for (int i = 0; i < array.Length;i++ )
            {
                if (m < array[i])
                {
                    m = array[i];
                }
            }
            return (m);
        }
        double max(double a, double b)
        {
            double m = a;
            if (b > a)
                m = b;
            return (m);
        }
        double min(double a, double b)
        {
            double m = a;
            if (b < a)
                m = b;
            return (m);
        }
        double min(double[] array)
        {
            double m = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (m > array[i])
                {
                    m = array[i];
                }
            }
            return (m);
        }
        /// <summary>
        /// Método que calcula la relacion lineal entre el valor dado y la cantidad de pixeles
        /// Calcula la cantidad de pixeles en funcion del rango de trabajo en una dimension (maximo y mínimo)
        /// el tamaño total de la longitud del elemento en el cual se grafica, un margen en el cual no se
        /// sobrepasará los valores a graficar y el valor de entrada
        /// </summary>
        int relacion(int margen, double max, double min, int h, double val)
        {
            int m = (int)((2*margen - h) * (val - min) / (max - min) + h - margen);
            return (m);
        }
        /// <summary>
        /// Método que calcula la relacion lineal entre el valor dado y la cantidad de pixeles
        /// Calcula la longitud en double en funcion del rango de trabajo en una dimension (maximo y mínimo)
        /// el tamaño total de la longitud del elemento en el cual se grafica, un margen en el cual no se
        /// sobrepasará los valores a graficar y el valor en pixeles
        /// </summary>
        double relacion(int margen, double max, double min, int h, int pix)
        {
            double m = (pix - (h - margen)) / ((2 * margen - h) / (max - min)) + min;
            return (m);
        }

        private void pnl_area_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = pnl_area.PointToClient(Cursor.Position);
            double[] coordenada = new double[2];
            coordenada[0] = relacion(margen, max_x, min_x, pnl_area.Width, punto.X);
            coordenada[1] = relacion(margen, max_fx, min_fx, pnl_area.Height, punto.Y);
            lbl_coordenadas.Text = "X: " + Convert.ToString(coordenada[0]) + " Y: " + Convert.ToString(coordenada[1]);
        }

        private void pnl_derivada_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = pnl_derivada.PointToClient(Cursor.Position);
            double[] coordenada = new double[2];
            coordenada[0] = relacion(margen, max_x, min_x, pnl_derivada.Width, punto.X);
            coordenada[1] = relacion(margen, max_dif, min_dif, pnl_derivada.Height, punto.Y);
            lbl_coordenadas.Text = "X: " + Convert.ToString(coordenada[0]) + " Y: " + Convert.ToString(coordenada[1]);
        }
    }
}
