namespace Rebar.Models
{


    public enum Size { S=0,M=1,L=2}

    public class ShakeWhithPrice
    {
        Shake shake;
        Size size;
        double price;
        public ShakeWhithPrice(Shake shake,Size size)
        {
            this.shake = shake;
            this.size = size;
            switch(this.size)
            {
                case (Size)0:
                    {
                        this.price = shake.PriceSizeS;
                        break;
                    }
                case (Size)1:
                    {
                        this.price = shake.PriceSizeM;
                        break;
                    }
                case (Size)2:
                    {
                        this.price = shake.PriceSizeL;
                        break;
                    }
            }
        }
    }
    public class Orders
    {
        private List<ShakeWhithPrice> shakes;
        private double sumPrice;

    }
}
