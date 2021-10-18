using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace App_world_Covid_FPSM_RAAM
{
     public class ViewM
    {
        public static string casosActivos ;
       static HttpClient cliente  = new HttpClient();
        public static async void NetworkingManager()
        {
            string response = await cliente.GetStringAsync(Constant.apiURL);
            List<Model> covid = JsonConvert.DeserializeObject<List<Model>>(response);

            foreach ( var datos in covid)
            {
                casosActivos = datos.ActiveCasesText;
                Console.WriteLine(casosActivos);
            }
        }

    }
}
