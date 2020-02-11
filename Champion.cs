using System.Collections.Generic;
using System.Windows.Forms;

namespace DomaciZadatak13
{
    public abstract class Champion
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Class { get; set; }
        public int Cost { get; set; }

        
        public abstract List<Champion> GetData();
        public abstract string PrintList();
        public abstract void GetDropdown(ComboBox comboBox);
    }
}
