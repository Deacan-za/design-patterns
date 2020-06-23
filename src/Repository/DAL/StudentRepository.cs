using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Repository.Models;

namespace Repository.DAL
{
  public class StudentRepository : IStudentRepository
  {
    private RepositoryContext _context;

    public StudentRepository(RepositoryContext context)
    {
      _context = context;
    }

    public void DeleteStudent(int studentId)
    {
      var entity = _context.Students.Find(studentId);
      _context.Students.Remove(entity);
    }

    public Task<Student> GetStudentById(int? studentId)
    {
      return _context.Students.FindAsync(studentId);
    }

    public Task<List<Student>> GetStudents()
    {
      return _context.Students.ToListAsync();
    }

    public void InsertStudent(Student student)
    {
      _context.Students.Add(student);
    }

    public Task<int> Save()
    {
      return _context.SaveChangesAsync();
    }

    public void UpdateStudent(Student student)
    {
      _context.Entry(student).State = EntityState.Modified;
    }

    // Dispose
    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
      if(!_disposed)
      {
        if(disposing)
        {
          _context.Dispose();
        }
      }
      _disposed = true;
    }

    public void Dispose()
    {
      Dispose(true);
      // Prevent the GC from calling Object.Fianalize on an 
      // object that does not need it.
      GC.SuppressFinalize(this);
    }
  }
}