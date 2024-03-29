﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
  public class WriterManager : IWriterService
  {
    IWriterDal _writerDal;
    public WriterManager(IWriterDal writerDal)
    {
      _writerDal = writerDal;
    }
    public List<Writer> GetList()
    {
      return _writerDal.GetListAll();
    }
    public List<Writer> GetWriterById(int id)
    {
      return _writerDal.GetListAll(x=> x.WriterId == id);
    }
    public void TAdd(Writer t)
    {
      _writerDal.Insert(t);
    }
    public void TDelete(Writer t)
    {
      _writerDal.Delete(t);
    }
    public Writer TGetById(int id)
    {
     return _writerDal.GetById(id);
    }
    public void TUpdate(Writer t)
    {
      _writerDal.Update(t);
    }
  }
}
