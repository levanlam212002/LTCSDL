using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;
using System.Windows.Forms;
using PhongKham.DAO;
using PhongKham.View;

namespace PhongKham.Bus
{
    public class Bus_Bill
    {

        DAO_Bill bill;
        public Bus_Bill()
        {
            bill = new DAO_Bill();
        }
        public void HienThiDSPatientLenDGV(DataGridView dgv)
        {
            dgv.DataSource = bill.LayDLBill();
        }
        public void LayBillByIdPaitent(DataGridView dgv, int id)
        {
            dgv.DataSource = bill.LayBill(id);
        }
        public void ThanhToanHD(int id,DateTime d)
        {
            bill.ThanhToan(id,d);
        }
        public void ThemBill(Bill b)
        {
            bill.ThemBill(b);
        }
        public List<Bill> LayBill(int nam,int s)
        {
            if (s == 0)
                return bill.LayBills(nam,1,2,3);
            else if(s == 1)
                return bill.LayBills(nam,4,5,6);
            else if(s == 2)
                return bill.LayBills(nam,7,8,9);
            else 
                return bill.LayBills(nam,10,11,12);
        }
    }
}
