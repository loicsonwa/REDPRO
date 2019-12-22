using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.DAL
{
    public interface IDAL<T>
    {
        /// <summary>
        /// Va permettre de retourner la position de l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item">L'objet</param>
        /// <returns>La position de l'objet</returns>
        int IndexOf(T item);

        /// <summary>
        /// Va permettre de modifier un objet en fonction de sa position <paramref name="index"/>
        /// </summary>
        /// <param name="index">Position de l'objet</param>
        /// <returns>Le nouvel objet</returns>
        T this[int index] { get; set; }

        /// <summary>
        /// Va permettre d'ajouter l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item">L'objet</param>
        void Add(T item);

        void Set(T item);

        T Get(T item);

        /// <summary>
        /// Va permettre de faire des recherches et de retourner des elements en fonction du <paramref name="predicate"/>
        /// </summary>
        /// <param name="predicate">Predicate</param>
        /// <returns>Une liste ou un objet</returns>
        IEnumerable<T> Find(Func<T, bool> predicate);

        /// <summary>
        /// Va permettre de supprimer l'objet <paramref name="item"/>
        /// </summary>
        /// <param name="item"></param>
        void Remove(T item);

        /// <summary>
        /// Va permettre de tous les elements de la liste
        /// </summary>
        List<T> AllItems { get; }

        /// <summary>
        /// Va permettre de compter le nombre d'objet present
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Va permettre de determiner si nous sommes en lecture simple ou pas
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Permet de verifier si l'objet <paramref name="item"/> existe deja
        /// </summary>
        /// <param name="item">L'objet</param>
        /// <returns>true dans le cas ou il contient l'objet existe deje et false dans le cas contraire</returns>
        bool Contains(T item);

        /// <summary>
        /// Va permettre de supprimer tous les elements de la liste
        /// </summary>
        void Clear();
    }
}
