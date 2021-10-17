using System.Collections.Generic; 

namespace Packt.Shared 
{ 
   public class PersonComparer : IComparer<Person> 
   { 
      public int Compare(Person x, Person y) 
      { 
         // Compare the Name lengths...
         int result = x.name.Length
           .CompareTo(y.name.Length);

         /// ...if they are equal... 
         if (result == 0) 
         { 
            // ...then compare by the Names...
            return x.name.CompareTo(y.name); 
         } 
         else 
         { 
            // ...otherwise compare by the lengths.
            return result; 
         } 
      } 
   } 
}