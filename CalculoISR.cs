using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ISR
{
    public class CalculoISR
    {
        double limInferior;
        double cuotaFija;
        double excedente;
        double subsidio = 0;

        public double Calcular(double sueldo)
        {
            if (sueldo > 0.01) //Indicar que el sueldo es mayor a 0
            {
                if (sueldo <= 578.52)
                {
                    limInferior = 0.01;
                    cuotaFija = 0.00;
                    excedente = 0.0192;
                }
                else if (sueldo <= 4910.18)
                {
                    limInferior = 578.53;
                    cuotaFija = 11.11;
                    excedente = 0.0640;
                }
                else if (sueldo <= 8629.20)
                {
                    limInferior = 4910.19;
                    cuotaFija = 288.33;
                    excedente = 0.1088;
                }
                else if (sueldo <= 10031.07)
                {
                    limInferior = 8629.21;
                    cuotaFija = 692.96;
                    excedente = 0.16;
                }
                else if (sueldo <= 12009.94)
                {
                    limInferior = 10031.08;
                    cuotaFija = 917.26;
                    excedente = 0.1792;
                }
                else if (sueldo <= 24222.31)
                {
                    limInferior = 12009.95;
                    cuotaFija = 1271.87;
                    excedente = 0.2136;
                }
                else if (sueldo <= 38177.69)
                {
                    limInferior = 24222.32;
                    cuotaFija = 3880.44;
                    excedente = 0.2352;
                }
                else if (sueldo <= 72887.50)
                {
                    limInferior = 38177.70;
                    cuotaFija = 7162.74;
                    excedente = 0.30;
                }
                else if (sueldo <= 97183.33)
                {
                    limInferior = 72887.51;
                    cuotaFija = 17575.69;
                    excedente = 0.32;
                }
                else if (sueldo <= 291550.00)
                {
                    limInferior = 97183.34;
                    cuotaFija = 25350.35;
                    excedente = 0.34;
                }
                else if (sueldo >= 291550.01)
                {
                    limInferior = 291550.01;
                    cuotaFija = 91435.02;
                    excedente = 0.35;
                }
            }
            return Resultado(sueldo, limInferior, cuotaFija, excedente, subsidio);
        }

        private double Resultado(double sueldo, double limInf, double cuoFij, double exce, double subsdo)
        {
            if (sueldo <= 1768.96)
            {
                subsdo = 407.02;
            }
            else if (sueldo <= 2653.38)
            {
                subsdo = 406.83;
            }
            else if (sueldo <= 3472.84)
            {
                subsdo = 406.62;
            }
            else if (sueldo <= 3537.87)
            {
                subsdo = 392.77;
            }
            else if (sueldo <= 4446.15)
            {
                subsdo = 382.46;
            }
            else if (sueldo <= 4717.18)
            {
                subsdo = 354.23;
            }
            else if (sueldo <= 5335.42)
            {
                subsdo = 324.87;
            }
            else if (sueldo <= 6224.67)
            {
                subsdo = 294.63;
            }
            else if (sueldo <= 7113.90)
            {
                subsdo = 253.54;
            }
            else if (sueldo <= 7382.33)
            {
                subsdo = 217.61;
            }

            return (sueldo - limInf)*exce+cuoFij-subsdo;
        }
    }
}
