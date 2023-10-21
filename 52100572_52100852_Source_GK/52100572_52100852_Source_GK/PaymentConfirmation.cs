using BUS;
using DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100572_52100852_Source_GK
{
    public partial class PaymentConfirmation : MaterialForm
    {
        private DonDatXeDTO donDatXe;
        private Double thanhTien;
        public PaymentConfirmation(DonDatXeDTO donDatXe)
        {
            InitializeComponent();

            if (donDatXe != null)
            {
                this.donDatXe = donDatXe;

                txt_ID_KH.Text = donDatXe.KhachHangID.ToString();
                txt_ID_DonDatXe.Text = donDatXe.DonDatXeID.ToString();
                txt_ThoiGianThue.Text = donDatXe.ThoiGianThue.ToString("dd/MM/yyyy HH:mm:ss");
                txt_GiaThue.Text = donDatXe.GiaThue.ToString("N0") + " VND/giờ";
                txt_ID.Text = donDatXe.XeOtoID.ToString();
                dtpk_ThoiGianTra.MinDate = donDatXe.ThoiGianThue;

                if (donDatXe.TinhTrangThanhToan)
                {
                    dtpk_ThoiGianTra.Value = (DateTime)donDatXe.ThoiGianTra;
                    dtpk_ThoiGianTra.Enabled = false;
                    lbl_Total.Text = "Thành Tiền: " + this.donDatXe.Total.ToString("N0") + " VND";
                    btn_Confirm.Enabled = false;
                }
            }

        }

        private void dtpk_ThoiGianTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayTra = dtpk_ThoiGianTra.Value;
            this.donDatXe.ThoiGianTra = ngayTra;
            TimeSpan thoiGianThueSpan = ngayTra - donDatXe.ThoiGianThue;
            double soGioDaThue = thoiGianThueSpan.TotalHours;
            this.donDatXe.Total = soGioDaThue * donDatXe.GiaThue;
            lbl_Total.Text = "Thành Tiền: " + this.donDatXe.Total.ToString("N0") + " VND";
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (this.donDatXe.Total > 0)
            {
                donDatXe.TinhTrangThanhToan = true;
                if (DonDatXeBUS.Instance.PaymentComfirm(donDatXe))
                {
                    MessageBox.Show("Thanh toán thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày trả!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
