﻿using RealEstate.Dao.Interface;
using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RealEstate.Repository.Class
{
    public class DireccionEstadosRepository : IDireccionEstadosRepository
    {
        private readonly IDireccionEstadosDao _direccionEstadosDao;
        public DireccionEstadosRepository(IDireccionEstadosDao direccionEstadosDao)
        {
            _direccionEstadosDao = direccionEstadosDao;
        }

        public bool Delete(int id)
        {
            var rowsCount = _direccionEstadosDao.Delete(id);
            return rowsCount > 0;
        }
        public IEnumerable<SearchItemModel> SearchEstate(string word, int top)
        {
            var estados = _direccionEstadosDao.GetListByFunc(e => e.Estado.ToLower().Contains(word.ToLower()), top);
            var searchitemmodel = estados.Select(e => new SearchItemModel { Id = e.IdEstado, Texto = e.Estado }).ToList();
            return searchitemmodel;
        }
        public IEnumerable<DireccionEstados> GetAll()
        {
            return _direccionEstadosDao.GetAll();
        }

        public DireccionEstados GetById(int id)
        {
            return _direccionEstadosDao.GetById(id);
        }

        public bool Insert(DireccionEstados entity)
        {
            var rowsCount = _direccionEstadosDao.Insert(entity);
            return rowsCount > 0;
        }

        public bool Update(DireccionEstados entity)
        {
            var rowsCount = _direccionEstadosDao.Update(entity);
            return rowsCount > 0;
        }
    }
}
