using System;

namespace CapaLogica
{
    public class Operaciones
    {
        private int Num1; // se utiliza para agregar los valores a la pantalla.

        //se utilizan para almacenar los valores de la pantalla.
        private double valor1;
        private double valor2;
        //se utilizan para almacenar los valores de la pantalla.

        //Operaciones principales
        private char operador;
        private double suma;
        private double resta;
        private double multiplicar;
        private double dividir;
        private double cuadrado;
        private double raiz;
        //Operaciones principales

        //Constructor por defecto
        public Operaciones() { }

        public double Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public int AgregarValor
        {
            get { return Num1; }
            set { Num1 = value; }
        }

        public char Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public string Limpiar()
        {
            return "0";
        }

        public double Suma(double x,double y)
        {
            suma = x + y;

            return suma;
        }

        public double Resta(double x, double y)
        {
            resta = x - y;

            return resta;
        }

        public double Multiplicar(double x, double y)
        {
            multiplicar = x * y;

            return multiplicar;
        }

        public double Dividir(double x, double y)
        {
            if (y == 0)
            {
                
            }
            
            dividir = x / y;

            return dividir;
        }

        public double Cuadrado(double x)
        {
            cuadrado = Math.Pow(x, 2);

            return cuadrado;
        }
        public double Raiz(double x)
        {
            raiz = Math.Sqrt(x);

            return raiz;
        }

        public string Ayuda()
        {
            return "\t Glosario de operadores de la App" +
                "\n\n" +
                " 1 (+) : Signo de Adiccion, se utiliza para SUMAR 2 valores.\n" +
                " 2 (-) : Signo de Sustraccion, se utiliza para RESTAR 2 valores.\n" +
                " 3 (x) : Signo de Multiplicación, se utiliza para MULTIPLICAR 2 valores.\n" +
                " 4 (/) : Signo de División, se utiliza para DIVIDIR 2 valores.\n" +
                " 5 (x²) : Signo de Potenciacion, se utiliza para elevar un numero al cuadrado.\n" +
                " 6 (√) : Signo de Raiz cuadrada, se utiliza para determinar la raiz cuadrada de un valor.\n"+
                " 7 (Clear): Se utiliza para limpiar la pantalla \n" +
                " 8 (=) : Se utiliza para confirmar la operacion que desea realizar."+
                "\n\n" +
                "\tInformacion adicional:\n"+
                " 1) NO SE PUEDE DIVIDIR UN VALOR ENTRE 0 \n"+
                " 2) Nombre: Randdee J. Espinal Madrigal / Matricula: 2019-8915";
        }

    }
}
