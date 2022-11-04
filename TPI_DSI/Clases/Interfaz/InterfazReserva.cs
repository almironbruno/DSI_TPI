using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_DSI
{
    public partial class InterfazReserva : Form
    {
        // Creacion de objetos
        Clases.GestorRecursos gestorRecursos = new Clases.GestorRecursos();
        public InterfazReserva()
        {
            InitializeComponent();
            gestorRecursos.interfaz = this;
        }


        private void InterfazReserva_Load(object sender, EventArgs e)
        {   //Metodo 1: opcionReserva que da Inicio del programa
            gestorRecursos.nuevaReserva();
            
        }

        public void MostrarTipoRecursos(DataTable tiposRecursos)
        {   // Metodo 6: Añade los tipos de recursos a la lista desplegable, Selecciona por defecto "Todas" 
            Cmb_TipoRecurso.Items.Add("Todas");
            Cmb_TipoRecurso.SelectedIndex = 0;
            for (int i = 0; i < tiposRecursos.Rows.Count; i++)
            {
                string dato = tiposRecursos.Rows[i][0].ToString();
                Cmb_TipoRecurso.Items.Add(dato);
            }
            //Añade el item "Todos" a la lista de centros
            cmb_Centro.Items.Add("Todos");
            cmb_Centro.SelectedIndex = 0;
            

        }


        private void Btn_Aceptar_Click(object sender, EventArgs e)
        { /* Metodo 7: Funcion que toma la seleccion del tipo de recurso,
           Arma la grilla para mostrar los recursos del tipo seleccioando*/
            Gril_RecursosTecnologicos.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Confirmar.Enabled = false;
            Gril_RecursosTecnologicos.ColumnCount = 5;
            Gril_RecursosTecnologicos.Columns[0].Width = 87;
            Gril_RecursosTecnologicos.Columns[1].Width = 87;
            Gril_RecursosTecnologicos.Columns[2].Width = 87;
            Gril_RecursosTecnologicos.Columns[3].Width = 87;
            Gril_RecursosTecnologicos.Columns[4].Width = 87;
            Gril_RecursosTecnologicos.Rows.Clear();
            Gril_RecursosTecnologicos.Columns[0].Name = "Centro";
            Gril_RecursosTecnologicos.Columns[1].Name = "NumeroRT";
            Gril_RecursosTecnologicos.Columns[2].Name = "Modelo";
            Gril_RecursosTecnologicos.Columns[3].Name = "Marca";
            Gril_RecursosTecnologicos.Columns[4].Name = "Estado";
            Gril_RecursosTecnologicos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gril_RecursosTecnologicos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gril_RecursosTecnologicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Realiza la llamada al gestor
            gestorRecursos.tomarSeleccion(Cmb_TipoRecurso.Text.ToString());
        }
        public void MostrarRecursosPorColor(List<string> centro, List<int> numeroRT, List<string> modelo, List<string> marca, List<string> estado)
        {   /* Metodo 26: Añade la filas a la grilla con los datos de cada recurso, colorea segun el estado,
             agrupa segun el centro al que pertenecen */
            IEnumerable<string> centrosUnicos = centro.Distinct(); // Crea una lista de centro que no se repiten
            foreach (var i in centrosUnicos)
            {
               if (cmb_Centro.Items.Contains(i)== false) 
                {
                    cmb_Centro.Items.Add(i); // Añade los centros a la lista desplegable 
                }
                
            }
            //Crea y añade las filas con los datos
            for (int i = 0; i < numeroRT.Count; i++)
            {
                if (cmb_Centro.Text == "Todos")
                {
                 Gril_RecursosTecnologicos.Rows.Add(centro[i], numeroRT[i], modelo[i], marca[i], estado[i]);
                }
                else
                if (centro[i]==cmb_Centro.Text.ToString()) { 
                Gril_RecursosTecnologicos.Rows.Add(centro[i], numeroRT[i], modelo[i], marca[i], estado[i]);
                }
            }
            // Colorea la grilla segun su estado
            foreach (DataGridViewRow row in Gril_RecursosTecnologicos.Rows)
            {
                if (row.Cells[4].Value.ToString() == "Disponible")
                {
                    row.Cells[4].Style.BackColor = Color.Blue;
                   
                    
                } else if (row.Cells[4].Value.ToString() == "Mantenimiento")
                {
                    row.Cells[4].Style.BackColor = Color.Green;
                   
                } else if(row.Cells[4].Value.ToString() == "No Disponible")
                {
                    row.Cells[4].Style.BackColor = Color.Red;

                }
                else if (row.Cells[4].Value.ToString() == "Ini_Mant_correc")
                {
                    row.Cells[4].Style.BackColor = Color.Gray;
                    
                }

            }

            Gril_RecursosTecnologicos.Sort(Gril_RecursosTecnologicos.Columns[0], ListSortDirection.Ascending);

        }

        private void Gril_RecursosTecnologicos_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {   /* Metodo 27: Toma la seleccion de un recurso tecnologico, obtiene el numeroRT del recurso seleccionado
             y lo manda al gestor */

            //Limpia la interfaz 
            Gril_DetalleTurnos.Rows.Clear();
            Gril_Turnos.Rows.Clear();
            Txt_DiaSemana.Clear();
            Txt_fecha.Clear();
            Txt_FechaHoraFin.Clear();
            Txt_FechaHoraInicio.Clear();
            Txt_Marca.Clear();
            Txt_Modelo.Clear();
            Txt_numeroRT.Clear();
            Gril_Turnos.ColumnCount = 0;

            string numRT = Gril_RecursosTecnologicos.SelectedRows[0].Cells[1].Value.ToString();
            // Solo permite seleccionar si el recurso está disponible
            if (Gril_RecursosTecnologicos.SelectedRows[0].Cells[4].Value.ToString() == "Disponible") 
            { 
                gestorRecursos.tomarSeleccionRT(numRT); 
            }
            else 
            {
                MessageBox.Show("¡No existen turnos disponibles para el recurso seleccionado!");
            }
            
        }

        public void mostrarTurnosEnGrilla(List<string> listaTurnosAMostrar, double tiempoAntelacion,List<string> estadosTurnos)
        {   /*Metodo 50: prepara la grilla y la muestra */
            Gril_Turnos.Enabled = false;
            Gril_Turnos.ColumnCount = 7;
            Gril_Turnos.Rows.Clear();
            Gril_DetalleTurnos.Refresh();
            List<string> diasDeLaSemana = new List<string>();
            diasDeLaSemana.Add("Lunes");
            diasDeLaSemana.Add("Martes");
            diasDeLaSemana.Add("Miercoles");
            diasDeLaSemana.Add("Jueves");
            diasDeLaSemana.Add("Viernes");
            diasDeLaSemana.Add("Sabado");
            diasDeLaSemana.Add("Domingo");
            Gril_Turnos.DefaultCellStyle.BackColor = Color.Red;
            Gril_Turnos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gril_Turnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gril_Turnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Gril_Turnos.ReadOnly = true;
            string dia = DateTime.Now.DayOfWeek.ToString();

            for (int i = 0; i < 7; i++)
            {   // crea las columnas con sus nombres correspondientes
                Gril_Turnos.Columns[i].Name = diasDeLaSemana[i];
                Gril_Turnos.Columns[i].Width = 66;
            }

            //Armado del Calendario
            int diaInicial = ((int)DateTime.Now.DayOfWeek) - 1;

            for (int i = 0; i < 5; i++)
            {   // Añade 4 filas correspondientes a un mes
                Gril_Turnos.Rows.Add();
            }
            // Recorre cada fila y cada columna dentro de la fila, se le coloca el valor correspondiente y se pinta
            for (int fila = 0; fila < Gril_Turnos.RowCount; fila++)
            {
                for (int columna = 0; columna < Gril_Turnos.ColumnCount; columna++)
                {
                    if (fila == 0 && diaInicial + columna <= 6) // Primera fila, para que arranque desde el dia actual
                    {
                        Gril_Turnos.Rows[fila].Cells[diaInicial + columna].Value = DateTime.Now.AddDays(tiempoAntelacion).Day + columna;
                        foreach (string unturno in listaTurnosAMostrar)
                        {   // verifica si existen turnos para el dia, colorea la celda

                            if (unturno == Gril_Turnos.Rows[fila].Cells[columna + diaInicial].Value.ToString())
                            {
                                Gril_Turnos.Rows[fila].Cells[columna + diaInicial].Style.BackColor = Color.Blue;
                                Gril_Turnos.Enabled = true;
                            }
                        }
                        continue;
                    }

                    if (fila > 0) // recorrido correspondiente a las demas filas
                    {
                        int valorCelda = ((int)Gril_Turnos.Rows[fila - 1].Cells[6].Value) + columna + 1;
                        int cantidadDiasMesActual = DateTime.DaysInMonth(((int)DateTime.Now.Year), ((int)DateTime.Now.Month));
                        if (valorCelda <= cantidadDiasMesActual) {
                            Gril_Turnos.Rows[fila].Cells[columna].Value = valorCelda;
                        } else 
                        {
                            Gril_Turnos.Rows[fila].Cells[columna].Value = valorCelda % cantidadDiasMesActual;
                        }
                        for (int i =0; i< listaTurnosAMostrar.Count; i++)
                        {
                            if (listaTurnosAMostrar[i] == Gril_Turnos.Rows[fila].Cells[columna].Value.ToString() & estadosTurnos[i] != "Reservado")
                            {
                                Gril_Turnos.Rows[fila].Cells[columna].Style.BackColor = Color.Blue;
                                Gril_Turnos.Enabled = true;

                            }
                        }
                    }

                }
            }
        }
        public void MostrarTurnosFecha(List<List<string>> turnosfecha)
        {   //Metodo 53: muestra los turnos correspondientes al dia seleccionado
            Gril_DetalleTurnos.Rows.Clear();
            Gril_DetalleTurnos.ColumnCount = 3;
            Gril_DetalleTurnos.Columns[0].Name = "Horario Inicio";
            Gril_DetalleTurnos.Columns[1].Name = "Horario Fin";
            Gril_DetalleTurnos.Columns[2].Name = "Estado";
            Gril_DetalleTurnos.Columns[0].Width = 130;
            Gril_DetalleTurnos.Columns[1].Width = 130;
            Gril_DetalleTurnos.Columns[2].Width = 130;
            Gril_DetalleTurnos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gril_DetalleTurnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (turnosfecha.Count != 0)
            {
                for (int i = 0; i < turnosfecha[0].Count; i++)
                {
                    Gril_DetalleTurnos.Rows.Add(turnosfecha[0][i].Substring(0, 5), turnosfecha[1][i].Substring(0, 5), turnosfecha[2][i]);
                    if (Gril_DetalleTurnos.Rows[i].Cells[2].Value.ToString() == "Disponible")
                    {
                        Gril_DetalleTurnos.Rows[i].Cells[2].Style.BackColor = Color.Blue;
                    } else if (Gril_DetalleTurnos.Rows[i].Cells[2].Value.ToString() == "Reservado")
                    {
                        Gril_DetalleTurnos.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        Gril_DetalleTurnos.Rows[i].Cells[2].Style.BackColor = Color.Gray;
                    }
                }
            }
        }
        private void Gril_Turnos_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {   //Metodo 51: Toma la seleccion del turno en el calendario

            // Se limpia la pantalla
            Gril_DetalleTurnos.Rows.Clear();
            Txt_DiaSemana.Clear();
            Txt_fecha.Clear();
            Txt_FechaHoraFin.Clear();
            Txt_FechaHoraInicio.Clear();
            Txt_Marca.Clear();
            Txt_Modelo.Clear();
            Txt_numeroRT.Clear();
        string fecha = Gril_Turnos.CurrentCell.Value.ToString();
            gestorRecursos.buscarTurnosFecha(fecha);
        }


        private void Gril_DetalleTurnos_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {   //Metodo 54: Toma la seleccion de la grilla con los detalle de cada turno
            if (Gril_DetalleTurnos.SelectedRows[0].Cells[2].Value.ToString() == "Disponible")
            {
                gestorRecursos.tomarSeleccionTurno(Gril_DetalleTurnos.SelectedRows[0].Cells[0].Value.ToString(),Gril_Turnos.SelectedCells[0].Value.ToString());
                Btn_Confirmar.Enabled = true;
            }
            

        }
        public void MostrarRecurso()
        {   //Metodo 56: Muestra los datos de cada recursos para su confirmacion
            Txt_numeroRT.Text = Gril_RecursosTecnologicos.SelectedRows[0].Cells[1].Value.ToString();
            Txt_Modelo.Text = Gril_RecursosTecnologicos.SelectedRows[0].Cells[2].Value.ToString();
            Txt_Marca.Text = Gril_RecursosTecnologicos.SelectedRows[0].Cells[3].Value.ToString();
            Gril_DetalleTurnos.Refresh();
        }

        public void mostrarTurno(string fechaTurno)
        {   //Metodo 57:  Muestra los datos del turno seleccionado para su confirmacion
            Txt_FechaHoraInicio.Text = Gril_DetalleTurnos.SelectedRows[0].Cells[0].Value.ToString();
            Txt_FechaHoraFin.Text = Gril_DetalleTurnos.SelectedRows[0].Cells[1].Value.ToString();
            Txt_DiaSemana.Text = Gril_Turnos.Columns[Gril_Turnos.SelectedCells[0].ColumnIndex].Name;
            Txt_fecha.Text = fechaTurno.Substring(0, 7);
        }

        public void mostrarOpNotificacion()
        {   //Metodo 58:  Muestra las opciones de notificacion para su confirmacion
            checkBox1.Enabled = true;
            checkBox1.Checked = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;

        }

        private void Btn_Cancelar_Click(object sender, System.EventArgs e)
        {   // Boton para cancelar el CU
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, System.EventArgs e)
        {   //Metodo 59 Confirmacion de la reserva
            Btn_Cancelar.Enabled = false;
            Btn_Confirmar.Enabled = false;
            gestorRecursos.tomarConfirmacion();
            Gril_DetalleTurnos.Rows.Clear();
            Gril_DetalleTurnos.ColumnCount = 0;
            Gril_Turnos.Rows.Clear();
            Gril_Turnos.ColumnCount = 0;
            Gril_RecursosTecnologicos.Rows.Clear();
            Gril_RecursosTecnologicos.ColumnCount = 0;

            // Mensaje de interfaz mail
            MessageBox.Show($"\t¡Notificación Enviada!\n"
                        +"\nUsted reservó el siguiente turno: \n" +
                            "\n\tFecha: \t\t" + Txt_fecha.Text +
                            "\n\tHora Inicio: \t" + Txt_FechaHoraInicio.Text +
                            "\n\tHora Fin: \t" + Txt_FechaHoraFin.Text 
                        + "\n\nPara el  recurso: \n" +
                            "\n\tNumeroRT: \t" + Txt_numeroRT.Text +
                            "\n\tModelo: \t\t" + Txt_Modelo.Text +
                            "\n\tMarca: \t\t" + Txt_Marca.Text);


            //Limpia la interfaz
            Txt_DiaSemana.Clear();
            Txt_fecha.Clear();
            Txt_FechaHoraFin.Clear();
            Txt_FechaHoraInicio.Clear();
            Txt_Marca.Clear();
            Txt_Modelo.Clear();
            Txt_numeroRT.Clear();
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Checked = false;
            checkBox2.Enabled = false;
            checkBox3.Checked = false;
            checkBox3.Enabled = false;
            
        }
    }
}

