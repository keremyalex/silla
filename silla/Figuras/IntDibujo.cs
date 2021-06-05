using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silla.Figuras
{
    interface IntDibujo
    {
        void Dibujar();

        void Rotar(double angulo, double x, double y, double z);

        void Escalar(double anchoX, double altoY, double largoZ);

        void Trasladar(double x, double y, double z);
    }
}
