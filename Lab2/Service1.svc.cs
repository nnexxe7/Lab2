using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public ComplexNumber Add(ComplexNumber a, ComplexNumber b)
        {
            var result = new ComplexNumber
            {
                Real = a.Real + b.Real,
                Imaginary = a.Imaginary + b.Imaginary
            };
            return result;
        }

        public ComplexNumber Subtract(ComplexNumber a, ComplexNumber b)
        {
            var result = new ComplexNumber
            {
                Real = a.Real - b.Real,
                Imaginary = a.Imaginary - b.Imaginary
            };
            return result;
        }

        public ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
        {
            var result = new ComplexNumber
            {
                Real = (a.Real * b.Real) - (a.Imaginary * b.Imaginary),
                Imaginary = (a.Real * b.Imaginary) + (a.Imaginary * b.Real)
            };
            return result;
        }

        public ComplexNumber Divide(ComplexNumber a, ComplexNumber b)
        {
            double denominator = (b.Real * b.Real) + (b.Imaginary * b.Imaginary);
            if (denominator == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero.");
            }

            var result = new ComplexNumber
            {
                Real = ((a.Real * b.Real) + (a.Imaginary * b.Imaginary)) / denominator,
                Imaginary = ((a.Imaginary * b.Real) - (a.Real * b.Imaginary)) / denominator
            };
            return result;
        }
    }
}

