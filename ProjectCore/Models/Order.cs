using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage ="Entrez votre prenom")]
        [Display(Name ="Prénom")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Entrez votre nom")]
        [Display(Name = "Nom")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Entrez votre adresse")]
        [Display(Name = "Adreese 1")]
        [StringLength(250)]
        public string AdresseLine1 { get; set; }

        
        [Display(Name = "Adreese 2")]
        [StringLength(250)]
        public string AdresseLine2 { get; set; }

        [Required(ErrorMessage = "Entrez votre boite postale")]
        [Display(Name = "Boite postale")]
        [StringLength(4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Entrez votre ville")]
        [Display(Name = "Ville")]
        [StringLength(250)]
        public string City { get; set; }

        [Required(ErrorMessage = "Entrez votre etat")]
        [Display(Name = "Etat")]
        [StringLength(250)]
        public string State { get; set; }

        [Required(ErrorMessage = "Entrez votre pays")]
        [Display(Name = "Pays")]
        [StringLength(250)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Entrez votre tel")]
        [Display(Name = "Tel")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(45)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "The email address is not entered in a correct format")]

        public string Email { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]

        public DateTime OrderCreateDate { get; set; } 
    }
}
