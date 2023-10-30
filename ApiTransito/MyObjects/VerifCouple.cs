using System.Linq.Expressions;

namespace ApiAlmacenes {
    public class VerifCouple<TypeA> {
        
        public TypeA Element { get; set; }
        public Verification Credentials { get; set; }

        public VerifCouple(TypeA element, Verification credentials) {
            Element = element;
            Credentials = credentials;
        }

    }

}
