using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Taxi : TransportePublico
    {
        protected int ordenTaxi;
        public Taxi(int pasajeros, int ordenTaxi) : base(pasajeros)
        {
            this.ordenTaxi = ordenTaxi;
        }

        public override string Ordenar()
        {
            return "Taxi " + ordenTaxi;
        }

        protected override void Avanzar()
        {
            throw new NotImplementedException();
        }

        protected override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
