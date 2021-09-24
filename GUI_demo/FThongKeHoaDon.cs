using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.BUS;
using GUI_demo.Report;

namespace GUI_demo
{
    public partial class FThongKeHoaDon : Form
    {
        BUS_Kho bKho;
        public FThongKeHoaDon()
        {
            InitializeComponent();
            bKho = new BUS_Kho();
        }

        private void btTim_Ngay_Click(object sender, EventArgs e)
        {
            ReportThongKeHangHoa rp = new ReportThongKeHangHoa();
            CRBaoCaoHangHoa cr = new CRBaoCaoHangHoa();
            cr.SetDataSource(bKho.baoCaoKho());
            rp.crystalReportViewer1.ReportSource = cr ;
            rp.Show();
        }
    }
}
