using BusinessTekrar.AbstractTekrar;
using EntitiesTekrar.ConcreteTekrar;
using MernisServiceReferenceTekrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTekrar.ConcreteTekrar
{
    // Bir class'ı oluşturduğumuz zaman onun Interface'ini oluşturmuş olduğumuzdan emin olmalıyız yani önce interface ile başlanır olaya.
    public class PersonManagerTekrar :IApplicantServiceTekrar
    {
        //encapsulation
        public void ApplyForMask(PersonTekrar personTekrar)
        {

        }

        public List<PersonTekrar>  GetList()
        {
            return null;

        }

          public bool CheckPersonTekrar(PersonTekrar personTekrar)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(personTekrar.NationalIdentity,personTekrar.FirstName,personTekrar.LastName,personTekrar.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
