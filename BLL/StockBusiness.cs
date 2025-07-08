using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class StockBusiness
    {
        private StockDAO dao = new StockDAO();

        public void Agregar(Stock stock)
        {
            dao.Agregar(stock);
        }

        public List<Stock> Listar()
        {
            return dao.Listar();
        }
    }
}