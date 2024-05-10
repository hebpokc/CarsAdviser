using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAdviser.Database
{
    internal class YandexHelper
    {
        private const string UserInfoEndpoint = "https://login.yandex.ru/info?format=json";
        public async Task<Users> GetUserInfoAsync(string accessToken)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var response = await httpClient.GetAsync(UserInfoEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var userInfoResponse = JsonConvert.DeserializeObject<UserInfoResponse>(responseContent);
                    var user = new Users
                    {
                        ID = userInfoResponse.Id,
                        First_name = userInfoResponse.First_name,
                        Last_name = userInfoResponse.Last_name,
                        Email = userInfoResponse.Default_Email,
                        Phone_number = userInfoResponse.Default_phone.Number,
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<string> ExchangeCodeForTokenAsync(string code)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var clientId = "a4eafaed8ce24ccfa608401fdb825ed7";
                    var clientSecret = "c5eecf1c60ad4432b98705ec8dd288ba";
                    var tokenEndpoint = "https://oauth.yandex.ru/token";

                    var parameters = new Dictionary<string, string>
                    {
                        { "grant_type", "authorization_code" },
                        { "code", code },
                        { "client_id", clientId },
                        { "client_secret", clientSecret }
                    };

                    var response = await httpClient.PostAsync(tokenEndpoint, new FormUrlEncodedContent(parameters));
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var token = JObject.Parse(responseContent)["access_token"]?.ToString();
                        return token;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
