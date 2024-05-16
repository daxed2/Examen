using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen
{
    public class Asignatura : Alumno,IAsignatura
    {

        public int N1;
        public int N2;
        public int N3;

        public string NombreAsignatura { get; set; }

        public string Horario { get; set; }

        public string NombreDocente { get; set; }


        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public void Imprimir()
        {
            double notaFinal1, notaFinal2;
            notaFinal1 = CalcularNotaFinal();
            notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine("**********************************");
            Console.WriteLine($"Nombre Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Numero Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nombre Alumno: {NombreAlumno}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre Docente: {NombreDocente}");
            Console.WriteLine("\n");
            Console.WriteLine(MensajeNotaFinal(notaFinal1));
            Console.WriteLine(MensajeNotaFinal(notaFinal2));
            Console.WriteLine("**********************************");

        }

        public string MensajeNotaFinal(double notaFinal)
        {
            string mensaje;
            switch ((int)notaFinal)
            {
                case int n when (n >= 0 && n < 60):
                    mensaje= "Reprobado";
                    break;
                case int n when (n >= 60 && n < 80):
                    mensaje = "Bueno";
                    break;
                case int n when (n >= 80 && n < 90):
                    mensaje = "Muy Bueno";
                    break;
                case int n when (n >= 90 && n <= 100):
                    mensaje = "Sobresaliente";
                    break;
                default:
                    return "Nota inválida";
                    
            }
            return $"Nota final: {notaFinal}% {mensaje}";
        }
    }
}
