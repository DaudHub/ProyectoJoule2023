namespace ApiAlmacenes {
    public class Bundle {
        
        public Bundle(int ID, int Deposit) {
            this.ID = ID;
            this.Deposit = Deposit;
        }
        public int ID { get; set; }

        public int Deposit { get; set; }

    }
}