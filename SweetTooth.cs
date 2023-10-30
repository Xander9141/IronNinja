class SweetTooth : Ninja
{
    public override bool IsFull => calorieIntake >= 1500;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            if (item.IsSweet)
            {
                calorieIntake += item.Calories + 10; // Agregar 10 calorías extras si el artículo consumible es dulce
            }
            else
            {
                calorieIntake += item.Calories;
            }

            ConsumptionHistory.Add(item); // Agregar el artículo consumible a la lista ConsumptionHistory
            Console.WriteLine(item.GetInfo()); // Mostrar la información del artículo consumible

            if (IsFull)
            {
                Console.WriteLine("SweetTooth está lleno y no puede comer más.");
            }
        }
        else
        {
            Console.WriteLine("SweetTooth está lleno y no puede comer más.");
        }
    }
}
