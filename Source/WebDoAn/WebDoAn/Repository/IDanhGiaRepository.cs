using Admin.Models;
using System.Collections.Generic;

namespace Admin.Repository
{
    public interface IDanhGiaRepository
    {
        List<DanhGium> getallDanhGia();
        List<DanhGium> getallDanhGiaByMaSP(int Masp);
        DanhGium getDanhGia(int MaSP);

    }
}
