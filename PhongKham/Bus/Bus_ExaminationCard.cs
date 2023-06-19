using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.DAO;
using hospitals.Models;
using System.Windows.Forms;
using PhongKham.DAO;

namespace PhongKham.Bus
{
    public class Bus_ExaminationCard
    {
        DAO_ExaminationCard exa;
        public Bus_ExaminationCard()
        {
            exa = new DAO_ExaminationCard();
        }
        public void ThemExaminationCard(ExaminationCard p)
        {
            try
            {
                exa.ThemPhieu(p);
                MessageBox.Show("Lưu Thành Công");
            }
            catch (Exception)
            {

                MessageBox.Show("Lưu thất bại");
            }
        }
        public List<ExaminationCard> layCard(int id)
        {
            return exa.LayCard(id);
        }
        public ExaminationCard layCardById(int id)
        {
            return exa.LayCardById(id);
        }
        public int KiemPhieuVuaTao()
        {
            return exa.KiemPhieuVuaTao();
        }
    }
}
