using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(double nota1, double nota2, double nota3);

        string MensajeNotaFinal(double notaFinal);

        void Imprimir();
    }
}
