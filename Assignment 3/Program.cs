namespace Assignment_3
{
    internal class Program
    {
        #region Part 02
        //enum TicketType
        //{
        //    Standard,
        //    VIP,
        //    IMAX

        //}
        //struct Seat
        //{
        //    public char Row;
        //    public int Number;

        //    public Seat(char row, int number)
        //    {
        //        Row = row;
        //        Number = number;
        //    }

        //    public override string ToString() => $"{Row}{Number}";

        //}
        ////1
        //class Ticket

        //{
        //    //1.a
        //    public static int counter = 0;
        //    public string MovieName { get; set; }
        //    public int Ticketid { get; }


        //    private decimal _price;

        //    public decimal Price
        //    {
        //        get
        //        {
        //            return _price;

        //        }
        //        set
        //        {
        //            if (value > 0)
        //                _price = value;
        //        }
        //    }
        //    //1.c
        //    public decimal PriceAfterTax => _price + (_price * 14m / 100);

        //    //1.b
        //    public Ticket(string moviename, decimal price)
        //    {
        //        MovieName = moviename;
        //        Price = price;
        //        counter++;
        //        Ticketid = counter;


        //    }
        //    //1.d
        //    public override string ToString()
        //        => $"[{Ticketid}] {MovieName} | Price : {Price} EGP | Price After Tax : {PriceAfterTax} EGP";
        //    //1.e
        //    public static int GetTotalTickets() => counter;

        //}
        ////2
        ////2.a
        //class StandardTicket : Ticket
        //{
        //    public string SeatNumber { get; set; }

        //    public StandardTicket (string moviename,decimal price,string seatnumber):base(moviename, price)
        //    {
        //        SeatNumber = seatnumber;
        //    }

        //    public override string ToString()
        //    {
        //        return base.ToString() + $"| Seat :{SeatNumber}";
        //    }

        //}
        ////2.b
        //class VIPTicket : Ticket
        //{
        //    public bool LoungeAccess { get; set; }
        //    public decimal ServiceFee { get; } = 50;

        //    public VIPTicket(string moviename , decimal price , bool loungeAccess): base(moviename, price)
        //    {
        //        loungeAccess = loungeAccess;
        //    }
        //    public override string ToString()
        //    {
        //        return base.ToString() + $"|  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee : {ServiceFee} EGP";
                 
        //    }
        //}
        ////2.c
        //class IMAXTicket : Ticket
        //{
        //    private bool _is3D;

        //    public bool Is3D
        //    {
        //        get { return _is3D; }
        //        set
        //        {
        //            if (value && !_is3D)
        //                Price += 30;
        //            if (!value && _is3D)
        //                Price -= 30;
        //            value = _is3D;

        //        }
        //    }
        //    public IMAXTicket(string moviename , decimal price, bool is3D) : base(moviename, price)
        //    {
        //        if(is3D) Price += 30;
        //        _is3D = is3D;
        //    }

        //    public override string ToString()
        //    {
        //        return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        //    }

        //}
        ////3
        //class Projector
        //{
        //    public bool IsRunning { get; private set; }

        //    public void Start()
        //    {
        //        IsRunning = true;
        //        Console.WriteLine("Projector started.");
        //    }
        //    public void Stop()
        //    {
        //        IsRunning = false;
        //        Console.WriteLine("Projector stopped.");
        //    }

        //}
        //class Cinema
        //{
        //    public string CinemaName { get; set; }
        //    private Projector _projector = new Projector();
        //    private Ticket[] tickets = new Ticket[20];

        //    public Cinema (string cinemaname)
        //    {
        //        CinemaName = cinemaname;
        //    }
        //    public Ticket this[int index]
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= tickets.Length)
        //                return null;
        //            return tickets[index];

        //        }
        //        set
        //        {

        //            if (index < 0 || index >= tickets.Length)
        //                return;
        //            tickets[index] = value;


        //        }

        //    }
        //    public Ticket this[string movieName]
        //    {
        //        get
        //        {
        //            foreach (Ticket t in tickets)
        //            {
        //                if (t != null && t.MovieName == movieName)
        //                    return t;

        //            }
        //            return null;
        //        }

        //    }

        //    //3.a
        //    public bool AddTicket(Ticket t)
        //    {
        //        for (int i = 0; i < tickets.Length; i++)
        //        {
        //            if (tickets[i] == null)
        //            {
        //                tickets[i] = t;
        //                return true;
        //            }
        //        }
        //        Console.WriteLine("Cinema is full.");
        //        return false;
        //        {

        //        }
        //    }
        //    //3.b
        //    public void PrintAllTickets()
        //    {
        //        Console.WriteLine($"\n=== {CinemaName} Tickets ===");
        //        bool any = false;
        //        foreach (Ticket t in tickets)
        //        {
        //            if(t != null)
        //            { Console.WriteLine(t); any = true; }
        //            if (!any) Console.WriteLine("No tickets yet.");
        //        }
                    
        //    }
            
        //    //3.c
        //    public void OpenCinema()
        //    {
        //        Console.WriteLine("========== Cinema Opened ==========");
        //        _projector.Start();
        //    }
        //    public void CloseCinema()
        //    {
        //        Console.WriteLine("========== Cinema Closed ==========");
        //        _projector.Stop();
        //    }
        //}

        //static class BookingHelper
        //{
        //    private static int counter = 0;
        //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        //    {
        //        double total = numberOfTickets * pricePerTicket;
        //        if (numberOfTickets > 5)
        //        {
        //            return total - (total * 10.0 / 100);
        //        }
        //        return total;
        //    }
        //    public static string GenerateBookingReference()
        //    {
        //        counter++;
        //        return $"BK-{counter}";
        //    }


        //}
        #endregion
        static void Main(string[] args)
        {
            #region Part 01
            #region Question01
            //a)Association>>Composition
            //b)Association
            //c)Inheritance
            //d)Association>>Aggregation
            //e)Dependency
            #endregion
            #region Question02
            //a)Yes. protected means accessible within the class itself and in any derived class
            //>>No. Even within the child class, you can't access a protected member through an arbitrary instance of the parent type as it will behave like private access modifier.

            //b)With inheritance
            //protected internal >>Accessible from any subclass  + any code in the same assembly
            //private protected >>Accessible only from subclasses that are also in the same assembly
            //Without inheritance
            //protected internal >>Members are accesible in same assembly
            //private protected >>Members with the same class

            //c)Class>>A sealed class is a class that cannot be inherited. It stops the inheritance chain completely.
            //Method>>A method can be sealed inside a derived class to prevent further overriding down the chain.

            //d) Yes! Sealed prevents inheritance, not instantiation. You can still create objects.
            #endregion
            #endregion
            #region Part02
            ////4
            ////4.a
            //Cinema cinema = new Cinema("Galaxy");
            //cinema.OpenCinema();

            ////4.b
            //cinema.AddTicket(new StandardTicket("Inception", 120, "A-5"));
            //cinema.AddTicket(new VIPTicket("Avengers", 200, true));
            //cinema.AddTicket(new IMAXTicket("Dune", 180, false));

            ////4.c
            //cinema.PrintAllTickets();

            //Console.WriteLine("\n========== Statistics ==========");
            //Console.WriteLine($"Total Tickes Created : {Ticket.GetTotalTickets()}");
            //Console.WriteLine();
            //Console.WriteLine($"Booking Ref 1 : {BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine($"Booking Ref 2 : {BookingHelper.GenerateBookingReference()}");

            //double groupTotal = BookingHelper.CalcGroupDiscount(5, 100);
            //Console.WriteLine($"\nGroup Discount (5 x 100 EGP): {groupTotal} EGP (10% off)");

            ////4.d
            //cinema.CloseCinema();



            #endregion
        }
    }
}
