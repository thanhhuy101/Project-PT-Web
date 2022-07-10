using Customer.Models;
using System.Collections.Generic;

namespace Customer.Repository
{
    public interface IDanhGiaRepository
    {
        void createDanhGia(DanhGium danhgia);
        List<DanhGium> getAllDanhGia();
        List<DanhGium> getDanhGiaByMasp(int MaSp);

        List<DanhGium> GetDanhGiaWithTenKh();
        DanhGium GetDanhGia(int id);
    }
}
