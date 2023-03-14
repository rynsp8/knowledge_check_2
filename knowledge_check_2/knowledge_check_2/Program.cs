using knowledge_check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<seat>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    Console.WriteLine($"Let's start with seat number {numberOfRecords}!");
    Console.WriteLine($"What type of seat is seat{numberOfRecords}?");
    string typeOfSeat = Console.ReadLine();
    Console.WriteLine($"How many legs does your seat{numberOfRecords} have?");
    int seatLegs = int.Parse(Console.ReadLine());
    Console.WriteLine($"How soft is your seat{numberOfRecords}?");
    string seatComfort = Console.ReadLine();
    Console.WriteLine($"What color is your seat{numberOfRecords}?");
    string seatColor = Console.ReadLine();

    recordList.Add(new seat(typeOfSeat, seatLegs, seatComfort, seatColor));
}

// Print out the list of records using Console.WriteLine()

foreach (var seat in recordList)
{
    Console.WriteLine("Seat: {0}, {1}, {2}, {3}", seat.seatType, seat.legs, seat.softness, seat.color);
}

