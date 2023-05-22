using WaterPolo.Models;
using WaterPolo.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace WaterPolo.ViewModels
{
    public class ModelEquipment
    {
        public ObservableCollection<TopTenItem> items { get; set; }

        public ModelEquipment()
        {
            try
            {
                items = new ObservableCollection<TopTenItem>();

                string fn = "Equipment.json";

                var assembly = typeof(TopTen).GetTypeInfo().Assembly;

                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fn}");

                var reader = new StreamReader(stream);

                var js = reader.ReadToEnd();

                stream.Close();

                items = JsonConvert.DeserializeObject<ObservableCollection<TopTenItem>>(js);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
    }
}
