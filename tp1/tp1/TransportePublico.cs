using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; set; }

        protected TransportePublico(int pasajeros)

        {
            this.pasajeros = pasajeros;
        }

        protected abstract void Avanzar();
                
        protected abstract void Detenerse();

        public abstract string Ordenar();
    }
}
