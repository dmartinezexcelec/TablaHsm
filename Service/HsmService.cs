using HSM2.Dbcontext;
using HSM2.Models;
using Microsoft.EntityFrameworkCore;

namespace HSM2.Service
{
    public class HsmService
    {
        private readonly ApplicationDbContext _context;

        public HsmService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<HsmData> GetHsmData()
        {
            // Ejecuto la consulta SQL sin aplicar ninguna operación de eliminación de duplicados
            var hsmdatalist = _context.HsmData
                .FromSqlRaw(@"
              SELECT 
                ROW_NUMBER() OVER (ORDER BY H.SerialHsm) AS id, 
                H.SerialHsm, 
                R.Reg, 
                S.Sgc, 
                S.Sgn, 
                R.Bdt, 
                R.Krn, 
                R.Act, 
                R.Clm, 
                R.Clu, 
                R.Dkg
            FROM 
                Hsm H
            INNER JOIN 
                HsmReg R ON H.IdHsm = R.idHsm 
            INNER JOIN 
                Sgc S ON S.idSgc = R.idSgc
            ORDER BY 
                H.SerialHsm;")
                .ToList();

            // Devuelvo la lista con todos los registros, incluidos los duplicados
            return hsmdatalist;
        }


    }
}


