using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Perceptron
{
    public partial class Presentacion : Form
    {
        List<Datos> lista;
        List<Peso> listaP;
        List<Umbral> listaU;
        Datos neurona;
        List<ErrorPatron> errores;
        List<double> valoresE;
        List<double> valoresP;
        double[] w;
        public Presentacion()
        {
            InitializeComponent();
            lista = new List<Datos>();
            listaP = new List<Peso>();
            listaU = new List<Umbral>();
            constanteText.Text = "1";
            errores = new List<ErrorPatron>();
            valoresE = new List<double>();
            valoresP = new List<double>();

        }

        double entradas, patrones, salidas,soma,y,errorIT = 0;
        double errorLineal = 0;
        double umbral = 0;
        string S = "S";
        private void entradasYSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Buscar Entradas";
            openFileDialog1.ShowDialog();

            string rutaEntrada = openFileDialog1.FileName;
            ConsultarEntradas(rutaEntrada);
        }

        public List<Datos> ConsultarEntradas(string ruta)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            Mapear(leer);

            leer.Close();
            fileStream.Close();

            return lista;
        }

        private void Mapear(StreamReader leer)
        {
            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                neurona = new Datos();
                char delimiter = ';';
                string[] DatosNeurona = Linea.Split(delimiter);

                cabeceraTablaEntradas(DatosNeurona);

                for (int i = 0; i < DatosNeurona.Length; i++)
                {
                    if(i == (DatosNeurona.Length - 1))
                    {
                        dataGridView1.Columns[i].HeaderText = "YD";
                        neurona.YD1 = Convert.ToDouble(DatosNeurona[i]);
                    }
                    else
                    {
                        dataGridView1.Columns[i].HeaderText = "X" + (i + 1);
                        neurona.Entradas.Add(Convert.ToDouble(DatosNeurona[i]));
                    }
                }
                lista.Add(neurona);
                dataGridView1.Rows.Add(DatosNeurona);
            }
        }
        public void cabeceraTablaEntradas(string[] datos)
        {
            dataGridView1.ColumnCount = datos.Length;
            for (int i = 0; i < datos.Length; i++)
            {
                if (i == (datos.Length - 1))
                {
                    dataGridView1.Columns[i].HeaderText = "YD";
                }
                else
                {
                    dataGridView1.Columns[i].HeaderText = "x"+ (i+1);
                }
            }
        }

        private void pesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Buscar Pesos";
            openFileDialog1.ShowDialog();

            string rutaEntrada = openFileDialog1.FileName;
            ConsultarPesos(rutaEntrada);
        }

        private List<Peso> ConsultarPesos(string ruta)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            MapearPesos(leer);

            leer.Close();
            fileStream.Close();

            return listaP;
        }
        private void MapearPesos(StreamReader leer)
        {
            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                Peso peso = new Peso();
                char delimiter = ';';
                string[] datos = Linea.Split(delimiter);

                tablaPesos.ColumnCount = datos.Length;

                for (int i = 0; i < datos.Length; i++)
                {
                    tablaPesos.Columns[i].HeaderText = "W" + (i + 1);
                    peso.listaPesos.Add(Convert.ToDouble(datos[i]));
                }
                listaP.Add(peso);
                tablaPesos.Rows.Add(datos);
            }
        }

        private List<Umbral> ConsultarUmbral(string ruta)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            MapearUmbral(leer);

            leer.Close();
            fileStream.Close();

            return listaU;
        }
        private void MapearUmbral(StreamReader leer)
        {
            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                Umbral umbral = new Umbral();
                char delimiter = ';';
                string[] datos = Linea.Split(delimiter);

                umbral.U = Convert.ToDouble(datos[0]);

                listaU.Add(umbral);
            }
        }

        private void umbralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Buscar Umbral";
            openFileDialog1.ShowDialog();

            string rutaEntrada = openFileDialog1.FileName;
            ConsultarUmbral(rutaEntrada);

            tablaUmbral.DataSource = listaU;
        }
        private void botonEntrenar_Click(object sender, EventArgs e)
        {
            EntrenarRed();
        }
        public void EntrenarRed()
        {
            int iteracionesP = 1,h = 0, f= 0,o = 0, yc = 0,m = 0;

            entradas = dataGridView1.Columns.Count - 1;
            salidas = 1;
            patrones = dataGridView1.Rows.Count - 1;
            

            //MessageBox.Show(patrones.ToString());

            w = new double[Convert.ToInt32(entradas)];

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.ElementAt(i).Entradas.Count; j++)
                {
                    valoresE.Add(lista.ElementAt(i).Entradas.ElementAt(j));
                }
            }

            for (int i = 0; i < listaP.Count; i++)
            {
                for (int j = 0; j < listaP.ElementAt(i).listaPesos.Count; j++)
                {
                    valoresP.Add(listaP.ElementAt(i).listaPesos.ElementAt(j));
                }
            }

            while (iteracionesP < Convert.ToInt32(iteracionesText.Text) && S.Equals("S"))
            {
                
                double yd;
                if (h < 1)
                {
                    for (int k = 0; k < valoresP.Count; k++)
                    {
                        w[k] = valoresP.ElementAt(k);
                        //MessageBox.Show(valoresE.ElementAt(k).ToString() + " " + valoresP.ElementAt(k));
                        soma += valoresE.ElementAt(k) * valoresP.ElementAt(k);
                    }

                    soma = soma - listaU.ElementAt(0).U;
                    CalcularSalidaRed(soma);
                    yd = lista.ElementAt(0).YD1;
                    CalcularErrores(y, yd);
                    //MessageBox.Show("Soma: " + soma + " YR: " + y + " YD:" + yd + "EL: " + errorLineal);

                    for (int p = 0; p < w.Length; p++)
                    {
                        w[p] = w[p] + Convert.ToDouble(rataText.Text) * errorLineal * valoresE.ElementAt(p);
                        //MessageBox.Show("Nuevos pesos: " + w[p]);
                    }

                    umbral = listaU.ElementAt(0).U + Convert.ToDouble(rataText.Text) * errorLineal * 1;
                    //MessageBox.Show("Umbral: " + umbral);
                }

                if (iteracionesP == 1)
                {
                    f = 1;
                    o = 2;
                    yc = 1;
                    m = 2;
                }
                else
                {
                    f = 0;
                    o = 0;
                    yc = 0;
                    m = 0;
                }

                for (int u = f; u < patrones; u++)
                {

                    soma = 0;
                    for (int i = 0; i < entradas; i++)
                    {
                        //MessageBox.Show("ValorE: "+valoresE.ElementAt(o) + " Peso: " + w[i]);
                        soma += valoresE.ElementAt(o) * w[i];
                        o++;
                    }
                    soma = soma - umbral;

                    CalcularSalidaRed(soma);
                    yd = lista.ElementAt(yc).YD1;
                    CalcularErrores(y, yd);
                    //MessageBox.Show("Soma: " + soma + " YR: " + y + " YD:" + yd+"EL: "+errorLineal);
                    for (int p = 0; p < w.Length; p++)
                    {
                        w[p] = w[p] + Convert.ToDouble(rataText.Text) * errorLineal * valoresE.ElementAt(m);
                        m++;
                        //MessageBox.Show("Nuevos pesos: " + w[p]);
                    }

                    umbral = umbral + Convert.ToDouble(rataText.Text) * errorLineal * 1;
                    //MessageBox.Show("Umbral: " + umbral);
                    yc++;
                }
                yc = 1;
                m = 2;
                iteracionesP++;
                h++;
                //MessageBox.Show("Iteracion: " + iteracionesP);
                CalcularErrorIteracion();

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void CalcularSalidaRed(double soma)
        {
            double euler = 2.7881; 

            if (activacionCombo.SelectedItem.ToString().Equals("LINEAL"))
            {
                y = soma;
            }
            else if (activacionCombo.SelectedItem.ToString().Equals("ESCALON"))
            {
                if (soma >= 0)
                {
                    y = 1;
                }
                else
                {
                    y = 0;
                }
            }
            else if (activacionCombo.SelectedItem.ToString().Equals("SIGMOIDE"))
            {
                y = 1 / (1 + Math.Pow(euler, -soma));
            }
        }

        public void CalcularErrores(double yr, double yd)
        {

            errorLineal = yd - yr; 

            ErrorPatron error = new ErrorPatron();
            error.Error = errorLineal / 1;
            //MessageBox.Show("Error Patron: "+error.Error.ToString());
            errores.Add(error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        public void CalcularErrorIteracion()
        {
            double suma = 0;
            patrones = dataGridView1.Rows.Count - 1;

            foreach (var item in errores)
            {
                suma += item.Error;
            }
            errorIT = suma / patrones;
            CompararErrores(errorIT);
            errores.Clear();
        }
        public void CompararErrores(double errorIT)
        {
            
            if (errorIT <= Convert.ToDouble(errorMaxText.Text)){
                MessageBox.Show("ErroriT: " + errorIT);
                S = "N";
                GuardarDatosIDeales();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Simular();
        }

        public void GuardarDatosIDeales()
        {
            StreamWriter escritorPesos = new StreamWriter("PesosIdeales.txt", false);
            StreamWriter escritorUmbral = new StreamWriter("UmbralIdeales.txt", false);

            

            for (int i = 0; i < w.Length; i++)
            {
                if(i == (w.Length-1))
                {
                    escritorPesos.Write($"{w[i]}");
                }
                else
                {
                    escritorPesos.Write($"{w[i]};");
                }
                
            }
            escritorUmbral.WriteLine(umbral.ToString());

            escritorPesos.Close();
            escritorUmbral.Close();
            ValidarEspaciosTabla();
        }
        public void ValidarEspaciosTabla()
        {
            tablaEntradasIdeales.ColumnCount = dataGridView1.Columns.Count - 1;

            for (int i = 0; i < tablaEntradasIdeales.ColumnCount; i++)
            {
                tablaEntradasIdeales.Columns[i].Name = "X" + (i + 1);
            }
        }
        int c = 0;
        public void Adicionar()
        {
            entradas = dataGridView1.Columns.Count - 1;
            if (c < entradas)
            {
                tablaEntradasIdeales.Rows[0].Cells[c].Value = entradasIText.Text;
            }
            else
            {
                MessageBox.Show("Todos los pesos han sido ingresados");
            }
            c++;
        }
        private List<Peso> ConsultarPesosIdeales(string ruta)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            MapearPesosIdeales(leer);

            leer.Close();
            fileStream.Close();

            return listaP;
        }
        private void MapearPesosIdeales(StreamReader leer)
        {
            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                Peso peso = new Peso();
                char delimiter = ';';
                string[] datos = Linea.Split(delimiter);

                tablaPesos.ColumnCount = datos.Length;

                for (int i = 0; i < datos.Length; i++)
                {
                    peso.listaPesos.Add(Convert.ToDouble(datos[i]));
                }
                listaP.Add(peso);
            }
        }
        public void Simular()
        {
            listaP = new List<Peso>();

            openFileDialog1.Title = "Buscar Pesos";
            openFileDialog1.ShowDialog();

            string rutaEntrada = openFileDialog1.FileName;
            ConsultarPesosIdeales(rutaEntrada);
            entradas = tablaEntradasIdeales.Columns.Count;
            valoresP = new List<double>();
            soma = 0;
            w = new double[Convert.ToInt32(entradas)];

            for (int i = 0; i < listaP.Count; i++)
            {
                for (int j = 0; j < listaP.ElementAt(i).listaPesos.Count; j++)
                {
                    valoresP.Add(listaP.ElementAt(i).listaPesos.ElementAt(j));
                }
            }

            for (int k = 0; k < valoresP.Count; k++)
            {
                w[k] = valoresP.ElementAt(k);
                MessageBox.Show(tablaEntradasIdeales.Rows[0].Cells[k].Value + " " + valoresP.ElementAt(k));
                soma += Convert.ToDouble(tablaEntradasIdeales.Rows[0].Cells[k].Value) * valoresP.ElementAt(k);
            }
            MessageBox.Show("Umbral:" + umbral);
            soma = soma - umbral;
            CalcularSalidaRed(soma);
            MessageBox.Show("Salida: " + y);

        }
    }
}
