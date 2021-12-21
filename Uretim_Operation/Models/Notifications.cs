using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uretim_Operation.Models
{
    public class Notifications
    {
        [Key]
        public int Id { get; set; }
        public int IsNo { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BaslangicTarihi { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BitisTarihi { get; set; }
        public TimeSpan ToplamSure { get; set; }
        public string Statu { get; set; }
        public string DurusNedeni { get; set; }
    }
}
