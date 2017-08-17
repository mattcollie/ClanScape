using ClanScape.RS.Api.Common.Interfaces.Repositories;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClanScape.RS.Api.Common.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(HttpClient client)
        {
            Client = client;
            Client.BaseAddress = new Uri("http://services.runescape.com");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected HttpClient Client { get; private set; }
    }
}
