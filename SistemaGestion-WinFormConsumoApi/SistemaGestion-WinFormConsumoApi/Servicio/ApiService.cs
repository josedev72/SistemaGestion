using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion_WinFormConsumoApi.Servicio
{
    public class ApiService
    {
        private static readonly HttpClient _cliente = new HttpClient();

        static ApiService()
        {
            _cliente.BaseAddress = new Uri("https://localhost:7214/");
            _cliente.DefaultRequestHeaders.Accept.Clear();
            _cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetDataAsync(string endpoint)
        {
            HttpResponseMessage response = await _cliente.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Error al obtener datos: {response.ReasonPhrase}");
            }
        }

        public async Task<string> DeleteDataAsync(string endpoint)
        {
            HttpResponseMessage response = await _cliente.DeleteAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Error al eliminar datos: {response.ReasonPhrase}");
            }
        }

        public async Task<bool> PostDataAsync<T>(string endpoint, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _cliente.PostAsync(endpoint, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProductoByIdAsync(int id, string descripcion, decimal costo, decimal stock, decimal precioVenta, int idUsuario)
        {   //Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario
            var endpoint = $"api/producto/{id}/{descripcion}/{costo}/{stock}/{precioVenta}/{idUsuario}";
            var response = await _cliente.PutAsync(endpoint, null);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> PutDataAsync<T>(string endpoint, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _cliente.PutAsync(endpoint, content);
            return response.IsSuccessStatusCode;
        }

    }
}
