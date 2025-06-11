using DiaNhacManagerWeb.Models;
using ExamWeb_LeTheNguyen.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_LeTheNguyen.Controllers

{
    public class DiaNhacController : Controller
    {
        private AppDbContext _db;
        public DiaNhacController(AppDbContext db)
        {
            _db = db;
        }
        //Action: Trả về giao diện hiển thị ds dianhac
        public IActionResult Index()
        {
            var DiaNhacList = _db.DiaNhacs.ToList();
            return View(DiaNhacList);
        }
        //Action: Trả về giao diện thêm Dia nhac
        public IActionResult Add()
        {
            return View();
        }
        //Action: Xử lý thêm DiaNhac
        [HttpPost]
        public IActionResult Add(DiaNhac DN)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(DN);
                _db.SaveChanges();
                TempData["success"] = "Inserted success";
                return RedirectToAction("Index");
            }
            return View(DN);
        }
        //Action: Trả về giao diện cập nhật Dia Nhac
        public IActionResult Update(int id)
        {
            var student = _db.DiaNhacs.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        //Action: Xử lý cập nhật Dia Nhac
        [HttpPost]
        public IActionResult Update(DiaNhac DN)
        {
            if (ModelState.IsValid)
            {
                var existDiaNhac = _db.DiaNhacs.Find(DN.Id);
                if (existDiaNhac == null)
                {
                    return NotFound();
                }
                //Cập nhật lên CSDL
                existDiaNhac.TuaCD = DN.TuaCD;
                existDiaNhac.TheLoai = DN.TheLoai; 
                existDiaNhac.GiaBan = DN.GiaBan;
                existDiaNhac.SoLuong = DN.SoLuong;
                
                _db.SaveChanges();
                TempData["success"] = "Updated success";
                return RedirectToAction("Index");
            }
            return View(DN);
        }
        //Action: Trả về giao diện xác nhận xóa
        public IActionResult Delete(int id)
        {
            var dianhac = _db.DiaNhacs.Find(id);
            if (dianhac == null)
            {
                return NotFound();
            }    
            return View(dianhac);
        }
        //Action: Xử lý xóa Dia Nhac
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var existDiaNhac = _db.DiaNhacs.Find(id);
            if(existDiaNhac == null)
            {
                return NotFound();
            }    
            //Delete stu trong CSDL
            _db.DiaNhacs.Remove(existDiaNhac);
            _db.SaveChanges();
            TempData["success"] = "Deleted success";
            return RedirectToAction("Index");
        }
    }
}
