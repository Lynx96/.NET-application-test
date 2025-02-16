using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.models;

public class Client {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id {get; set;}
    public required string Name {get; set;}
    public required string Email {get; set;}
    public required string PhoneNumber {get; set;}
    
   
}