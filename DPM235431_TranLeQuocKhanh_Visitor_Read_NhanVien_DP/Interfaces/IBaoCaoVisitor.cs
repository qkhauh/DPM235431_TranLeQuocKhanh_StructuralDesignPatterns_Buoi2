using DPM235431_TranLeQuocKhanh_Visitor_Read_NhanVien_DP.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235431_TranLeQuocKhanh_Visitor_Read_NhanVien_DP.Interfaces
{
    public interface IBaoCaoVisitor
    {
        void VisitPhanBon(PhanBon phanBon);
        void VisitThuocTruSau(ThuocTruSau thuocTruSau);
    }
}
