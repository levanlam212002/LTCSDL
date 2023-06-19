using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.DAO;
using hospitals.Models;
using PhongKham.DAO;
using PhongKham.View;

namespace PhongKham.Bus
{
    public class Bus_Medicine
    {
        DAO_Medicine med;
        public Bus_Medicine()
        {
            med = new DAO_Medicine();
        }
        public void HienThiDSPatientLenCBB(ComboBox cbb)
        {
            cbb.DataSource = med.LayDLMedicine();
            cbb.DisplayMember = "Name";
            cbb.ValueMember = "Id";
        }
        public Medicine LayMedicine(int id)
        {
            return med.LayDLMedicineById(id);
        }
        public void HienDs(DataGridView dg)
        {
            dg.DataSource = med.layDS();
        }
        public bool SuaThuoc(Medicine t)
        {
            if (med.kiemTra(t))
            {
                try
                {
                    med.Sua(t);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
        public bool XoaThuoc(Medicine t)
        {
            if (med.kiemTra(t))
            {
                try
                {
                    med.Xoa(t);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool themThuoc(Medicine t)
        {
            try
            {
                med.themThuoc(t);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
