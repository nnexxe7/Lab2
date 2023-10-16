using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        ComplexNumber Add(ComplexNumber a, ComplexNumber b);

        [OperationContract]
        ComplexNumber Subtract(ComplexNumber a, ComplexNumber b);

        [OperationContract]
        ComplexNumber Multiply(ComplexNumber a, ComplexNumber b);

        [OperationContract]
        ComplexNumber Divide(ComplexNumber a, ComplexNumber b);
    }

    // Klasa reprezentująca liczby zespolone
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }
}
