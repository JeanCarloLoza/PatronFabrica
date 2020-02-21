using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    interface IFabrica
    {
        public ITipoPago generar();
    }
}
