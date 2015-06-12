using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;

namespace Projeto.Util
{
    public  class Util
    {
        public static ICollection<TTo> InjectFrom<TFrom, TTo>( ICollection<TTo> to, IEnumerable<TFrom> from) where TTo : new()
        {
            foreach (var source in from)
            {
                var target = new TTo();
                target.InjectFrom(source);
                to.Add(target);
            }
            return to;
        }
    }
}