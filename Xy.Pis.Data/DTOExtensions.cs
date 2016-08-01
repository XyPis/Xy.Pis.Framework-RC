using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
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
                throw new ArgumentNullException("dto");
        }

        public static void Validation(this IEnumerable<DTOBase> dtos)
        {
            if (dtos == null)
                throw new ArgumentNullException("dtos");

            if (!dtos.Any())
                throw new ArgumentOutOfRangeException("dtos");
        }
    }
}
