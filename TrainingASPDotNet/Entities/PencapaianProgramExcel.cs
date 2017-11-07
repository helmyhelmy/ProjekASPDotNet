namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapaianProgramExcel")]
    public partial class PencapaianProgramExcel
    {
        public int Id { get; set; }

        public string KodProgram { get; set; }

        public string TarikhProgram { get; set; }

        public string BilanganHari { get; set; }

        public string Lulus { get; set; }

        public int? IdMuatNaikExcel { get; set; }

        public string Ralat { get; set; }

        public DateTime? TarikhDiimport { get; set; }

        public virtual MuatNaikExcel MuatNaikExcel { get; set; }
    }
}
