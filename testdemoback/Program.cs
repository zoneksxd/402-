var builder = WebApplication.CreateBuilder();
var app = builder.Build();

List<Order> repo = new List<Order>();
{ 
   new Order(1, "Лайковский Артём Тимофеевич", 89826995936, "хочу холодный напиток в номер", "Абрикосовая 26А", 12, "12.04.2024", "24.04.2024" );
};    



app.MapGet("/", () => repo);
app.MapPost("/", (Order o) => repo.Add(o));
app.Run();

class Order
{
    int number;
    string fio;
    long phonenumber;
    string wishlist;
    string addres;
    int appartamentnumber;
    string arrivaldate;
    string departuredate;

    public Order(int number, string fio, long phonenumber, string wishlist, string addres, int appartamentnumber, string arrivaldate, string departuredate)
    {
        Number = number;
        Fio = fio;
        Phonenumber = phonenumber;
        Wishlist = wishlist;
        Addres = addres;
        Appartamentnumber = appartamentnumber;
        Arrivaldate = arrivaldate;
        Departuredate = departuredate;
    }

    public int Number { get => number; set => number = value; }
    public string Fio { get => fio; set => fio = value; }
    public long Phonenumber { get => phonenumber; set => phonenumber = value; }
    public string Wishlist { get => wishlist; set => wishlist = value; }
    public string Addres { get => addres; set => addres = value; }
    public int Appartamentnumber { get => appartamentnumber; set => appartamentnumber = value; }
    public string Arrivaldate { get => arrivaldate; set => arrivaldate = value; }
    public string Departuredate { get => departuredate; set => departuredate = value; }
}
