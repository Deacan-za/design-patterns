using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.DAL
{
  public class UnitOfWork : IDisposable
  {
    private RepositoryContext _context = new RepositoryContext();
    private IGenericRepository<Faculty> _facultyRepository;
    private IGenericRepository<Student> _studentRepository;

    public IGenericRepository<Faculty> FacultyRepository
    {
      get
      {
        if(_facultyRepository == null)
        {
          _facultyRepository = new GenericRepository<Faculty>(_context);
        }
        return _facultyRepository;
      }
    }

    public IGenericRepository<Student> StudentRepository
    {
      get
      {
        if (_studentRepository == null)
        {
          _studentRepository = new GenericRepository<Student>(_context);
        }
        return _studentRepository;
      }
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    // Dispose
    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
      if (!_disposed)
      {
        if (disposing)
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