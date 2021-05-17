namespace RentSC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ТЦ
    {
        [Key]
        [Column("ID ТЦ")]
        public int ID_ТЦ { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Количество павильонов")]
        [Required]
        [StringLength(50)]
        public string Количество_павильонов { get; set; }

        [Required]
        [StringLength(50)]
        public string Город { get; set; }

        [Column(TypeName = "money")]
        public decimal Стоимость { get; set; }

        [Column("Кооэф.Добавочной стоимости")]
        public double Кооэф_Добавочной_стоимости { get; set; }

        [Required]
        [StringLength(50)]
        public string Этажность { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображения { get; set; }
    }
}
