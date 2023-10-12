using System.ComponentModel.DataAnnotations.Schema;

namespace RESTWithASPNETBD.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
