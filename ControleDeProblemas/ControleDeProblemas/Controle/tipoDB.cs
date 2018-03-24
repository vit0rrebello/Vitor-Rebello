using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class tipoDB
    {
        private DB db;

        public bool insert (Tipo tipo)
        {
            try
            {
                string sql = "INSERT INTO tb_tipo VALUES('" + tipo.Descricao + "')";

                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
  
            
        }
    }
}
