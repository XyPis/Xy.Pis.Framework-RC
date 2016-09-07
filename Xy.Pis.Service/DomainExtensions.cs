using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Xy.Pis
{
    public static class DomainExtensions
    {
        public static void Validation(this EntityBase entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity can not be null", "entity");
            }
        }

        public static T MapTo<T>(this EntityBase entity)
        {
            return (entity == null) ? default(T) : Mapper.Map<EntityBase, T>(entity);
        }        

        public static void Validation(this IEnumerable<EntityBase> entities)
        {
            if (entities == null)
            {
                throw new ArgumentException("Entities can not be null", "entities");
            }

            if (!entities.Any())
            {
                throw new ArgumentOutOfRangeException("Entities can not be empty", "entities");
            }                
        }

        public static IEnumerable<T> MapTo<T>(this IEnumerable<EntityBase> entities)
        {
            return (entities == null) ? new List<T>() : Mapper.Map<IEnumerable<EntityBase>, IEnumerable<T>>(entities);
        }        
    }
}
