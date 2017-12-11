using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEOS_WFA.model.entity;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VEOS_WFA.model.collection
{
    class Tereni_Collection
    {
        private static Tereni_Collection instance;

        public static Tereni_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tereni_Collection();
                }
                return instance;
            }
        }

        private Dictionary<Guid, Teren> teren_collection;

        internal Dictionary<Guid, Teren> Teren_collection
        {
            get { return teren_collection; }
            set { teren_collection = value; }
        }
        private readonly string datoteka;

        public Tereni_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tereni.dat");
            load();
        }

        public void addTeren(Teren novi)
        {
            if (!teren_collection.ContainsKey(novi.Sifra))
            {
                teren_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public void removeTeren(Teren stari)
        {
            teren_collection.Remove(stari.Sifra);
            save();
        }

        public void modifyTeren(Teren novi)
        {
            if (teren_collection.ContainsKey(novi.Sifra))
            {
                teren_collection.Remove(novi.Sifra);
                teren_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        /*public Hala getHala(string key)
        {
            Hala temp;
            hale_collection.TryGetValue(key, out temp);
            return temp;
        }*/

        public int size()
        {
            return teren_collection.Count;
        }

        public void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, teren_collection);

                foreach (KeyValuePair<Guid, Teren> teren in teren_collection)
                {
                    System.Diagnostics.Debug.WriteLine(teren.Value.Ime);
                }
            }
            catch
            {
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(datoteka))
            {
                try
                {
                    stream = File.Open(datoteka, FileMode.Open);
                    teren_collection = (Dictionary<Guid, Teren>)formatter.Deserialize(stream);
                    foreach (KeyValuePair<Guid, Teren> teren in teren_collection)
                    {
                        System.Diagnostics.Debug.WriteLine(teren.Value.Ime);
                    }
                }
                catch
                {
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }
            }
            else
                teren_collection = new Dictionary<Guid,Teren>();
        }
    }
}
