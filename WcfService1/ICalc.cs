using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        double Add(double number1, double number2);

        [OperationContract]
        double Sub(double number1, double number2);

        [OperationContract]
        double Mult(double number1, double number2);

        [OperationContract]
        double Div(double number1, double number2);

        [OperationContract]
        Complex ComplexAdd(Complex n1, Complex n2);

        [OperationContract]
        Complex ComplexSub(Complex n1, Complex n2);

        [OperationContract]
        Complex ComplexMult(Complex n1, Complex n2);

        [OperationContract]
        Complex ComplexDiv(Complex n1, Complex n2);
    }

    [DataContract(Name ="Complex")]
    public class Complex
    {

        public Complex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }


        [DataMember]
        private double _real { set; get; }
        [DataMember]
        private double _imag { set; get; }

        public double Real
        {
            get { return _real; }
            set { _real = value;  }
        }

        public double Imag
        {
            get { return _imag; }
            set { _imag = value; }
        }
    }
}
