using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama Gender tidak boleh kosong!!")]
        [DisplayName("Nama Gender")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
