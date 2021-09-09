using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Omnibus : TransportePublico
    {
        protected int ordenOmnibus;
        public Omnibus(int pasajeros , int ordenOmnibus) : base(pasajeros)
        {
            this.ordenOmnibus = ordenOmnibus;
        }

       
        
        protected override void Avanzar()
        {
            throw new NotImplementedException();
        }

        protected override void Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string Ordenar()
        {
            return "Omnibus " + ordenOmnibus;
        }
    
    }
}
