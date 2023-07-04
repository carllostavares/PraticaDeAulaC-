﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }
        
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}



