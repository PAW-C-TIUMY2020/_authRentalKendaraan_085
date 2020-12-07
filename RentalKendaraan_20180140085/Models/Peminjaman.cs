using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [Key]
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }

        [DisplayName("Tanggal Peminjaman")]
        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong!!")]
        public DateTime TglPeminjaman { get; set; }

        [Required(ErrorMessage = "Kendaraan tidak boleh kosong!!")]
        [DisplayName("Kendaraan")]
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Customer tidak boleh kosong!!")]
        [DisplayName("Customer")]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Jaminan tidak boleh kosong!!")]
        [DisplayName("Jaminan")]
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya tidak boleh kosong!!")]
        public int Biaya { get; set; }

        [DisplayName("Customer")]
        public Customer IdCustomerNavigation { get; set; }

        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }

        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; } 
    }
}
