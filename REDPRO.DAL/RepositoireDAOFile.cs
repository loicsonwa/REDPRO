using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using REDPRO.DAL.SerialisationDeserialisation;

namespace REDPRO.DAL
{
    /// <summary>
    /// Classe repositoire qui va etre considerer comme le coeur de notre programme et va etre interpreter comme une sorte de CRUD
    /// </summary>
    /// <typeparam name="T">Type generique</typeparam>
    public class RepositoireDAOFile<T> : IDAL<T>
    {

        /// <summary>
        /// Variable utiliser pour effectuer la serialisation binaire contenu dans <seealso cref="SerialisationDeserialisation.Binaire{T}"/>
        /// </summary>
        private Binaire<T> binaire = new Binaire<T>();

        /// <summary>
        /// Liste qui va contenir tous les elements du fichier
        /// </summary>
        private List<T> listes = null;

        /// <summary>
        /// Variable qui va contenir le chemin qui mene au fichier
        /// </summary>
        private string fileName;

        /// <summary>
        /// Constructeur du repositoire
        /// </summary>
        public RepositoireDAOFile()
        {
            //verifier si la liste est null
            if (listes == null)
                listes = new List<T>();

            DirectoryInfo di = new DirectoryInfo("Datas");

            // Verifier si le dossier Datas existe
            if (!di.Exists)
                di.Create();

            FileInfo fi = new FileInfo($"Datas/{typeof(T).Name}.ins");

            // Verifier si le fichier existe
            if (!fi.Exists)
                fi.Create().Close();

            // Affecter le chemin du fichier a la variable fileName
            fileName = fi.FullName;

            // Affecter le contenu du fichier deserialiser a la liste
            listes = binaire.Deserialisation(fileName);
        }

        /// <summary>
        /// Va permettre de modifier un objet en fonction de sa position <paramref name="index"/>
        /// </summary>
        /// <param name="index">Position de l'objet</param>
        /// <returns>Le nouvel objet</returns>
        public T this[int index]
        {
            get
            {
                return listes[index];
            }
            set
            {
                int newIndex = IndexOf(value);
                if (newIndex == -1 || index == newIndex)
                {
                    listes[index] = value;
                    binaire.Serialisation(fileName, listes);
                }
                else
                {
                    throw new Exception("Element existant !");
                }
            }
        }

        /// <summary>
        /// Permet de compter le nombre d'objet present
        /// </summary>
        public int Count => listes.Count;

        /// <summary>
        /// Permet de determiner si nous sommes en lecture simple ou pas
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Permet de retourner la position de l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item">L'objet</param>
        /// <returns>La position de l'objet</returns>
        public int IndexOf(T item)
        {
            return listes.IndexOf(item);
        }

        /// <summary>
        /// Va permettre d'ajouter l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item">L'objet</param>
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            if (listes.Contains(item))
                throw new DuplicateWaitObjectException("item");

            listes.Add(item);
            binaire.Serialisation(fileName, listes);
        }

        /// <summary>
        /// Permet de verifier si l'objet <paramref name="item"/> existe deja
        /// </summary>
        /// <param name="item">L'objet</param>
        /// <returns>true dans le cas ou il contient l'objet existe deje et false dans le cas contraire</returns>
        public bool Contains(T item)
        {
            return listes.Contains(item);
        }

        /// <summary>
        /// Va permettre de faire des recherches et de retourner des elements en fonction du <paramref name="predicate"/>
        /// </summary>
        /// <param name="predicate">Predicate</param>
        /// <returns>Une liste ou un objet</returns>
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException("predicate");
            return listes.Where(predicate).ToArray();
        }

        public T Get(T item)
        {
            if (item == null)
                throw new ArgumentNullException("user");
            int index = listes.IndexOf(item);
            if (index >= 0)
                return listes[index];
            return default;
        }

        /// <summary>
        /// Va permettre de supprimer l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            if (Get(item) != null)
            {
                listes.Remove(item);
                binaire.Serialisation(fileName, listes);
            }
        }

        public void Set(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            int index = listes.IndexOf(item);
            if (index >= 0)
                listes[index] = item;

            binaire.Serialisation(fileName, listes);
        }

        /// <summary>
        /// Va permettre de tous les elements de la liste
        /// </summary>
        public List<T> AllItems => listes;

        /// <summary>
        /// Va permettre de supprimer tous les elements de la liste
        /// </summary>
        public void Clear()
        {
            listes.Clear();
            File.Delete(fileName);
        }
    }
}
