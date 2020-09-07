using Kztek.Data.Infrastructure;
using Kztek.Model.CustomModel;
using Kztek.Model.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kztek.Data.Repository.StudentRepository;

namespace Kztek.Service.Admin
{


    public interface IStudentService
    {
        IPagedList<Student> GetAllPagingByFirst(string key, int page, int pageSize);
        MessageReport Create(Student student);
        Student GetById(string id);
       
        MessageReport Update(Student student);
       
       
        MessageReport DeleteById(string id);
    }
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _StudentRepository;
        private readonly IUnitOfWork _UnitOfWork;

        public StudentService (IStudentRepository _StudentRepository , IUnitOfWork _UnitOfWork)
        {
            this._StudentRepository = _StudentRepository;
            this._UnitOfWork = _UnitOfWork;
        }

        public MessageReport Create(Student student)
        {
            var result = new MessageReport(false, " Có lỗi xảy ra");

            try
            {
                _StudentRepository.Add(student);
                Save();
                result = new MessageReport(true, " Tạo thành công");
            }
            catch (Exception ex)
            {
                result = new MessageReport(false, ex.InnerException != null ? ex.InnerException.ToString() : ex.Message);
            }
                return result;
        }

        private void Save()
        {
            _UnitOfWork.Commit();
        }

        public IPagedList<Student> GetAllPagingByFirst(string key, int page, int pageSize)
         {
            var query = from n in _StudentRepository.Table
                        where n.IsDelete == false
                        select n;
            if (!string.IsNullOrWhiteSpace(key))
            {
                query = query.Where(n => n.Fullname.Contains(key) || n.Email.Contains(key));
            }
            var list = new PagedList<Student>(query.OrderBy(n => n.Fullname), page, pageSize);
            return list;
        }

        public Student GetById(string id)
        {
            var query = _StudentRepository.GetById(id);
            return query;
        }

       

        public MessageReport Update(Student student)
        {
          var report = new MessageReport(false, "Có lỗi xảy ra");


            try
            {
                _StudentRepository.Update(student);
                Save();
                report = new MessageReport(true , " Cập nhật thành công");
            }
            catch (Exception ex)
            {
                report = new MessageReport(false, ex.InnerException != null ? ex.InnerException.ToString() : ex.Message);
            }
                return report;
        }

        public Student GetByFullName_Id(string fullname, string id)
        {
            var query = from n in _StudentRepository.Table
                        where n.IsDelete == false && n.Fullname.Equals(fullname) && n.Id != id
                        select n;
            return query.FirstOrDefault();
        }

      

        public MessageReport DeleteById(string id)
        {
            var report = new MessageReport(false, "Co lỗi xảy ra");
            try
            {

                var student = _StudentRepository.GetById(id);
                if (student != null)
                {
                    if (!student.Active)
                    {
                        student.IsDelete = true;
                        _StudentRepository.Delete(student);
                        Save();
                        report = new MessageReport(true, "Xóa thành công");

                    }
                    else
                    {
                        report = new MessageReport(false, "Thông tin đang sử dụng. Không thể xóa.");
                    }
                }
                else
                {
                    report = new MessageReport(false, "Thông tin không tồn tại");
                }
            }
            catch (Exception ex )
            {

                report = new MessageReport(false, ex.InnerException != null ? ex.InnerException.ToString() : ex.Message);
            }
            return report;
        }
    }
}
