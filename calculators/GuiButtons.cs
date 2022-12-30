using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ---------- made by Anthony Nabil farag  ---------------------
// ---------- code: 20210065 -----------------------------------



namespace calculators
{
    class GuiButtons
    {
        private string value;

        public GuiButtons(string v)
        {
            this.value = v;
        }

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string v)
        {
            value = v;
        }    
    }
}
