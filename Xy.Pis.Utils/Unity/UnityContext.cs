using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Xy.Pis.Utils.Unity
{    
    internal sealed class UnityContext
    {
        private UnityContext() 
        {
        }

        public static IUnityContainer Instance
        {
            get { return Nested.Instance; }
        }

        internal class Nested
        {
            internal static readonly IUnityContainer Instance = new UnityContainer();

            static Nested()
            {
            }
        }
    }
}
