using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Proyecto;

public class Register : IEnumerable
{
    /* Creo dos GenericList: uno para alojar a los Employer y otro para alojar a los Worker
        La idea es poder alojar ambos en la misma clase Register*/
    private GenericList<Employer> employers = new GenericList<Employer>(); //ESTO ES UN ATRIBUTO PARA LA UML
    private GenericList<Worker> workers = new GenericList<Worker>(); //ATRIBUTO

    public void Add(Employer employer)              //Agrego los objetos Employer a la GenericList de Employers
        {
            this.employers.Add(employer);
        }
    public void Add(Worker worker)                  //Agrego los objetos Worker a la GenericList de Workers
        {
            this.workers.Add(worker);
        }
    public void Remove(Employer employer)           //Borro los objetos de sus listas
        {
            this.employers.Remove(employer);
        }
    public void Remove(Worker worker)
        {
            this.workers.Remove(worker);
        }

    [ExcludeFromCodeCoverage]
    public IEnumerator GetEnumerator()
        {
            ArrayList all = new ArrayList();

            foreach (Employer employer in this.employers)
            {
                all.Add(employer);
            }

            foreach (Worker worker in this.workers)
            {
                all.Add(worker);
            }

            return all.GetEnumerator();
        }
}