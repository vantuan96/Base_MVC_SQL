using Kztek.Model.Models;
using Kztek.Service.Admin;
using Kztek.Web.Core.Functions;
using Kztek.Web.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kztek.Web.Controllers
{
    public class StudentController : Controller
    {
        

        private IStudentService _StudentService;

        public StudentController (IStudentService StudentService)
        {
            this._StudentService = StudentService;
            
        }
        // GET: Student
        public ActionResult Index(string key , int page = 1)
            {

            int pageSize = 1;


            // Laays phan trang

            var list = _StudentService.GetAllPagingByFirst (key, page, pageSize);
            //Đổ lên grid

            var gridModel = PageModelCustom<Student>.GetPage(list  , page , pageSize);
            //ViewBag
            ViewBag.keyValue = key;
            return View(gridModel);
        }
        [HttpGet]
        public ActionResult Create()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file ,Student student,  bool SaveAndCountinue = false)
        {

            //File upload
            if (file != null  && file.ContentLength > 0)
            {
                var extension = Path.GetExtension(file.FileName) ?? "";
                var fileName = Path.GetFileName(string.Format("{0}{1}", StringUtil.RemoveSpecialCharactersVn(file.FileName.Replace(extension, "")).GetNormalizeString(), extension));
                student.UserAvatar = string.Format("{0}{1}", ConfigurationManager.AppSettings["uploadfolder"], fileName);
            }


            // Kiêm tra
            if (!ModelState.IsValid)
            {
                return View(student);
            }   
            // Gán giá trị
            student.Id = Common.GenerateId();




            // Thêm mới
            var result = _StudentService.Create(student);
            var selectedGender = student.Gender;
            if (result.isSuccess)
            {


                if (SaveAndCountinue)
                {
                    TempData["Success"] = result.Message;
                    return RedirectToAction("Action");

                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return View(student);
            }
        }
        [HttpGet]
        public ActionResult Update ( string id)
        {
            var result = _StudentService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Update (Student  obj , HttpPostedFileBase file)
                    {
            

            //Kiểm tra
            //var oldObj = _StudentService.GetById(obj.Id);
            //if (oldObj == null)
            //{
            //    ViewBag.Error = "Bản ghi không tồn tại";
            //    return View(obj);
            //}
            //if (!ModelState.IsValid)
            //{
            //    return View(oldObj);
            //}

            //var isExisted = _StudentService.GetByFullName_Id(oldObj.Fullname, oldObj.Id.ToString());
            //if (isExisted != null)
            //{
            //    ModelState.AddModelError("FullName", "Ho và Ten đã có");
            //    return View(oldObj);
            //}
            ////Gấn giá trị

            //oldObj.Fullname = obj.Fullname;
            //oldObj.Active = obj.Active;
            //File upload
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName) ?? "";
                var fileName = Path.GetFileName(string.Format("{0}{1}", StringUtil.RemoveSpecialCharactersVn(file.FileName.Replace(extension, "")).GetNormalizeString(), extension));
                obj.UserAvatar = string.Format("{0}{1}", ConfigurationManager.AppSettings["uploadfolder"], fileName);
            }
            //Thực hiện cập nhật
            var result = _StudentService.Update(obj);
            if (result.isSuccess)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return View(obj);
            }
        }
 
        public JsonResult Delete (string id)
        {
          
            var result = _StudentService.DeleteById(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
    }
