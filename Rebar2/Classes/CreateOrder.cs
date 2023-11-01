using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebar2.Classes
{
    internal static class CreateOrder
    {
        public static CreateOrder()
        {
            MenueDataAccess access = new MenueDataAccess();
            var shakes = access.GetAllShakes().To;
            foreach ( var shake in shakes )
            {
                Console.WriteLine(shake.id)+"\n";
            }
            Console.WriteLine("please enter which shake do you whant");
            string nameShake=Console.ReadLine();
            Shake shake = access.GetShakeById(nameShake);

        }
    }
}
