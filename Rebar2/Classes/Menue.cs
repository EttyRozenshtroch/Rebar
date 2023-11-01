using Rebar.Models;
using System.Runtime.CompilerServices;

namespace Rebar.Classes
{
    public class Menue
    {
        private Shake shake1 = new Shake("Tot", "descrption....", 10, 15, 20);
        private Shake shake2 = new Shake("banana", "descrption....", 10, 15, 20);
        private Shake shake3 = new Shake("Tot-banana", "descrption....", 10, 15, 20);
        private Shake shake4 = new Shake("Tot-with-milk", "descrption....", 10, 15, 20);
        private Shake shake5 = new Shake("banana-with-milk", "descrption....", 10, 15, 20);
        private List<Shake> shakes = new List<Shake>();
        public Menue()
        {
            //shakes.Add(shake1);
            //shakes.Add(shake2);
            //shakes.Add(shake3);
            //shakes.Add(shake4);
            //shakes.Add(shake5);
            MenueDataAccess db = new MenueDataAccess();
            db.CreateMenue(shake1);

        }



    }
}


