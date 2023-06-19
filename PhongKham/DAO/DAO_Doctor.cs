using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;

namespace PhongKham.DAO
{
    public class DAO_Doctor
    {
        hospitalDbContext db;
        public DAO_Doctor()
        {
            db = new hospitalDbContext();
        }
        public dynamic LayDLDoctor()
        {
            var ds = db.Doctors.Select(s =>
            new {
                s.userName,
                s.password,
                s.position
            }).ToList();
            return ds;
        }
        public Doctor KiemTraYTa(string username, string pass)
        {
            return db.Doctors.Where(o => o.userName == username && o.position == "Y tá" && o.password == pass).FirstOrDefault();
        }
        public Doctor KiemTraBacSi(string username, string pass)
        {
            return db.Doctors.Where(o => o.userName == username && o.position == "Bác sĩ" && o.password == pass).FirstOrDefault();
        }
        public void SuaMatKhau(string username, string pass)
        {
            Doctor dt = db.Doctors.Where(o => o.userName == username).FirstOrDefault();
            dt.password = pass;
            db.SaveChanges();
        }
        public Doctor KiemTraAdmin(string username, string pass)
        {
            return db.Doctors.Where(o => o.userName == username && o.position == "Admin" && o.password == pass).FirstOrDefault();
        }
        public int LayIdDoctor(string username)
        {
            List<Doctor> doctors = db.Doctors.ToList();
            Doctor d = doctors.Find(o => o.userName == username);
            return d.Id;
        }
        public void themNV(Doctor d)
        {
            db.Doctors.Add(d);
            db.SaveChanges();
        }
        public void xoaNV(Doctor d)
        {
            Doctor dt = db.Doctors.Find(d.Id);
            db.Doctors.Remove(dt);
            db.SaveChanges();
        }
        public void suaNV(Doctor d)
        {
            Doctor dt = db.Doctors.Find(d.Id);
            dt.Name = d.Name;
            dt.position = d.position;
            dt.userName = d.userName;
            dt.password = d.password;
            dt.specialize = d.specialize;
            dt.Birthday = d.Birthday;
            db.SaveChanges();
        }

        public bool KiemTra(Doctor d)
        {
            Doctor dt = db.Doctors.Find(d.Id);
            if (d != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic layDSNV()
        {
            var ds = db.Doctors.Select(t => new
            {
                t.Id,
                t.Name,
                t.position,
                t.specialize,
                t.Birthday,
                t.userName,
                t.password
            }).ToList();
            return ds;
        }
    }
}
