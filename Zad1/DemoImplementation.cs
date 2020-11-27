using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoTarget;

namespace DemoImplementation
{

    public static class DemoImplementation
    {

        public static IEnumerable<DemoTarget.PersonWithEmail> Flatten(IEnumerable<DemoSource.Person> people)
        {
            return from p in people
                   from e in p.Emails
                   select new PersonWithEmail
                   {
                       FormattedEmail = $"{e.Email} {e.EmailType}",
                       SanitizedNameWithId = $"{p.Name} {p.Id}"
                   };
        }

     

    }

}

