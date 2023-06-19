using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.DAO;
using hospitals.Models;
using PhongKham.DAO;

namespace PhongKham.Bus
{
    public class Bus_Doctor
    {
        DAO_Doctor Doctor;
        public Bus_Doctor()
        {
            Doctor = new DAO_Doctor();
        }
        public Boolean KiemTraDangNhap(string username, string pass,int quyen)    
        {
            if(quyen == 0)
            {
                Doctor d = Doctor.KiemTraYTa(username,pass);
                if (d == null)
                    return false;
                else
                    return true;
            }else
            if (quyen == 1)
            {
                Doctor d = Doctor.KiemTraBacSi(username, pass);
                if (d == null)
                    return false;
                else
                    return true;
            }
            else
            {
                Doctor d = Doctor.KiemTraAdmin(username, pass);
                if (d == null)
                    return false;
                else
                    return true;
            }
        }
        public void SuaMatKhau(string username, string pass)
        {
            Doctor.SuaMatKhau(username,pass);
        }
        public int LayIDDoctor(string username)
        {
            return Doctor.LayIdDoctor(username);
        }
        public void hienDS(DataGridView dg)
        {
            dg.DataSource = Doctor.layDSNV();
        }
        public bool themNV(Doctor d)
        {
            try
            {
                Doctor.themNV(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaNV(Doctor d)
        {
            if (Doctor.KiemTra(d))
            {
                try
                {
                    Doctor.xoaNV(d);
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
        public bool suaNV(Doctor d)
        {
            if (Doctor.KiemTra(d))
            {
                try
                {
                    Doctor.suaNV(d);
                    return true;
                }
                catch (DbUpdateConcurrencyException ex)
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
    }
}
