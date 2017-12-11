using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VEOS_WFA.model.entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace VEOS_WFA.model.collection
{
    class Zauzimanje_Collection
    {
        private static Zauzimanje_Collection instance;

        public static Zauzimanje_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Zauzimanje_Collection();
                }
                return instance;
            }
        }

        private Dictionary<Guid, Zauzimanje> zauzimanje_collection;

        internal Dictionary<Guid, Zauzimanje> Zauzimanje_collection
        {
            get { return zauzimanje_collection; }
            set { zauzimanje_collection = value; }
        }

        private readonly string datoteka;

        public Zauzimanje_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Zauzimanje.dat");
            load();
        }

        public void addZauzimanje(Zauzimanje novi)
        {
            if (!zauzimanje_collection.ContainsKey(novi.Sifra))
            {
                zauzimanje_collection.Add(novi.Sifra, novi);
            }

            save();
        }

        public void removeZauzimanje(Zauzimanje stari)
        {
            zauzimanje_collection.Remove(stari.Sifra);
            save();
        }

        public int size()
        {
            return zauzimanje_collection.Count;
        }

        private void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, zauzimanje_collection);
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

        private void load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(datoteka))
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine("Uloadovano je datoteka");
                    stream = File.Open(datoteka, FileMode.Open);
                    System.Diagnostics.Debug.WriteLine("Uloadovano je datoteka");
                    zauzimanje_collection = (Dictionary<Guid, Zauzimanje>)formatter.Deserialize(stream);
                    System.Diagnostics.Debug.WriteLine("Uloadovano je datoteka");
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
            {
                System.Diagnostics.Debug.WriteLine("lekrealtunk egy ujat");
                zauzimanje_collection = new Dictionary<Guid, Zauzimanje>();
            }
        }
    }
}
