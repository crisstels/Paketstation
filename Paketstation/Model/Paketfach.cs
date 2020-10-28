using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketstation { 
    class Paketfach
    {
        #region Properties
        private Paket _inhalt;
        private int _nummer;
        private bool _status;
        private bool _belegt;
        #endregion

        #region Accessors/Modifiers
        public int Nummer { get => _nummer; set => _nummer = value; }
        public bool Status { get => _status; set => _status = value; }
        public bool Belegt { get => _belegt; set => _belegt = value; }
        internal Paket Inhalt { get => _inhalt; set => _inhalt = value; }
        #endregion

        #region Worker

        public void Oeffnen()
        {
            Status = true;
            Console.WriteLine("Fach wird geoeffnet....");
        }

        public void Schliessen()
        {
            Status = false;
            Console.WriteLine("Fach wird geschlossen...");
        }
        #endregion


    }
}
