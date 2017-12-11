using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VEOS_WFA.model.entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace VEOS_WFA.model.collection
{
    class Sportovi_Collection
    {
        private static Sportovi_Collection instance;

        public static Sportovi_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sportovi_Collection();
                }
                return instance;
            }
        }

        private Dictionary<Guid, Sport> sportovi_collection;

        internal Dictionary<Guid, Sport> Sportovi_collection
        {
            get { return sportovi_collection; }
            set { sportovi_collection = value; }
        }

        private readonly string datoteka;

        public Sportovi_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sportovi.dat");
            load();
        }

        public void addSport(Sport novi)
        {
            if (!sportovi_collection.ContainsKey(novi.Sifra))
            {
                sportovi_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public void removeSport(Sport stari)
        {
            sportovi_collection.Remove(stari.Sifra);
            save();
        }

        public void modifySport(Sport novi)
        {
            if (sportovi_collection.ContainsKey(novi.Sifra))
            {
                sportovi_collection.Remove(novi.Sifra);
                sportovi_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public int size()
        {
            return sportovi_collection.Count;
        }

        public void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, sportovi_collection);
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
                    sportovi_collection = (Dictionary<Guid, Sport>)formatter.Deserialize(stream);
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
                sportovi_collection = new Dictionary<Guid, Sport>();
        }
    }
}
