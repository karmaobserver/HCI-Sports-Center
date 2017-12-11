using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VEOS_WFA.model.entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace VEOS_WFA.model.collection
{
    class Timovi_Collection
    {
        private static Timovi_Collection instance;

        public static Timovi_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Timovi_Collection();
                }
                return instance;
            }
        }

        private Dictionary<Guid, Tim> timovi_collection;

        internal Dictionary<Guid, Tim> Timovi_collection
        {
            get { return timovi_collection; }
            set { timovi_collection = value; }
        }

        private readonly string datoteka;

        public Timovi_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Timovi.dat");
            load();
        }

        public void addTim(Tim novi)
        {
            if (!timovi_collection.ContainsKey(novi.Sifra))
            {
                timovi_collection.Add(novi.Sifra, novi);
            }

            save();
        }

        public void removeTim(Tim stari)
        {
            timovi_collection.Remove(stari.Sifra);
            save();
        }

        public void modifyTim(Tim novi)
        {
            System.Diagnostics.Debug.WriteLine(novi.Ime);
            if (timovi_collection.ContainsKey(novi.Sifra))
            {
                System.Diagnostics.Debug.WriteLine(novi.Ime);
                timovi_collection.Remove(novi.Sifra);
                timovi_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public int size()
        {
            return timovi_collection.Count;
        }

        public void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, timovi_collection);
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
                    timovi_collection = (Dictionary<Guid, Tim>)formatter.Deserialize(stream);
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
                timovi_collection = new Dictionary<Guid, Tim>();
        }


    }
}
