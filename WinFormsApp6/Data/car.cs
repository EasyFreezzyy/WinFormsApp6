using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp6.Data
{
    public class car
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string CarName { get; set; }
        public int Year { get; set; }
        public  decimal Price { get; set; }
        public List<Corzina> Corzinas { get; set; }
        public override string ToString()
        {
            return $"{Marka} | {CarName} | {Year} | {Price} Руб";
        }
    }
}
    

