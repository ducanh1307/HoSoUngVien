using System;

namespace CleanArch.Core.Entities
{
    public class UngVien
    {
        public int? UngVienId { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string CMND { get; set; }
        public int QuocGiaId { get; set; }
        public int TinhId { get; set; }
        public int HuyenId { get; set; }
        public int XaId { get; set; }
    }
}