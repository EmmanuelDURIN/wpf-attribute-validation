using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeValidation
{
    public class Contact : ValidatorBase
    {
    [Required(ErrorMessage = " Name is required.")]
    [StringLength(50, ErrorMessage = "No more than 50 characters")]
    [Display(Name = "Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [StringLength(50, ErrorMessage = "No more than 50 characters")]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Valid email required e.g. abc@xyz.com")]
    public string Email { get; set; }

    [Display(Name = "Phone Number")]
    [Required]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
          ErrorMessage = "Entered phone format is not valid.")]
    public string PhoneNumber { get; set; }

    public string Address { get; set; }
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                        ErrorMessage = "Entered phone format is not valid.")]
    public string Mobile { get; set; }
    [Range(0,10000)]
    public int Fee { get; set; }

  }
}
