using System;
using System.Collections.Generic;
using System.Text;

namespace GamingSystem.Adapters
{
    public class MernisServiceAdapter : IUsersCheckService
    {
        public bool CheckIfRealPerson(Users user)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(user.NationalityId, user.FirstName, user.LastName, user.DateOfBirth.Year);
        }

        bool IUsersCheckService.CheckIfRealPersonAsync(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
