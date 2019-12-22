using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.DAL.SerialisationDeserialisation
{
    public class Binaire<T>
    {

        /// <summary>
        /// Variable qui va nous permettre d'interpreter en binaire
        /// </summary>
        private BinaryFormatter bf = new BinaryFormatter();

        /// <summary>
        /// Fonction de serialisation qui va permettre de stocker les valeur dans le fichier <paramref name="fileName"/> provenant de la liste <paramref name="listes"/>
        /// </summary>
        /// <param name="fileName">Le nom du ficher</param>
        /// <param name="listes">La liste</param>
        public void Serialisation(string fileName, List<T> listes)
        {
            StreamWriter sw = null;
            try
            {
                using(sw = new StreamWriter(fileName))
                {
                    bf.Serialize(sw.BaseStream, listes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw?.Close();
                sw?.Dispose();
            }
        }

        /// <summary>
        /// Fonction de deserialisation qui va permettre de deserialiser les elements contenus dans le fichier <paramref name="fileName"/>
        /// </summary>
        /// <param name="fileName">Le nom du fichier</param>
        /// <returns></returns>
        public List<T> Deserialisation(string fileName)
        {
            // Liste de depart
            List<T> listes = new List<T>();

            StreamReader sr = null;
            try
            {
                using(sr = new StreamReader(fileName))
                {
                    if (File.ReadAllText(fileName) != string.Empty)
                    {
                        // Creer une nouvelle liste qui va contenir les elements a deserialiser dans le fichier
                        List<T> newListes = (List<T>)bf.Deserialize(sr.BaseStream);

                        // Ajouter les elements trouves dans la liste de depart
                        foreach (var item in newListes)
                            listes.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr?.Close();
                sr?.Dispose();
            }
            return listes;
        }
    }
}
