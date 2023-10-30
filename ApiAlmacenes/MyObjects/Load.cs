using Microsoft.AspNetCore.SignalR;

namespace ApiAlmacenes {
    public class Load {
        public int Bundle { get; set; }
        public string Plate { get; set; }
        public string User { get; set; }
        public string Departure_Date { get; set; }
    }
}