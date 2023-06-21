﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Complex : Pair
    {
        public Complex(double a, double b) : base(a, b)
        {
        }

        public override Pair Add(Pair p)
        {
            return new Complex(this.A+p.A,this.B+p.B);
        }

        public override Pair Conj()
        {
            return new Complex(A,-B);
        }

        public override Pair Div(Pair p)
        {
            return new Complex((this.A*p.A+this.B*p.B)/(p.A*p.A+p.B*p.B),
                (this.A*p.B+this.B*p.A)/(p.A * p.A + p.B * p.B));
        }

        public override bool Equ(Pair p)
        {
            return (this.A==p.A)&&(this.B==p.B);
        }

        public override Pair Mult(Pair p)
        {
            return new Complex(this.A*p.A-this.B*p.B, this.A*p.B + p.A*this.B);
        }

        public override Pair Sub(Pair p)
        {
            return new Complex(this.A - p.A, this.B -p.B);
        }

        public override string? ToString()
        {
            if(B>0)
                return A+"+"+B+"i";
            else if(B<0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}