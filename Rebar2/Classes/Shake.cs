namespace Rebar.Models
{
    public class Shake
    {
        private string _name;
        private string _description;
        private double _priceSizeS;
        private double _priceSizeM;
        private double _priceSizeL;
        private Guid _id;


        public Shake(string name, string description, double priceSizeS, double priceSizeM, double priceSizeL)
        {
            Name = name;
            Description = description;
            PriceSizeS = priceSizeS;
            PriceSizeM = priceSizeM;
            PriceSizeL = priceSizeL;
            _id = Guid.NewGuid();
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public double PriceSizeS
        {
            get { return _priceSizeS; }
            set 
            {
                if(value < 0)
                    _priceSizeS = 0;
                _priceSizeS = value;
            }
        }
        public double PriceSizeM
        {
            get { return _priceSizeM; }
            set
            {
                if (value < 0)
                    _priceSizeM = 0;
                _priceSizeM = value;
            }
        }
        public double PriceSizeL
        {
            get { return _priceSizeL; }
            set
            {
                if (value < 0)
                    _priceSizeL = 0;
                _priceSizeL = value;
            }
        }
        public Guid Id
        {
            get { return _id; }
        }
    }
}
