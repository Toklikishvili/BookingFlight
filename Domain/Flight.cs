namespace Domain
{
    public class Flight
    {
        public int RemainingNumberOfSeats { get; set; }
        public Flight(int seatCapasacity)
        {
            RemainingNumberOfSeats = seatCapasacity;
        }

        public object? Book(string userFullName , int numberOfSeats)
        {
            if (numberOfSeats > this.RemainingNumberOfSeats)
                return new OverbookingError();

            RemainingNumberOfSeats -= numberOfSeats;
            return null;
        }
    }
}
