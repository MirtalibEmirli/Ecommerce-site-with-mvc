using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Models;

public class ShoppingDetails
{
    
    public required string FirstName { get; set; }
           
    public required string LastName { get; set; }
    [DataType(DataType.EmailAddress)]
    public required string Email { get; set; }
          
    public required string City { get; set; }
    [Range(15,75)]        
    public required string Age { get; set; }
}
