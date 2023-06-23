namespace ApiAlmacenes {
    public class Package {

        public int ID { get; set; }

        public List<string> Characteristics { get; set; }

        public string Comments { get; set; }

        public int Weight_Kg { get; set; }

        public int Volume_m3 { get; set; }

        public int Customer { get; set; }

        public int Price { get; set; }

    }
}