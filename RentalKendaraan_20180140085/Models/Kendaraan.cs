using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong!!")]
        [DisplayName("Nama Kendaraanr")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi tidak boleh kosong!!")]
        [DisplayName("No Polisi")]
        public string NoPolisi { get; set; }

        [Required(ErrorMessage = "No Stnk tidak boleh kosong!!")]
        [DisplayName("No Stnk")]
        [MinLength(6, ErrorMessage = "No STNK minimal 6 angka")]
        [MaxLength(8, ErrorMessage = "No STNK maksimal 8 angka")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong!!")]
        public string Ketersediaan { get; set; }

        [DisplayName("Jenis Kendaraan")]
        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
