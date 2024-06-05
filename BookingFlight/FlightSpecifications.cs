using Domain;
using FluentAssertions;

namespace BookingFlightTest
{
    public partial class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapasacity: 3);

            flight.Book("Kakhaber Toklikishvili" , 1);

            flight.RemainingNumberOfSeats.Should().Be(2);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            var flight = new Flight(seatCapasacity: 3);

            var error = flight.Book("Kakhaber Toklikishvili" , 4);

            error.Should().BeOfType<OverbookingError>();
        }
    }
}