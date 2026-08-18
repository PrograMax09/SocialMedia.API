using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;

namespace BusinessLogic.Contenido
{
    public interface IContenidoBusiness
    {
        public IEnumerable<ReadContentDTO> Get();
        public IEnumerable<ReadContentDTO> GetOrdered(string modo = "asc");
        public ReadContentDTO GetByAccount(string cuenta);
        public ReadContentDTO GetByVisibility(string tv);
        public ReadContentDTO Get1ByAccountAndDate(string cuenta, int dias);
        public IEnumerable<ReadContentDTO> GetAllByAccountAndDate(string cuenta, int dias);
        public IEnumerable<ReadContentDTO> GetAllByDate(int dias);
    }
}
