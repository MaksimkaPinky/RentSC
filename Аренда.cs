namespace RentSC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Аренда
    {
        [Key]
        [Column("ID Аренды")]
        public int ID_Аренды { get; set; }

        [Column("ID Арендатора")]
        public int ID_Арендатора { get; set; }

        [Column("Название ТЦ")]
        [Required]
        [StringLength(50)]
        public string Название_ТЦ { get; set; }

        [Column("ID сотрудника")]
        public int ID_сотрудника { get; set; }

        [Column("№ Павильона")]
        [Required]
        [StringLength(50)]
        public string C__Павильона { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Начало аренды", TypeName = "date")]
        public DateTime Начало_аренды { get; set; }

        [Column("Окончание аренды", TypeName = "date")]
        public DateTime Окончание_аренды { get; set; }

        public virtual Арендаторы Арендаторы { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }
    }
}
