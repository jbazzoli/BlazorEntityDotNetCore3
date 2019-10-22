using Frente_de_Trabalho_Sem_a_Vale.Data.Extention;
using Frente_de_Trabalho_Sem_a_Vale.Pages;
using ModelShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Frente_de_Trabalho_Sem_a_Vale.Data
{
    public class PersonService
    {
        public async Task<Person[]> GetPersonsAsync()
        {
            HttpClient httpClient = new HttpClient();
            Person[] persons = default(Person[]);
            HttpResponseMessage httpResponse = await httpClient.GetAsync("https://localhost:44330/Person");
            persons = await httpResponse.Content.ReadAsJsonAsync<Person[]>();

            return persons;
        }
    }
}
