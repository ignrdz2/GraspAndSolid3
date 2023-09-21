using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket(Recipe recipe)
        {
            if (recipe != null)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
        }
    }
}