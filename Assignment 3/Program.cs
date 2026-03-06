namespace Assignment_3
{
    internal class Program
    {
        #region Part 02
        enum TicketType
        {
            Standard,
            VIP,
            IMAX

        }
        struct Seat
        {
            public char Row;
            public int Number;

            public Seat(char row, int number)
            {
                Row = row;
                Number = number;
            }

            public override string ToString() => $"{Row}{Number}";

        }
        //1
        class Ticket

        {
            //1.a
            public static int counter = 0;
            public string MovieName { get; set; }
            public int Ticketid { get; }


            private decimal _price;

            public decimal Price
            {
                get
                {
                    return _price;

                }
                set
                {
                    if (value > 0)
                        _price = value;
                }
            }
            //1.c
            public decimal PriceAfterTax => _price + (_price * 14m / 100);

            //1.b
            public Ticket(string moviename, decimal price)
            {
                MovieName = moviename;
                Price = price;
                counter++;
                Ticketid = counter;


            }
            //1.d
            public override string ToString()
                => $"[{Ticketid}] {MovieName} | Price : {Price:c} | Price After Tax : {PriceAfterTax:c}";
            //1.e
            public static int GetTotalTickets() => counter;

        }
        class Cinema
        {
            private Ticket[] tickets = new Ticket[20];
            public Ticket this[int index]
            {
                get
                {
                    if (index < 0 || index >= tickets.Length)
                        return null;
                    return tickets[index];

                }
                set
                {

                    if (index < 0 || index >= tickets.Length)
                        return;
                    tickets[index] = value;


                }

            }
            public Ticket this[string movieName]
            {
                get
                {
                    foreach (Ticket t in tickets)
                    {
                        if (t != null && t.MovieName == movieName)
                            return t;

                    }
                    return null;
                }

            }
            public bool AddTicket(Ticket t)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == null)
                    {
                        tickets[i] = t;
                        return true;
                    }
                }
                return false;
                {

                }
            }
        }

        static class BookingHelper
        {
            private static int counter = 0;
            public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
            {
                double total = numberOfTickets * pricePerTicket;
                if (numberOfTickets > 5)
                {
                    return total - (total * 10.0 / 100);
                }
                return total;
            }
            public static string GenerateBookingReference()
            {
                counter++;
                return $"BK-{counter}";
            }


        }
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
        }
    }
}
