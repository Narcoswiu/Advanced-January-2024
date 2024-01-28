namespace CarManufacturer
{
    class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
        
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower
        {
            get { return this.horsePower; }
            private set { this.horsePower = value; }
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            private set { this.cubicCapacity = value; }
        }
    }
}