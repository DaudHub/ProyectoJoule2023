namespace ApiAlmacenes {
    public class VerifTriangle<TypeA, TypeB> {
        
        public TypeA Element1 { get; set; }

        public TypeB Element2 { get; set; }
        public Verification Credentials { get; set; }

        public VerifTriangle(TypeA element1, TypeB element2, Verification credentials) {
            Element1 = element1;
            Element2 = element2;
            Credentials = credentials;
        }
    }
}
