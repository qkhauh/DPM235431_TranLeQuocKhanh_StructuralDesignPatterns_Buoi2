namespace DPM235431_TranLeQuocKhanh_Decorator_Read_NhanVien_DP.Components
{
    /// <summary>
    /// Component: Giao diện cơ sở cho Hóa Đơn.
    /// Định nghĩa các thao tác tính tiền và lấy thông tin hóa đơn.
    /// </summary>
    public interface IInvoice
    {
        double CalculateTotal();
        string GetDescription();
    }
}
