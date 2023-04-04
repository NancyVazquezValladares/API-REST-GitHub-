using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace API_REST_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // URL de la API REST de GitHub para buscar repositorios de un usuario específico
                string apiUrl = "https://api.github.com/users/{username}/repos";
                // Solicita al usuario que ingrese el nombre de usuario de GitHub del propietario del repositorio
                string username = txtUsuario.Text.Trim(); // .Trim se utiliza para eliminar todos los espacios en blanco
                                                          // Opcion1:txtUsuario.Text.Trim() Ingresa tu username desde el textbox
                                                          // Opcion2: InputBox("Ingresa el nombre de usuario de GitHub del propietario del repositorio:", "Nombre de usuario")
                 // Token
                string token = "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";

                // Cliente HTTP para enviar la solicitud a la API REST
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Mozilla", "5.0"));
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Agrega el token de acceso personal como un encabezado de autorización en la solicitud HTTP
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                // Envia la solicitud HTTP GET a la API REST de GitHub y obtiene la respuesta
                HttpResponseMessage response = httpClient.GetAsync(apiUrl.Replace("{username}", username)).Result;//HttpResponseMessage response = await httpClient.GetAsync(apiUrl.Replace("{username}", username));

                // Si la respuesta es satisfactoria, obtiene el contenido de la respuesta como una cadena JSON
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult(); //string responseContent = await response.Content.ReadAsStringAsync();
                    // Analiza la cadena JSON para obtener un arreglo de objetos JSON que representan los repositorios
                    JArray repositories = JArray.Parse(responseContent);

                    // Agrega el nombre de cada repositorio a la lista de repositorios en el formulario
                    foreach (JObject repository in repositories)

                        lbRepositorio.Items.Add(repository["name"]);
                }
                else
                {

                }
                    MessageBox.Show("Error al buscar los repositorios: " + response.ReasonPhrase);
            }
            catch(Exception ex) { MessageBox.Show("Error al buscar los repositorios: " + ex.Message); }
                }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lbRepositorio.Items.Clear();
            txtUsuario.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
