using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Rational : Pair
    {
        public Rational(double a, double b) : base(a, b)
        {

        }

       

        public override Pair Add(Pair p)
        {
            return new Rational(this.A * p.B + this.B * p.A, this.B * p.B);
        }

        public override Pair Conj()
        {
            throw new NotImplementedException();
        }

        public override Pair Div(Pair p)
        {
            return new Rational(this.A * p.B, this.B * p.A);
        }

        public override Pair Mult(Pair p)
        {
            return new Rational(this.A * p.A, this.B * p.B);
        }

        public override Pair Sub(Pair p)
        {
            return new Rational(this.A * p.B - this.B * p.A, this.B * p.B);
        }

        public bool Equal(Pair p)
        {
            return (this.A == p.A) && (this.B == p.B);

        }
        public bool greate(Pair p)
        {
            return ((this.A / this.B) > (p.B / p.A));

        }

        public bool Less(Pair p)
        {
            return ((this.A / this.B) < (p.B / p.A));

        }


        public override string? ToString()
        {
            return (this.A / this.B).ToString();
        }

        public override bool Equ(Pair p)
        {
            throw new NotImplementedException();
        }
    }

}