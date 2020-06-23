using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
  internal interface IStudentRepository: IDisposable
  {
    Task<List<Student>> GetStudents();
    Task<Student> GetStudentById(int? studentId);
    void InsertStudent(Student student);
    void DeleteStudent(int studentId);
    void UpdateStudent(Student student);
    Task<int> Save();
  }
}
