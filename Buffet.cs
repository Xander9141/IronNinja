using System;
using System.Collections.Generic;

class Buffet
{
    public List<IConsumable> Menu; // Modificación: Cambio de List<Food> a List<IConsumable>

    // Constructor
    public Buffet()
    {
        Menu = new List<IConsumable>() // Modificación: Creación de una lista de IConsumable
        {
            new Food("Hamburguesa", 100, false, false),
            new Food("Hot Dog", 90, false, false),
            new Food("Arroz Chino", 50, true, false),
            new Food("Pizza", 120, false, false),
            new Food("Pie de Limón", 85, false, true),
            new Food("Chile al Jugo", 30, true, false),
            new Food("Sopaipilla", 20, false, false),
            new Drink("Coca Cola", 200, false, true), // Adición de una bebida al menú
            new Drink("Limonada", 150, false, true) // Adición de otra bebida al menú
        };
    }

    public IConsumable Serve() // Modificación: Cambio de Food a IConsumable
    {
        Random random = new Random();
        int randomIndex = random.Next(Menu.Count);
        return Menu[randomIndex];
    }
}
