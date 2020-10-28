using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation
{
    class Paket
    {
        #region Properties
        private String _paketschein;
        private int _gewicht;
        private String _groesse;
        private String _empfaenger;
        private String _sender;
        #endregion

        #region Accessors/Modifiers
        public string Paketschein { get => _paketschein; set => _paketschein = value; }
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        public string Groesse { get => _groesse; set => _groesse = value; }
        public string Empfaenger { get => _empfaenger; set => _empfaenger = value; }
        public string Sender { get => _sender; set => _sender = value; }
        #endregion
    }
}
