using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eOrdinacija.Model;
using System.Windows.Forms;
using System.Net.Http;

namespace eOrdinacija.WinUI
{
    public class APIService
    {
        private readonly string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public static string Username { get; set; }
        public static string Password { get; set; }
        
        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificirani");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetByName<T>(object name)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/name={name}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetByKlijent<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/getByKlijent/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetByUsluga<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/getByUsluga/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetByDates<T>(object dateFrom, object dateTo)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/getByDates/{dateFrom}/{dateTo}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }


        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(int id,object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public HttpResponseMessage Remove(int id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = url.WithBasicAuth(Username, Password).DeleteAsync().Result;
            return result;
        }
    }
}
