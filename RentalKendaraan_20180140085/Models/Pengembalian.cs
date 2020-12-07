using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [DisplayName("Tanggal Pengembalian")]
        [Required(ErrorMessage = "Tanggal Pengembalian tidak boleh kosong!!")]
        public DateTime? TglPengembalian { get; set; }

        [DisplayName("Id Peminjaman")]
        [Required(ErrorMessage = "Id Peminjaman tidak boleh kosong!!")]
        public int? IdPeminjaman { get; set; }

        [DisplayName("Id Kondisi")]
        [Required(ErrorMessage = "Id Kondisi tidak boleh kosong!!")]
        public int? IdKondisi { get; set; }

        [DisplayName("Denda")]
        [Required(ErrorMessage = "Denda tidak boleh kosong!!")]
        public int? Denda { get; set; }

        [DisplayName("Kondisi")]
        public KondisiKendaraan IdKondisiNavigation { get; set; }

        [DisplayName("Peminjaman")]
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
