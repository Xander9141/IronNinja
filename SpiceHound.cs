class SpiceHound : Ninja
{
    public override bool IsFull => calorieIntake >= 1200;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            if (item.IsSpicy)
            {
                calorieIntake += item.Calories - 5; // Restar 5 calorías si el artículo consumible es picante
            }
            else
            {
                calorieIntake += item.Calories;
            }

            ConsumptionHistory.Add(item); // Agregar el artículo consumible a la lista ConsumptionHistory
            Console.WriteLine(item.GetInfo()); // Mostrar la información del artículo consumible

            if (IsFull)
            {
                Console.WriteLine("SpiceHound está lleno y no puede comer más.");
            }
        }
        else
        {
            Console.WriteLine("SpiceHound está lleno y no puede comer más.");
        }
    }
}
