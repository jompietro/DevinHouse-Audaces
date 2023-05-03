using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public abstract class Animal
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public abstract void EmitirSom();
    }
}