using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eKino.Model;
using eKino.WinUI.Properties;
using eKino.WinUI.Helper;
using System.Net;

namespace eKino.WinUI
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = Settings.Default.APIUrl;

        public static string Username = null;
        public static string Password = null;

        public static User CurrentUser { get; set; }

        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Get<T>(object search = null)
        {
            var query = "";
            if (search != null)
            {
                query = await search.ToQueryString();
            }

            var list = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return list;

        }

        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Post<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                return await HandleFlurlException<T>(ex);
            }

        }

        public async Task<T> Put<T>(object id, object request)
        {

            try
            {
                var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                return await HandleFlurlException<T>(ex);
            }
        }
        private static async Task<T> HandleFlurlException<T>(FlurlHttpException ex)
        {
            if (ex.StatusCode == (int)HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("Access Unauthorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.StatusCode == (int)HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Access Forbidden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var errors = await ex.GetResponseJsonAsync<ProblemDetailsWithErrors>();

                if (errors != null)
                {

                    var stringBuilder = new StringBuilder();
                    foreach (var error in errors.Errors)
                    {
                        stringBuilder.AppendLine(string.Join(", ", error.Value));
                    }

                    MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return default;
        }

    }
}
