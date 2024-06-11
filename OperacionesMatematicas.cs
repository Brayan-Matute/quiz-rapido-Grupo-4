namespace CalculadoraMAUI
{
    public class OperacionesMatematicas
    {
        public double Suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Division(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return numero1 / numero2;
        }

        public double Multiplicacion(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
