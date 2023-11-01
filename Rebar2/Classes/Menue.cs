using Rebar.Models;
using System.Runtime.CompilerServices;

namespace Rebar.Classes
{
    public static class Menue
    {
        //private Shake shake1 = new Shake("Tot", "descrption....", 10, 15, 20);
        //private Shake shake2 = new Shake("banana", "descrption....", 10, 15, 20);
        //private Shake shake3 = new Shake("Tot-banana", "descrption....", 10, 15, 20);
        //private Shake shake4 = new Shake("Tot-with-milk", "descrption....", 10, 15, 20);
        //private Shake shake5 = new Shake("banana-with-milk", "descrption....", 10, 15, 20);
        //private List<Shake> shakes = new List<Shake>();
        //public Menue()
        //{
        //    MenueDataAccess db = new MenueDataAccess();
        //    db.CreateMenue(shake1);

        //}
        public static void addShake(Shake shake)
        {
            MenueDataAccess db = new MenueDataAccess();
            db.AddToMeneu(shake);
        }

    }
}


