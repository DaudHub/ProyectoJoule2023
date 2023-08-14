namespace ApiAlmacenes {
    public class Package {

        public int ID { get; set; }

        public List<string> Characteristics { get; set; }

        public string Comments { get; set; }

        public decimal Weight_Kg { get; set; }

        public decimal Volume_m3 { get; set; }

        public string User { get; set; }

        public string PhysicalState { get; set; }

        public string StateUser { get; set; }

    }
}