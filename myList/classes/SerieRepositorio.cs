using System;
using System.Collections.Generic;
using myList.interfaces;
using myList.classes;

namespace myList
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(Serie objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public int nextId()
        {
            return listaSeries.Count;
        }

        public Serie retornaPorId(int id)
        {
            return listaSeries[id];
        }

        public void update(int id, Serie objeto)
        {
            listaSeries[id].delete();
        }
    }
}