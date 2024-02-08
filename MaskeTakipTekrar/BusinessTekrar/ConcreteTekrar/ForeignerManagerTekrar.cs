using BusinessTekrar.AbstractTekrar;
using EntitiesTekrar.ConcreteTekrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTekrar.ConcreteTekrar
{ 
    //Sonar Qube'u inceleyin.Birçok kurumda kullanılıyor.Bu araca bakarak yazılımın kalitesini ölçüyorsunuz.Mesela if'leri hiç sevmez.If varsa der ki bu yazılım kaliteden uzaklaşıyor. 
    public class ForeignerManagerTekrar : IApplicantServiceTekrar
    {
        public void ApplyForMask(PersonTekrar personTekrar)
        {
            throw new NotImplementedException();
        }

        public bool CheckPersonTekrar(PersonTekrar personTekrar)
        {
            throw new NotImplementedException();
        }

        public List<PersonTekrar> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
