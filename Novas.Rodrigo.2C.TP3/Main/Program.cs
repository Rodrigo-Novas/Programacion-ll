using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;
using Archivos;
namespace Main
{
    class Program
    {
        static void Main(string[] args) //esta mal la cantidad que muestra testear mañana
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClase.Programacion, Alumno.EEstadoCuenta.Becado);
            uni += a1;
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458", Clases_Abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClase.Laboratorio, Alumno.EEstadoCuenta.Deudor);
                uni += a2;
            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Alumno a3 = new Alumno(3, "José", "Gutierrez", "12234456", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClase.Programacion, Alumno.EEstadoCuenta.Becado);
                uni += a3;
            }
            catch (AlumnoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            Alumno a4 = new Alumno(4, "Miguel", "Hernandez", "92264456", Clases_Abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClase.Legislacion, Alumno.EEstadoCuenta.AlDia);
            uni += a4;
            Alumno a5 = new Alumno(5, "Carlos", "Gonzalez", "12236456", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClase.Programacion, Alumno.EEstadoCuenta.AlDia);
            uni += a5;
            Alumno a6 = new Alumno(6, "Juan", "Perez", "12234656", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClase.Laboratorio, Alumno.EEstadoCuenta.Deudor);
            uni += a6;
            Alumno a7 = new Alumno(7, "Joaquin", "Suarez", "91122456", Clases_Abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClase.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            uni += a7;
            Alumno a8 = new Alumno(8, "Rodrigo", "Smith", "22236456", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClase.Legislacion, Alumno.EEstadoCuenta.AlDia);
            uni += a8;
            Profesor i1 = new Profesor(1, "Juan", "Lopez", "12224458", Clases_Abstractas.Persona.ENacionalidad.Argentino);
            uni += i1;
            Profesor i2 = new Profesor(2, "Roberto", "Juarez", "32234456", Clases_Abstractas.Persona.ENacionalidad.Argentino);
            uni += i2;
            try
            {
                uni += Universidad.EClase.Programacion;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                uni += Universidad.EClase.Laboratorio;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                uni += Universidad.EClase.Legislacion;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                uni += Universidad.EClase.SPD;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(uni.ToString());
            Console.ReadKey();
            Console.Clear();
            try
            {
                Universidad.Guardar(uni);
                Console.WriteLine("Archivo de Universidad guardado.");
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int jornada = 0;
                Jornada.Guardar(uni[jornada]);
                Console.WriteLine("Archivo de Jornada {0} guardado.", jornada);
                //Console.WriteLine(Jornada.Leer());
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();



        }
    }
}
