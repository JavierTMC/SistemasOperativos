using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Actividad2_MateriaPrima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //LISTAS
        static List<Entradas> listEntradas = new List<Entradas>();
        static List<Salida> listSalidas = new List<Salida>();
        static List<Salida> listReportes = new List<Salida>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textbNombre.Text;
                int cantidad = int.Parse(textbCantidad.Text);
                decimal precioUnitario = decimal.Parse(textbPrecioUnitario.Text);
                
                //GENERAR MATERIA ENTRANTE
                Entradas entrante = new Entradas(nombre, cantidad, precioUnitario);

                    //AGREGAR EL ENTRANTE A LA LISTA DE ENTRADAS
                    listEntradas.Add(entrante);

                    lblMensaje.Text = "Guardado Exitosamente";
                    lblMensaje.Visible = true;
                    LimpiarControles();
                    textbNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        enum TipoArchivo
	{
	         ENTRADA, SALIDA, REPORTE
	}

        static bool List<T> (List<T> obj, TipoArchivo tipo)
        {
            try
            {
                if (TipoArchivo.ENTRADA == tipo)
                {
                    using (var fs = new FileStream("entradas.txt", FileMode.Append))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                        serializador.Serialize(fs, obj);
                        fs.Close();
                        return true;
                    }
                }
                else if (TipoArchivo.SALIDA == tipo)
                {
                    using (var fs = new FileStream("salidas.txt", FileMode.Append))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                        serializador.Serialize(fs, obj);
                        fs.Close();
                        return true;
                    }
                }
                else if (TipoArchivo.REPORTE == tipo)
                {
                    using (var fs = new FileStream("reporte.txt", FileMode.Create))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                        serializador.Serialize(fs, obj);
                        fs.Close();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }           
           
        }

        //static bool serializarObjeto(Object obj, TipoArchivo tipo)
        //{
        //    try
        //    {
        //        if (TipoArchivo.ENTRADA == tipo)
        //        {
        //            using (var fs = new FileStream("entradas.txt", FileMode.Append))
        //            {
        //                XmlSerializer serializador = new XmlSerializer(obj.GetType());
        //                serializador.Serialize(fs, obj);
        //                fs.Close();                        
        //                return true;
        //            }
        //        }
        //        else if (TipoArchivo.SALIDA == tipo)
        //        {
        //            using (var fs = new FileStream("salidas.txt", FileMode.Append))
        //            {
        //                XmlSerializer serializador = new XmlSerializer(obj.GetType());
        //                serializador.Serialize(fs, obj);
        //                fs.Close();
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //}

        //static bool GuardarInformacionEntrada(string info)
        //{
        //    try
        //    {
        //        string path = @"C:\Users\JavierTMezaC\Desktop\Actividad2.txt";              

        //        using (var fs = new FileStream(path,FileMode.Append))
        //        {
        //            using (StreamWriter sw = new StreamWriter(fs))
        //            {
        //                sw.Write(info + Environment.NewLine);
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }

        //}

        public void LimpiarControles()
        {
            textbNombre.Clear();
            textbCantidad.Clear();
            textbPrecioUnitario.Clear();
            textbProyectoDestino.Clear();            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabpSalidas")
                    {
                        cbNombreProducto.Items.Clear();
                        //DESERIALIZAR LISTA
                        if (listEntradas .Count == 0 && DeserializarLista(TipoArchivo.ENTRADA))
                        {
                            foreach (var item in listEntradas)
                            {
                                cbNombreProducto.Items.Add(item.Nombre);
                            }
                        }
                        else
                        {
                            foreach (var item in listEntradas)
                            {
                                //MOSTRAR EL NOMBRE SI AUN HAY PRODUCTOS EN ALMACEN
                                if (item.Cantidad > 0)
                                {
                                    cbNombreProducto.Items.Add(item.Nombre);
                                }
                            }
                        }                        
                    }
                else if (tabControl1.SelectedTab.Name == "tabpReportes")
                {
                    cbProyectoDestino.Items.Clear();
                    if (listSalidas.Count == 0 && DeserializarLista(TipoArchivo.SALIDA))
                    {
                        var proyectos = listSalidas.Select(d => d.ProyectoDestino).Distinct().ToList();

                        foreach (var item in proyectos)
                        {
                            cbProyectoDestino.Items.Add(item);
                        }
                    }
                    else
                    {
                        
                        var proyectos = listSalidas.Select(d => d.ProyectoDestino).Distinct().ToList();
                        foreach (var item in proyectos)
                        {
                            cbProyectoDestino.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        static bool DeserializarLista(TipoArchivo tipo)
        {
            try
            {
                if (tipo == TipoArchivo.ENTRADA)
                {
                     using (var fs = new FileStream("entradas.txt", FileMode.Open))
                        {
                            XmlSerializer xml = new XmlSerializer(listEntradas.GetType());
                            listEntradas =(List<Entradas>)xml.Deserialize(fs);
                            fs.Close();
                            return true;
                        }
                }
                else if (tipo == TipoArchivo.SALIDA)
                {
                    using (var fs = new FileStream("salidas.txt", FileMode.Open))
                        {
                            XmlSerializer xml = new XmlSerializer(listSalidas.GetType());
                            listSalidas = (List<Salida>)xml.Deserialize(fs);
                            fs.Close();
                            return true;
                        }
                }
                return false;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void cbNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbDisponiblesInventario.Text = listEntradas[cbNombreProducto.SelectedIndex].Cantidad.ToString();
            textbPrecioUnitarioSalida.Text = listEntradas[cbNombreProducto.SelectedIndex].PrecioUnitario.ToString();
        }

        private void textbCantidadSalidas_Leave(object sender, EventArgs e)
        {
            try
            {
                    int cantidad = int.Parse(textbCantidadSalidas.Text);
                    int disponibles = int.Parse(textbDisponiblesInventario.Text);
                    decimal precio = Convert.ToDecimal(textbPrecioUnitarioSalida.Text);
                    if (cantidad <= disponibles)
                    {
                        textbTotal.Text = (precio * cantidad).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Solo existen " + textbDisponiblesInventario.Text + " productos en almacen", "Alertaa!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            
        }

        private void btnGenerarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = listEntradas[cbNombreProducto.SelectedIndex].Nombre;
                int cantidad = int.Parse(textbCantidadSalidas.Text);
                decimal precioUnitario = listEntradas[cbNombreProducto.SelectedIndex].PrecioUnitario;
                string proyectoDestino = textbProyectoDestino.Text;
                decimal total = Convert.ToDecimal(textbTotal.Text);

                if (cantidad <= int.Parse(textbDisponiblesInventario.Text) && textbProyectoDestino.Text.Length != 0)
                {
                    //GUARDAR LA SALIDA EN LA LISTA DE SALIDAS
                    listSalidas.Add(new Salida(nombre,cantidad,precioUnitario,proyectoDestino,total));
                    //RESTAR LA CANTIDAD DE SALIDA AL PRODUCTO ORIGINAL
                    int resta = listEntradas[cbNombreProducto.SelectedIndex].Cantidad - cantidad;
                    listEntradas[cbNombreProducto.SelectedIndex].Cantidad = resta;
                    //MOSTRAR MENSAJE DE ALERTA
                    lblMensajeSalida.Text = "Producto de Salida: Generado Correctamente";
                    lblMensajeSalida.Visible = true;
                    //LIMPIAR CONTROLES
                    LimpiarControlesSalida();
                    //ACTUALIZAR COMBOBOX, DISPONIBLES Y PRECIO UNITARIO
                    cbNombreProducto.SelectedIndex = 0;
                    textbDisponiblesInventario.Text = listEntradas[cbNombreProducto.SelectedIndex].Cantidad.ToString();
                    textbPrecioUnitarioSalida.Text = listEntradas[cbNombreProducto.SelectedIndex].PrecioUnitario.ToString();
                }
                else
                {
                    MessageBox.Show("Indique el proyecto destino");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public void LimpiarControlesSalida()
        {
            textbCantidadSalidas.Clear();
            textbTotal.Clear();
            textbProyectoDestino.Clear();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                //GENERAR REPORTE DEACUERDO CON EL PROYECTO DESTINO SELECCIONADO
                foreach (var item in listSalidas)
                {
                    if (item.Nombre == cbProyectoDestino.SelectedText)
                    {
                        listReportes.Add(new Salida(item.Nombre, item.Cantidad, item.PrecioUnitario, item.ProyectoDestino, item.Total));
                    }
                }
                //SERIALIZAR LA LISTA DE REPORTES
                if (List<Salida>(listReportes, TipoArchivo.REPORTE))
                {
                    lblRutaReporte.Text = "Se genero correctamente el archivo reporte";
                }
                else
                    lblRutaReporte.Text = "Erro al generar reporte";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(listEntradas.Count != 0)
                List<Entradas>(listEntradas, TipoArchivo.ENTRADA);
                if(listSalidas.Count != 0)
                List<Salida>(listSalidas, TipoArchivo.SALIDA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
