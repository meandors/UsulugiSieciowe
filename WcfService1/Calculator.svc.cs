using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalc
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Sub(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Mult(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Div(double number1, double number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (DivideByZeroException e)
            {
                throw new FaultException(e.ToString());
            }
            
        }

        public Complex ComplexAdd(Complex n1, Complex n2)
        {
            return new Complex(n1.Real + n2.Real, n1.Imag + n2.Imag);
        }

        public Complex ComplexSub(Complex n1, Complex n2)
        {
            return new Complex(n1.Real - n2.Real, n1.Imag - n2.Imag);
        }

        public Complex ComplexMult(Complex n1, Complex n2)
        {
            return new Complex(n1.Real * n2.Real + n1.Imag * n2.Imag * (-1), n1.Real * n2.Imag + n1.Imag * n2.Real);
        }

        public Complex ComplexDiv(Complex n1, Complex n2)
        {
            if (n1.Real.Equals(0))
            {
                throw new FaultException("Liczba 0");
            }
            double divider = n2.Real * n2.Real - n2.Imag * n2.Imag * (-1);
            double real = n1.Real * n2.Real + n1.Imag * n2.Imag;
            double imag = n1.Real * n2.Imag * (-1) + n1.Imag * n2.Real;

            return new Complex(real / divider,  imag/ divider);

        }
    }
}
