using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VEOS_WFA.model.entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace VEOS_WFA.model.collection
{
    class Sportiste_Collection
    {

        private static Sportiste_Collection instance;

        public static Sportiste_Collection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sportiste_Collection();
                }
                return instance;
            }
        }

        private Dictionary<Guid, Sportista> sportiste_collection;

        internal Dictionary<Guid, Sportista> Sportiste_collection
        {
            get { return sportiste_collection; }
            set { sportiste_collection = value; }
        }

        private readonly string datoteka;

        public Sportiste_Collection()
        {
            datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sportisti.dat");
            load();
        }

        public void addSportista(Sportista novi)
        {
            if (!sportiste_collection.ContainsKey(novi.Sifra))
            {
                sportiste_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public void removeSportista(Sportista stari)
        {
            sportiste_collection.Remove(stari.Sifra);
            save();
        }

        public void modifySportista(Sportista novi)
        {
            if (sportiste_collection.ContainsKey(novi.Sifra))
            {
                sportiste_collection.Remove(novi.Sifra);
                sportiste_collection.Add(novi.Sifra, novi);
            }
            save();
        }

        public int size()
        {
            return sportiste_collection.Count;
        }

        public void save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, sportiste_collection);
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
                    sportiste_collection = (Dictionary<Guid, Sportista>)formatter.Deserialize(stream);
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
                sportiste_collection = new Dictionary<Guid, Sportista>();
        }



    }
}
