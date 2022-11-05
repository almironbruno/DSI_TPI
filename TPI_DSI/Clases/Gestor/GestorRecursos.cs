using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace TPI_DSI.Clases
{
    internal class GestorRecursos
    {
        public BaseDatos baseDatos = new BaseDatos();
        public InterfazReserva interfaz { get; set; }
        private interfazMail interfazMail = new interfazMail();
        private List<CentroInvestigacion> centrosInvestigacion = new List<CentroInvestigacion>();
        private Estado estadoReservado { get; set; }        
        private List<string> listaMarcas = new List<string>();
        private List<string> listaModelos = new List<string>();
        private List<int> listaNumeroRT = new List<int>();
        private List<string> listaCentros= new List<string>();
        private List<string> listaEstados= new List<string>();
        private List<RecursoTecnologico> listaRecursosSeleccioando= new List<RecursoTecnologico>();
        private RecursoTecnologico recursoSeleccionado { get; set; }
        private string tipoRecursoSeleccionado { get; set; }
        private List<Turno> turnosRecursoSeleccionado { get; set; }
        private Turno turnoSeleccionado { get; set; }
        private Usuario usuarioActivo { get; set; }
        private AsignacionCientifico asignacionCientificoActivo = new AsignacionCientifico();
        private string mailCientifico { get; set; }
        private string usuarioSesionActiva { get; set; }
        private bool usuarioPerteneceCentro { get; set; }

       
        
        public void nuevaReserva() 
        {   /* Metodo 3: Inicia una nueva reserva, carga la base de datos,
             llama al metodo buscarTipoRecurso() , y llama a la interfaz */
            DataTable TiposRecursos = buscarTipoRecurso();
            interfaz.MostrarTipoRecursos(TiposRecursos);
        }

        public DataTable buscarTipoRecurso()
        {   /* Metodo 4: Crea un tabla que contiene en cada fila el nombre de cada tipo de recursos existente */
            DataTable tablaTipoRecursos = new DataTable();
            tablaTipoRecursos.Columns.Add();
            for (int i = 0; i < baseDatos.TiposRecursos.Count(); i++)
            {
                tablaTipoRecursos.Rows.Add();
                tablaTipoRecursos.Rows[i][0] = baseDatos.TiposRecursos[i].getNombre();
            }
            

            return tablaTipoRecursos;
        }

        public void tomarSeleccion(string seleccionTipoRecurso)
        {   /* Metodo 8: Toma la seleccion del tipo de recurso */
            tipoRecursoSeleccionado = seleccionTipoRecurso;
            buscarRecursoTecnologico();
        }

        private void buscarRecursoTecnologico()
        {   /* Metodo 9: Recorre todos los recursos tecnologicos de la base de datos, verifica tu tipo, 
             verifica si esta de baja definitiva o tecnica, genera una lista con los recursos de tipo,
            para cada recurso obtiene su datos que almacena en diferentes listas para mostrar*/

            List<RecursoTecnologico> recursosSeleccionados = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico Recurso in baseDatos.recursosTecnologicos)
            {   // Añade a la lista de recursosSeleccionados a los recursos que cumplen con el tipo
                if (tipoRecursoSeleccionado == "Todas") // para el caso de seleccionarse "Todas"
                {
                    if (Recurso.sosTecnicaODefinitiva() == false)
                    {
                        recursosSeleccionados.Add(Recurso);
                    }
                }
                else
                if (Recurso.esTipoSeleccionado(tipoRecursoSeleccionado)) // en caso de seleccionar un tipo especifico
                {
                    if (Recurso.sosTecnicaODefinitiva() == false)
                    {
                        recursosSeleccionados.Add(Recurso);
                    }
                }
            }
            foreach (RecursoTecnologico recursoTipo in recursosSeleccionados)
            {   // Recorre la lista recursosSeleccionados y obtiene sus datos 
                listaNumeroRT.Add(recursoTipo.numeroRT); // Metodo 17: getNumeroRT obtiene el numero de recurso tecnologico
                listaModelos.Add(recursoTipo.modelo.nombre); // Metodo 18: GetModelo obtiene el nombre del modelo del recurso tecnologico
                foreach (var i in baseDatos.marcas) //  Metodo 20: getMarca obtiene el nombre de la marca del recurso tecnologico
                {
                    if (recursoTipo.modelo.esTuMarca(i))
                    {
                      listaMarcas.Add(i.nombre);
                    }
                }
                foreach (CentroInvestigacion unCentro in baseDatos.CentrosInvestigacion)
                { 
                   if (recursoTipo.sosMiCentro(unCentro))
                    {
                        listaCentros.Add(unCentro.nombre);
                    }
                }
                // flujo alternativo: en caso de que el recurso no tenga turnos disponibles pasa a estar "No Disponible"
                if ( recursoTipo.getEstadoActual() == "Disponible" & recursoTipo.turnos.All(x=> x.cambioEstadoTurno.Last().estado.nombre=="Reservado"))
                {
                    
                    recursoTipo.cambiarANoDisponible();
                    baseDatos.GuardarEstadoRecurso(recursoTipo);
                };
                listaEstados.Add(recursoTipo.getEstadoActual());
                
            }
            foreach (RecursoTecnologico unRecurso in recursosSeleccionados) 
            { // Guarda los recursos seleccionados en el gestor
                listaRecursosSeleccioando.Add(unRecurso);
                
            }
    
            interfaz.MostrarRecursosPorColor(listaCentros,listaNumeroRT,listaModelos,listaMarcas,listaEstados);

            // Limpia las lista en caso de que el usuario seleccione otro tipo
            recursosSeleccionados.Clear();
            listaMarcas.Clear();
            listaNumeroRT.Clear();
            listaModelos.Clear();
            listaCentros.Clear();
            listaEstados.Clear();
        }
        public void tomarSeleccionRT(string numRT)
        {   /* Metodo 28: toma la seleccion del recurso tecnologico, verifica el cientifico y busca lo turnos
             para dicho recurso */
            
            foreach (RecursoTecnologico unRecurso in listaRecursosSeleccioando)
            {
                
                if (unRecurso.numeroRT.ToString() == numRT )
                {   // Obtiene el recurso seleccionado

                    recursoSeleccionado = unRecurso;
                }
            }
            obtenerUsuarioActivo();
            VerificarCientifico(usuarioSesionActiva);
            ObtenerTurnos(numRT);

        }
        public void ObtenerTurnos(string numRT)
        {  //Metodo 42 Busca los turnos para el recurso seleccionado
            // obtiene la fecha actual 
            DateTime fechaHoraActual = obtenerFechaHoraActual();
           turnosRecursoSeleccionado = recursoSeleccionado.MisTurnosDisponibles(fechaHoraActual);
           ordenarYagruparTurnos(turnosRecursoSeleccionado);
            

        }
         private DateTime obtenerFechaHoraActual() 
        {   // Metodo 43: obtiene la fecha hora actual
            return DateTime.Now;
        }

        internal void ordenarYagruparTurnos(List<Turno> listaTurnos)
        {  //Metodo 49: agrupa y ordena los turnos para mandarlos a la interfaz

            int tiempoAntelacion = 0; // cantidad de dias necesarios para reservar un turno
            List<string> turnosAMostrar = new List<string>();
            List<string> EstadoTurnosAMostrar = new List<string>();

            foreach (Turno unTurno in listaTurnos)
            {
                turnosAMostrar.Add(unTurno.fechaHoraInicio.Day.ToString());

                foreach(var i in unTurno.cambioEstadoTurno)
                {
                    if (i.esActual())
                    {
                        EstadoTurnosAMostrar.Add(i.estado.nombre);
                    }


                }
                
            }


            if (!usuarioPerteneceCentro) 
            {   // si el usuario no pertenece al centro, busca el tiempo de antelacion para reservad de turno
                foreach (CentroInvestigacion uncentro in baseDatos.CentrosInvestigacion)
                {
                    if (recursoSeleccionado.sosMiCentro(uncentro)) 
                    {
                        tiempoAntelacion = uncentro.tiempoAntelacionRecurso;
                    }
                }
             }
            interfaz.mostrarTurnosEnGrilla(turnosAMostrar,tiempoAntelacion,EstadoTurnosAMostrar);


            
        }

        public void tomarSeleccionTurno(string fechaTurno,string dia)
        { //Metodo 55: toma la seleccion del turno y muestra todos sus datos
            foreach (Turno i in turnosRecursoSeleccionado)
            {
                if(i.fechaHoraInicio.TimeOfDay.ToString().Substring(0, 5) == fechaTurno & i.fechaHoraInicio.Day.ToString() == dia)
                {
                    turnoSeleccionado = i;
                    interfaz.MostrarRecurso();
                    interfaz.mostrarTurno(turnoSeleccionado.fechaHoraInicio.Date.ToString());
                    interfaz.mostrarOpNotificacion();
                    
                }
            }


        }
        public void buscarTurnosFecha(string fecha)
        {//Metodo 52: busca los horarios y fecha para el turno
            List<List<string>> turnosFecha = new List<List<string>>();
            List<string> fechaInicio = new List<string>();
            List<string> fechaFin = new List<string>();
            List<string> estado = new List<string>();
            foreach (Turno unTurno in turnosRecursoSeleccionado)
            {
                if (unTurno.fechaHoraInicio.Day.ToString() == fecha )
                {
                    
                    fechaInicio.Add(unTurno.fechaHoraInicio.TimeOfDay.ToString());
                    fechaFin.Add(unTurno.fechaHoraFin.TimeOfDay.ToString());
                    foreach (var j in unTurno.cambioEstadoTurno)
                    {
                        if (j.esActual())
                        {
                            estado.Add(j.estado.getNombre());
                        }
                    } 
                }
                turnosFecha.Add(fechaInicio);
                turnosFecha.Add(fechaFin);
                turnosFecha.Add(estado);
            }
            interfaz.MostrarTurnosFecha(turnosFecha);
        }

        public void tomarConfirmacion()
        { //Metodo 61: toma la confirmacion con todos los datos 
            
           //EstadoTurno estadoReservado = buscarEstadoReservado(); <-- Se va
           turnoSeleccionado.registrarNuevaReserva();
           generarNotificacion();
           asignacionCientificoActivo.setearTurno(turnoSeleccionado); // metodo 66
            
            finCU();
        }
       
        private Estado buscarEstadoReservado()
        {   //Metodo 61: Busca el estado Reservado y lo retorna, en caso contrario, retorna un estado vacio
            Estado estadoReservado = new Estado();
            foreach (var i in baseDatos.estados)
            {
                if(i.sosReservado())
                {
                     estadoReservado = i;
                }
            }
            return estadoReservado;
        }

        public void obtenerUsuarioActivo()
        {   //Metodo 29: Busca el usuario de la sesion actual
            usuarioSesionActiva = baseDatos.Sesion.usuario.nombre; //Metodo 30: obtiene el nombre del usuario
        }
        public void VerificarCientifico(string nombreUsuario)
        {   /* Metodo 31: Verifica que el cientifico pertenesca al centro del recurso tecnologico seleccionado,
               recorre todos los centros de investigacion, busca al que pertenezca el recurso seleccionado,
               consulta si el nombre de usuario por parametro pertenece a dicho centro */
            foreach (CentroInvestigacion unCentro in baseDatos.CentrosInvestigacion)
            {
                if (recursoSeleccionado.sosMiCentro(unCentro))
                {
                    if (unCentro.esCientificoDelCI(nombreUsuario))
                    {
                        mailCientifico = unCentro.getMail(nombreUsuario);
                        asignacionCientificoActivo=unCentro.GetAsignacionCientifico(nombreUsuario);
                        usuarioPerteneceCentro = true;
                        break;
                    }
                }
                 
            }
        }
        private void generarNotificacion()
        {//Metodo 67: Envio de mail a interfazMail
            interfazMail.EnviarMail(mailCientifico);
        }
        private void finCU()
        {//metodo 69: fin del caso de uso
           
        }

    }

}
