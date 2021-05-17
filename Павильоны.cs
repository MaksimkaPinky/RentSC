namespace RentSC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Павильоны
    {
        [Key]
        [Column("ID Павильона")]
        public int ID_Павильона { get; set; }

        [Column("Название ТЦ")]
        [StringLength(50)]
        public string Название_ТЦ { get; set; }

        [Column("№ Павильона")]
        [StringLength(50)]
        public string C__Павильона { get; set; }

        [StringLength(50)]
        public string Этаж { get; set; }

        [StringLength(50)]
        public string Статус { get; set; }

        public double? Площадь { get; set; }

        [Column("Стоимость за кв. м.", TypeName = "money")]
        public decimal? Стоимость_за_кв__м_ { get; set; }

        [Column("Кооэф.Добавочной стоимости")]
        public double? Кооэф_Добавочной_стоимости { get; set; }
    }
}
