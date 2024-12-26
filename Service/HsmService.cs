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
            var hsmDataList = _context.HsmData
                .FromSqlRaw(@"
                SELECT H.SerialHsm, R.Reg, S.Sgc, S.Sgn, R.Bdt, R.Krn, R.Act, R.Clm, R.Clu, R.Dkg
                FROM Hsm H
                INNER JOIN HsmReg R ON H.IdHsm = R.idHsm
                INNER JOIN Sgc S ON S.idSgc = R.idSgc
                ORDER BY H.SerialHsm")
                .ToList();

            return hsmDataList;
        }
    }
}

