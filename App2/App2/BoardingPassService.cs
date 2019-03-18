using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
  public static class BoardingPassService
  {
    public static async Task<FlightInfo> GetBoadrdingPass(string id)
    {
      id = "bp-12345";
      ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
      var client = new HttpClient();
      client.MaxResponseContentBufferSize = 256000;
      var uri = new Uri("http://localhost:60892/api/boardingPass/" + id);
      var response = client.GetAsync(uri).Result;
      if (response.IsSuccessStatusCode)
      {
        var content = await response.Content.ReadAsStringAsync();
        var deserializedObject = JsonConvert.DeserializeObject<FlightInfo>(content);
        return deserializedObject;
      }
      return null;
    }
  }
}
