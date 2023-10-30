class Program
{
    static void Main()
    {
        Buffet buffet = new Buffet(); // Instancia de Buffet

        SweetTooth sweetTooth = new SweetTooth(); // Instancia de SweetTooth
        SpiceHound spiceHound = new SpiceHound(); // Instancia de SpiceHound

        while (!sweetTooth.IsFull || !spiceHound.IsFull)
        {
            if (!sweetTooth.IsFull)
            {
                sweetTooth.Consume(buffet.Serve());
            }

            if (!spiceHound.IsFull)
            {
                spiceHound.Consume(buffet.Serve());
            }
        }

        Console.WriteLine("SweetTooth consumió " + sweetTooth.ConsumptionHistory.Count + " items.");
        Console.WriteLine("SpiceHound consumió " + spiceHound.ConsumptionHistory.Count + " items.");

        string mostItemsConsumed = sweetTooth.ConsumptionHistory.Count > spiceHound.ConsumptionHistory.Count
            ? "SweetTooth"
            : "SpiceHound";

        Console.WriteLine("El que consumió más ítems: " + mostItemsConsumed);
    }
}