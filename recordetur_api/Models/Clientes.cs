using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace recordetur_api.Models
{
    public class Clientes
    {

        [Key]
        
        public int ClienteId { get; set; }

        
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }

        [JsonIgnore]
        public List<Reservas> Reservas { get; set; }
    }


}
