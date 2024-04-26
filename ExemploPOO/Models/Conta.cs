using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExbirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}