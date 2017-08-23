using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaci.Infraestructure
{
    class DataUtil
    {
        /// <summary>
        /// Retorna una lista con los meses del año como texto
        /// </summary>
        /// <returns></returns>
        public static List<String> Months()
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES").DateTimeFormat;
            var meses = new List<String>();
            meses.Add("Meses");
            for (int i = 0; i < 12; i++)
            {
                meses.Add(dtinfo.GetMonthName(i + 1));
            }
            return meses;
        }
    }
}
