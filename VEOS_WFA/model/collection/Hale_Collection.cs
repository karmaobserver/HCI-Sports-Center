using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using VEOS_WFA.model.entity;

namespace VEOS_WFA.model.collection
{
    class Hale_Collection
    {

        private static Hale_Collection instance;

        public static Hale_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Hale_Collection();
                }
                return instance;
            }
        }

        public Hale_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Hale.dat");
            load();
        }

        private Dictionary<Guid, Hala> hale_collection;

        internal Dictionary<Guid, Hala> Hale_collection
        {
            get { return hale_collection; }
            set { hale_collection = value; }
        }

        private readonly string datoteka;

        public void addHala(Hala novi)
        {
            if (!hale_collection.ContainsKey(novi.Sifra))
            {
                hale_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public void removeHala(Hala stari)
        {
            hale_collection.Remove(stari.Sifra);
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
            return hale_collection.Count;
        }

        public void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, hale_collection);
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
                    hale_collection = (Dictionary<Guid, Hala>)formatter.Deserialize(stream);
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
                hale_collection = new Dictionary<Guid,Hala>();
        }
    }
}
