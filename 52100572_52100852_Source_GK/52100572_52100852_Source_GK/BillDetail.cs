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
    public partial class BillDetail : MaterialForm
    {
        private XeOtoDTO xeOtoDTO;
        private List<string> tinhNangIDList;
        public BillDetail(XeOtoDTO xeOtoDTO)
        {
            InitializeComponent();
            this.xeOtoDTO = xeOtoDTO;
            tinhNangIDList = new List<string>();
            if (xeOtoDTO != null )
            {
                txt_ID.Text = xeOtoDTO.XeOtoID.ToString();
                txt_GiaThue.Text = xeOtoDTO.Gia.ToString();
                txt_Model.Text = xeOtoDTO.Model.ToString();
                tinhNangIDList = XeOtoBUS.Instance.GetXeOto_TinhNangListByXeOtoID(xeOtoDTO.XeOtoID);
            }
            
        }

        public void toggle(bool isEditing)
        {
            if(isEditing)
            {

            }
            else
            {
                txt_ID.Enabled = false;
                txt_Model.Enabled = false;
                txt_GiaThue.Enabled = false;
                btn_Cancel.Visible = false;
                btn_Save.Visible = false;
            }
        }

        private void lbl_GiaThue_Click(object sender, EventArgs e)
        {

        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            List<TinhNangDTO> tinhNangDTOs = XeOtoBUS.Instance.GetTinhNangList();
            foreach (TinhNangDTO tinhNang in tinhNangDTOs)
            {
                MaterialCheckbox checkBox = new MaterialCheckbox();
                checkBox.Text = tinhNang.TenTinhNang;
                checkBox.Tag =  tinhNang.TinhNangID.ToString();
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Width = 180;
                if (tinhNangIDList.Contains(tinhNang.TinhNangID.ToString()))
                {
                    checkBox.Checked = true;
                }
                fpnl_TinhNang.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                string tinhNangID = (string)checkBox.Tag;
                tinhNangIDList.Add(tinhNangID);
            }
            else
            {
                tinhNangIDList.Remove(checkBox.Tag.ToString());
            }
            lbl_Total.Text = string.Join(", ", tinhNangIDList);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
