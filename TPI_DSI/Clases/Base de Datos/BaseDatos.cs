using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TPI_DSI.Clases.Estados;

namespace TPI_DSI.Clases
{
    internal class BaseDatos
    {
        public TipoRecurso[] TiposRecursos = new TipoRecurso[2];
        public RecursoTecnologico[] recursosTecnologicos = new RecursoTecnologico[7];
        public List<Marca> marcas = new List<Marca> ();
        public List<CentroInvestigacion> CentrosInvestigacion = new List<CentroInvestigacion>();
        public List<Estado> estados = new List<Estado>();
        public Sesion Sesion = new Sesion();
        public BaseDatos()
        {
            //tipos de recursos tecnologicos
            TipoRecurso informatico = new TipoRecurso();
            informatico.nombre = "Informatico";
            TipoRecurso quimico = new TipoRecurso();
            quimico.nombre = "Quimico";
            TiposRecursos[0] = informatico;
            TiposRecursos[1] = quimico;

            //estado
            Estado Tecnico = new Estado();
            Tecnico.nombre = "Baja Tecnica";
            Estado disponible = new Estado();
            disponible.nombre = "Disponible";
            Estado Definitiva = new Estado();
            Definitiva.nombre = "Baja Definitiva";
            Estado InicioMantenimiento = new Estado();
            InicioMantenimiento.nombre = "Ini_Mant_correc";
            Estado Mantenimiento = new Estado();
            Mantenimiento.nombre = "Mantenimiento";
            Estado Reservado = new Estado();
            Reservado.nombre = "Reservado";
            Estado NoDisponible = new Estado();
            NoDisponible.nombre = "No disponible";

            estados.Add(Tecnico);
            estados.Add(Definitiva);
            estados.Add(InicioMantenimiento);
            estados.Add(Reservado);
            estados.Add(Mantenimiento);
            

            //cambio Estado
            CambioEstadoRT cambioEstadoRT0 = new CambioEstadoRT();
            cambioEstadoRT0.fechaHoraDesde = DateTime.Parse("01/01/2022");
            cambioEstadoRT0.fechaHoraHasta= DateTime.Parse("05/01/2022");
            cambioEstadoRT0.fechaHoraHasta = DateTime.Parse("05/01/2022");
            cambioEstadoRT0.estado = Tecnico;
            CambioEstadoRT cambioEstadoRT1 = new CambioEstadoRT();
            cambioEstadoRT1.fechaHoraDesde = DateTime.Parse("05/01/2022");
            cambioEstadoRT1.estado = disponible;
            CambioEstadoRT cambioEstadoRT2 = new CambioEstadoRT();
            cambioEstadoRT2.fechaHoraDesde = DateTime.Parse("03/01/2022");
            cambioEstadoRT2.fechaHoraHasta= DateTime.Parse("05/01/2022");
            cambioEstadoRT2.estado = InicioMantenimiento;
            CambioEstadoRT cambioEstadoRT3 = new CambioEstadoRT();
            cambioEstadoRT3.fechaHoraDesde = DateTime.Parse("05/01/2022");
            cambioEstadoRT3.estado = Mantenimiento;
            CambioEstadoRT cambioEstadoRT4 = new CambioEstadoRT();
            cambioEstadoRT4.fechaHoraDesde = DateTime.Parse("15/01/2022");
            cambioEstadoRT4.estado = InicioMantenimiento;
            CambioEstadoRT cambioEstadoRT5 = new CambioEstadoRT();
            cambioEstadoRT5.fechaHoraDesde = DateTime.Parse("05/04/2022");
            cambioEstadoRT5.estado = disponible;
            CambioEstadoRT cambioEstadoRT6 = new CambioEstadoRT();
            cambioEstadoRT6.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT6.fechaHoraHasta= DateTime.Parse("05/02/2022"); 
            cambioEstadoRT6.estado = Tecnico;
            CambioEstadoRT cambioEstadoRT7 = new CambioEstadoRT();
            cambioEstadoRT7.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT7.estado = disponible;
            CambioEstadoRT cambioEstadoRT8 = new CambioEstadoRT();
            cambioEstadoRT8.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT8.fechaHoraHasta = DateTime.Parse("05/02/2022");
            cambioEstadoRT8.estado = Mantenimiento;
            CambioEstadoRT cambioEstadoRT9 = new CambioEstadoRT();
            cambioEstadoRT9.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT9.estado = Tecnico;
            CambioEstadoRT cambioEstadoRT10 = new CambioEstadoRT();
            cambioEstadoRT10.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT10.fechaHoraHasta= DateTime.Parse("05/02/2022"); 
            cambioEstadoRT10.estado = disponible;
            CambioEstadoRT cambioEstadoRT11 = new CambioEstadoRT();
            cambioEstadoRT11.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT11.estado = disponible;
            CambioEstadoRT cambioEstadoRT12 = new CambioEstadoRT();
            cambioEstadoRT12.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT12.fechaHoraHasta= DateTime.Parse("05/02/2022");
            cambioEstadoRT12.estado = InicioMantenimiento;
            CambioEstadoRT cambioEstadoRT13 = new CambioEstadoRT();
            cambioEstadoRT13.fechaHoraDesde = DateTime.Parse("05/02/2022");
            cambioEstadoRT13.estado = disponible;



            //Recursos Tecnologicos
            RecursoTecnologico Computadora = new RecursoTecnologico();
            Computadora.numeroRT = 1;
            Computadora.tipoRecursoTecnologico = informatico;
            Computadora.cambioEstadoRT.Add(cambioEstadoRT0);
            Computadora.cambioEstadoRT.Add(cambioEstadoRT1);
            
            RecursoTecnologico Computadora2 = new RecursoTecnologico();
            Computadora2.numeroRT = 4;
            Computadora2.tipoRecursoTecnologico = informatico;
            Computadora2.cambioEstadoRT.Add(cambioEstadoRT2);
            Computadora2.cambioEstadoRT.Add(cambioEstadoRT3);
            
            RecursoTecnologico Termometro = new RecursoTecnologico();
            Termometro.numeroRT = 2;
            Termometro.tipoRecursoTecnologico = quimico;
            Termometro.cambioEstadoRT.Add(cambioEstadoRT4);
            Termometro.cambioEstadoRT.Add(cambioEstadoRT5);

            RecursoTecnologico Termometro2 = new RecursoTecnologico();
            Termometro2.numeroRT = 3;
            Termometro2.tipoRecursoTecnologico = quimico;
            Termometro2.cambioEstadoRT.Add(cambioEstadoRT6);
            Termometro2.cambioEstadoRT.Add(cambioEstadoRT7);

            RecursoTecnologico Termometro3 = new RecursoTecnologico();
            Termometro3.numeroRT = 5;
            Termometro3.tipoRecursoTecnologico = quimico;
            Termometro3.cambioEstadoRT.Add(cambioEstadoRT8);
            Termometro3.cambioEstadoRT.Add(cambioEstadoRT9);

            RecursoTecnologico Microscopio = new RecursoTecnologico();
            Microscopio.numeroRT = 6;
            Microscopio.tipoRecursoTecnologico = quimico;
            Microscopio.cambioEstadoRT.Add(cambioEstadoRT10);
            Microscopio.cambioEstadoRT.Add(cambioEstadoRT11);

            RecursoTecnologico Microscopio2 = new RecursoTecnologico();
            Microscopio2.numeroRT = 7;
            Microscopio2.tipoRecursoTecnologico = quimico;
            Microscopio2.cambioEstadoRT.Add(cambioEstadoRT12);
            Microscopio2.cambioEstadoRT.Add(cambioEstadoRT13);

            //modelos
            Modelo modelo = new Modelo();
            modelo.nombre = "HighLine";
            Modelo modelo2 = new Modelo();
            modelo2.nombre = "XT-2";
            Modelo modelo3 = new Modelo();
            modelo3.nombre = "XT-3";
            Modelo modelo4 = new Modelo();
            modelo4.nombre = "JS-21";
            Modelo modelo5 = new Modelo();
            modelo5.nombre = "LT-3";
            Modelo modelo6 = new Modelo();
            modelo6.nombre = "LT-4.5";
            Modelo modelo7 = new Modelo();
            modelo7.nombre = "LT-4";

            //marcas
            Marca marca = new Marca();
            marca.nombre = "InduTek";
            Marca marca2 = new Marca();
            marca2.nombre = "Toyota";
            Marca marca3 = new Marca();
            marca3.nombre = "FireBase";

            //centroInvestigacion
            CentroInvestigacion centro = new CentroInvestigacion();
            centro.nombre = "UTN-FRC";
            centro.tiempoAntelacionRecurso = 10;
            CentroInvestigacion centro2 = new CentroInvestigacion();
            centro2.nombre = "UNC";
            centro2.tiempoAntelacionRecurso = 2;
            CentroInvestigacion centro3 = new CentroInvestigacion();
            centro3.nombre = "FAMAF";
            centro3.tiempoAntelacionRecurso = 1;

            //turnos
            Turno turno = new Turno();
            turno.fechaHoraInicio = DateTime.Parse("15/11/2022 11:00:00");
            turno.fechaHoraFin = turno.fechaHoraInicio.AddMinutes(20);
            Turno turno2 = new Turno();
            turno2.fechaHoraInicio = turno.fechaHoraFin.AddMinutes(20);
            turno2.fechaHoraFin = turno2.fechaHoraInicio.AddMinutes(20);
            Turno turno3 = new Turno();
            turno3.fechaHoraInicio = DateTime.Parse("15/11/2022 17:40:00");
            turno3.fechaHoraFin = turno3.fechaHoraInicio.AddMinutes(20);
            Turno turno4 = new Turno();
            turno4.fechaHoraInicio = DateTime.Parse("19/11/2022 17:40:00");
            turno4.fechaHoraFin = turno4.fechaHoraInicio.AddMinutes(20);
            Turno turno5 = new Turno();
            turno5.fechaHoraInicio = DateTime.Parse("19/11/2022 11:00:00");
            turno5.fechaHoraFin = turno5.fechaHoraInicio.AddMinutes(20);
            Turno turno6 = new Turno();
            turno6.fechaHoraInicio = DateTime.Parse("11/11/2022 9:30:00");
            turno6.fechaHoraFin = turno6.fechaHoraInicio.AddMinutes(25);
            Turno turno7 = new Turno();
            turno7.fechaHoraInicio = DateTime.Parse("11/11/2022 12:30:00");
            turno7.fechaHoraFin = turno7.fechaHoraInicio.AddMinutes(25);
            Turno turno8 = new Turno();
            turno8.fechaHoraInicio = DateTime.Parse("21/11/2022 12:30:00");
            turno8.fechaHoraFin = turno8.fechaHoraInicio.AddMinutes(25);
            Turno turno9 = new Turno();
            turno9.fechaHoraInicio = DateTime.Parse("8/11/2022 8:30:00");
            turno9.fechaHoraFin = turno9.fechaHoraInicio.AddMinutes(60);
            Turno turno10 = new Turno();
            turno10.fechaHoraInicio = DateTime.Parse("8/11/2022 9:30:00");
            turno10.fechaHoraFin = turno10.fechaHoraInicio.AddMinutes(60);
            Turno turno11 = new Turno();
            turno11.fechaHoraInicio = DateTime.Parse("8/11/2022 10:30:00");
            turno11.fechaHoraFin = turno11.fechaHoraInicio.AddMinutes(60);
            Turno turno12 = new Turno();
            turno12.fechaHoraInicio = DateTime.Parse("8/11/2022 15:00:00");
            turno12.fechaHoraFin = turno12.fechaHoraInicio.AddMinutes(60);
            Turno turno13 = new Turno();
            turno13.fechaHoraInicio = DateTime.Parse("20/11/2022 15:00:00");
            turno13.fechaHoraFin = turno13.fechaHoraInicio.AddMinutes(60);
            Turno turno14 = new Turno();
            turno14.fechaHoraInicio = DateTime.Parse("20/11/2022 17:00:00");
            turno14.fechaHoraFin = turno14.fechaHoraInicio.AddMinutes(60);
            Turno turno15 = new Turno();
            turno15.fechaHoraInicio = DateTime.Parse("20/11/2022 21:30:00");
            turno15.fechaHoraFin = turno15.fechaHoraInicio.AddMinutes(60);
            Turno turno16 = new Turno();
            turno16.fechaHoraInicio = DateTime.Parse("13/11/2022 11:30:00");
            turno16.fechaHoraFin = turno16.fechaHoraInicio.AddMinutes(30);
            Turno turno17 = new Turno();
            turno17.fechaHoraInicio = DateTime.Parse("13/11/2022 14:30:00");
            turno17.fechaHoraFin = turno17.fechaHoraInicio.AddMinutes(30);
            Turno turno18 = new Turno();
            turno18.fechaHoraInicio = DateTime.Parse("13/11/2022 21:30:00");
            turno18.fechaHoraFin = turno18.fechaHoraInicio.AddMinutes(30);
            Turno turno19 = new Turno();
            turno19.fechaHoraInicio = DateTime.Parse("22/11/2022 11:30:00");
            turno19.fechaHoraFin = turno19.fechaHoraInicio.AddMinutes(30);
            Turno turno20 = new Turno();
            turno20.fechaHoraInicio = DateTime.Parse("22/11/2022 21:30:00");
            turno20.fechaHoraFin = turno20.fechaHoraInicio.AddMinutes(30);
            Turno turno21 = new Turno();
            turno21.fechaHoraInicio = DateTime.Parse("26/11/2022 20:30:00");
            turno21.fechaHoraFin = turno21.fechaHoraInicio.AddMinutes(30);


            Disponible disponibles = new Disponible();

            //cambioEstadoTurno
            CambioEstadoTurno cambioEstadoTurno = new CambioEstadoTurno(disponibles,DateTime.Now);
            cambioEstadoTurno.estado = disponibles;
            cambioEstadoTurno.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno3 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno3.estado = disponibles;
            cambioEstadoTurno3.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno2 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno2.estado = disponibles;
            cambioEstadoTurno2.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno4 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno4.estado = disponibles;
            cambioEstadoTurno4.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno5 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno5.estado = disponibles;
            cambioEstadoTurno5.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno6 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno6.estado = disponibles;
            cambioEstadoTurno6.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno7 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno7.estado =  disponibles;
            cambioEstadoTurno7.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno8 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno8.estado = disponibles;
            cambioEstadoTurno8.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno9 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno9.estado = disponibles;
            cambioEstadoTurno9.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno10 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno10.estado = disponibles;
            cambioEstadoTurno10.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno11 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno11.estado = disponibles;
            cambioEstadoTurno11.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno12 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno12.estado = disponibles;
            cambioEstadoTurno12.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno13 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno13.estado = disponibles;
            cambioEstadoTurno13.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno14 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno14.estado = disponibles;
            cambioEstadoTurno14.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno15 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno15.estado = disponibles;
            cambioEstadoTurno15.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno16 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno16.estado = disponibles;
            cambioEstadoTurno16.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno17 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno17.estado = disponibles;
            cambioEstadoTurno17.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno18 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno18.estado = disponibles;
            cambioEstadoTurno18.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno19 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno19.estado = disponibles;
            cambioEstadoTurno19.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno20 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno20.estado = disponibles;
            cambioEstadoTurno20.fechaHoraDesde = DateTime.Now;
            CambioEstadoTurno cambioEstadoTurno21 = new CambioEstadoTurno(disponibles, DateTime.Now);
            cambioEstadoTurno21.estado = disponibles;
            cambioEstadoTurno21.fechaHoraDesde = DateTime.Now;
            turno.cambioEstadoTurno.Add(cambioEstadoTurno);
            turno2.cambioEstadoTurno.Add(cambioEstadoTurno3);
            turno3.cambioEstadoTurno.Add(cambioEstadoTurno2);
            turno4.cambioEstadoTurno.Add(cambioEstadoTurno4);
            turno5.cambioEstadoTurno.Add(cambioEstadoTurno5);
            turno6.cambioEstadoTurno.Add(cambioEstadoTurno6);
            turno7.cambioEstadoTurno.Add(cambioEstadoTurno7);
            turno8.cambioEstadoTurno.Add(cambioEstadoTurno8);
            turno9.cambioEstadoTurno.Add(cambioEstadoTurno9);
            turno10.cambioEstadoTurno.Add(cambioEstadoTurno10);
            turno11.cambioEstadoTurno.Add(cambioEstadoTurno11);
            turno12.cambioEstadoTurno.Add(cambioEstadoTurno13);
            turno13.cambioEstadoTurno.Add(cambioEstadoTurno14);
            turno14.cambioEstadoTurno.Add(cambioEstadoTurno15);
            turno15.cambioEstadoTurno.Add(cambioEstadoTurno12);
            turno16.cambioEstadoTurno.Add(cambioEstadoTurno16);
            turno17.cambioEstadoTurno.Add(cambioEstadoTurno17);
            turno18.cambioEstadoTurno.Add(cambioEstadoTurno18);
            turno19.cambioEstadoTurno.Add(cambioEstadoTurno19);
            turno20.cambioEstadoTurno.Add(cambioEstadoTurno20);
            turno21.cambioEstadoTurno.Add(cambioEstadoTurno21);

            //usuario
            Usuario usuario1 = new Usuario();
            usuario1.nombre = "cientifico 1";

            //personalCientifico
            PersonalCientifico cientifico = new PersonalCientifico();
            cientifico.nombre = "Juan Perez";
            cientifico.correoElectronicoInstitucional = "mailmail@gmail.com";
            cientifico.usuario=usuario1;
            //asignacionCientifico
            AsignacionCientifico asignacion1 = new AsignacionCientifico();
            AsignacionCientifico asignacion2 = new AsignacionCientifico();
            AsignacionCientifico asignacion3 = new AsignacionCientifico();
            asignacion1.fechaDesde = DateTime.Parse("01/01/2022");
            asignacion2.fechaDesde = DateTime.Parse("01/01/2022");
            asignacion3.fechaDesde = DateTime.Parse("01/01/2022");
            asignacion1.personalCientifico = cientifico;
            asignacion2.personalCientifico = cientifico;
            asignacion3.personalCientifico = cientifico;



            //sesion
            Sesion sesion1 = new Sesion();
            sesion1.activa = true;
            sesion1.usuario = usuario1;
            this.Sesion = sesion1;

            

            Computadora.turnos.Add(turno);
            Computadora.turnos.Add(turno2); 
            Computadora.turnos.Add(turno3);
            Computadora.turnos.Add(turno4);
            Computadora.turnos.Add(turno5);
            //Computadora2.turnos.Add(turno6);
            //Computadora2.turnos.Add(turno7);
            //Computadora2.turnos.Add(turno8);
            //Termometro.turnos.Add(turno9);
            //Termometro.turnos.Add(turno10);
            //Termometro.turnos.Add(turno11);
            Termometro2.turnos.Add(turno6);
            Termometro2.turnos.Add(turno7);
            Termometro2.turnos.Add(turno8);
            //Termometro.turnos.Add(turno14);
            Microscopio.turnos.Add(turno9);
            Microscopio.turnos.Add(turno10);
            Microscopio.turnos.Add(turno11);
            Microscopio.turnos.Add(turno12);
            Microscopio.turnos.Add(turno13);
            Microscopio.turnos.Add(turno14);
            Microscopio.turnos.Add(turno15);
            Microscopio2.turnos.Add(turno16);
            Microscopio2.turnos.Add(turno17);
            Microscopio2.turnos.Add(turno18);
            Microscopio2.turnos.Add(turno19);
            Microscopio2.turnos.Add(turno20);
            Microscopio2.turnos.Add(turno21);

            marca3.modelos.Add(modelo);
            marca2.modelos.Add(modelo2);
            marca2.modelos.Add(modelo3);
            marca3.modelos.Add(modelo4);
            marca.modelos.Add(modelo5);
            marca.modelos.Add(modelo6);
            marca.modelos.Add(modelo7);

           
            Computadora.modelo = modelo;
            Computadora2.modelo = modelo4;
            Termometro.modelo = modelo5;
            Termometro2.modelo = modelo6;
            Termometro3.modelo = modelo7;
            Microscopio.modelo = modelo3;
            Microscopio2.modelo = modelo2;

            marcas.Add(marca2);
            marcas.Add(marca);
            marcas.Add(marca3);

            recursosTecnologicos[0] = Computadora;
            recursosTecnologicos[1] = Termometro;
            recursosTecnologicos[2] = Termometro2;
            recursosTecnologicos[3] = Computadora2;
            recursosTecnologicos[4] = Termometro3;
            recursosTecnologicos[5] = Microscopio;
            recursosTecnologicos[6] = Microscopio2;
            centro.recursosTecnologicos.Add(Computadora);
            centro.recursosTecnologicos.Add(Microscopio);
            centro3.recursosTecnologicos.Add(Microscopio2);
            centro.recursosTecnologicos.Add(Computadora2);
            centro2.recursosTecnologicos.Add(Termometro);
            centro2.recursosTecnologicos.Add(Termometro3);

            centro.asignacionCientificos.Add(asignacion1);
            centro2.asignacionCientificos.Add(asignacion2);
            centro3.asignacionCientificos.Add(asignacion3);

            centro.recursosTecnologicos.Add(Termometro2);
            CentrosInvestigacion.Add(centro);
            CentrosInvestigacion.Add(centro2);
            CentrosInvestigacion.Add(centro3);



        }
        
        public void GuardarReservaTurno(RecursoTecnologico recurso)
        {

           var recursoActualizar = recursosTecnologicos.FirstOrDefault(x => x == recurso);
            var index = Array.IndexOf(recursosTecnologicos,recursoActualizar);

            if (index != -1)
                recursosTecnologicos[index] = recurso;
        }

        public void GuardarEstadoRecurso(RecursoTecnologico recurso)
        {
            var recursoActualizar = recursosTecnologicos.FirstOrDefault(x => x == recurso);
            var index = Array.IndexOf(recursosTecnologicos, recursoActualizar);

            if (index != -1) 
            { 
                recursoActualizar.cambiarANoDisponible();
                recursosTecnologicos[index] = recurso;
            }

        }
        //--------------



    }
}
