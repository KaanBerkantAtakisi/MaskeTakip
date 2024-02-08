using BusinessTekrar.AbstractTekrar;
using EntitiesTekrar.ConcreteTekrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTekrar.ConcreteTekrar
{
    public class PharmacyManagerTekrar : ISupplierServiceTekrar
    {
        private IApplicantServiceTekrar _applicantServiceTekrar;

        public PharmacyManagerTekrar(IApplicantServiceTekrar applicantServiceTekrar) //Constructor new yapıldığında çalışır.
        {
            _applicantServiceTekrar = applicantServiceTekrar;
        }
        public void GiveMask(PersonTekrar personTekrar)
        {

            if (_applicantServiceTekrar.CheckPersonTekrar(personTekrar))

            {
                Console.WriteLine(personTekrar.FirstName + " için maske verildi ");
            }

        }
    }
}
