﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polynomial
{
    using System;
    using PolyInterface;

    /// <summary>
    /// The abstract class all implementations inherit from
    /// </summary>
    public abstract class Polynomial
    {
        public Polynomial(params double[] coefficients)
        {
            this.coefficients = new double[coefficients.Length];

            for (int i = 0; i < coefficients.Length; i++)
                this.coefficients[i] = coefficients[i];
        }

        public abstract double Evaluate(double value);

        protected double[] coefficients = null;
    }

}