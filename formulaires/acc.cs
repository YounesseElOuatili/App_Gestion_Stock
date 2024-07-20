using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class acc : UserControl
    {
        private static acc accueil;

        public static acc Instance
        {
            get
            {
                if (accueil == null)
                {
                    accueil = new acc();
                }
                return accueil;
            }
        }
        public acc()
        {
            InitializeComponent();
        }
    }
}
