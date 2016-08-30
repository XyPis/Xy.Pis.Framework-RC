using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Xy.Pis
{
    public static class DTOExtensions
    {
        public static T MapTo<T>(this DTOBase dto)
        {
            return (dto == null) ? default(T) : Mapper.Map<DTOBase, T>(dto);
        }

        public static IEnumerable<T> MapTo<T>(this IEnumerable<DTOBase> dtos)
        {
            return (dtos == null) ? new List<T>() : Mapper.Map<IEnumerable<DTOBase>, IEnumerable<T>>(dtos);
        }

        public static void Validation(this DTOBase dtos)
        {
            if (dtos == null)
            {
                throw new ArgumentNullException("dto");
            }                
        }

        public static void Validation(this IEnumerable<DTOBase> dtos)
        {
            if (dtos == null)
            {
                throw new ArgumentException("DTOs can not be null", "dtos");
            }                

            if (!dtos.Any())
            {
                throw new ArgumentException("DTOs can not be empty", "dtos");
            }                
        }
    }
}
