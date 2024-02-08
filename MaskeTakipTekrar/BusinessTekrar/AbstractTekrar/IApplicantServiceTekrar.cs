
using EntitiesTekrar.ConcreteTekrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTekrar.AbstractTekrar
{
    public interface IApplicantServiceTekrar
    {
        void ApplyForMask(PersonTekrar personTekrar);
        

         List<PersonTekrar> GetList();
        bool CheckPersonTekrar(PersonTekrar personTekrar);
        
    }
}
