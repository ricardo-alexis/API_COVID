using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using System.Globalization;



namespace App_world_Covid_FPSM_RAAM
{
    public partial class Form1 : Form
    {
        public static string casosActivos;
        HttpClient cliente = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public async void Form1_Load(object sender, EventArgs e)
        {

            string ListActiveCases = ViewM.casosActivos;
            string[] row = { ListActiveCases };
            var ListViewItem = new ListViewItem(row);
            listView1.Items.Add(ListViewItem);
            ViewM.NetworkingManager();
        }
        void LoadData()
        {
            ViewM.NetworkingManager();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

    }
}
