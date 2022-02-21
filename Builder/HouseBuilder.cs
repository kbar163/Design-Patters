namespace DesignPatters.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        
        private House _product = new House();

        public HouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new House();
        }

        public void SetMainroom()
        {
            this._product.Add("Main Room");
        }

        public void SetKitchen()
        {
            this._product.Add("Kitchen");
        }

        public void SetBathroom()
        {
            this._product.Add("Bathroom");
        }

        public void SetGarage()
        {
            this._product.Add("Garage");
        }

        public void SetPorch()
        {
            this._product.Add("Porch");
        }


    }

}