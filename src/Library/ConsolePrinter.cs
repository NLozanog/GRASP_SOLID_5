using System;

namespace Full_GRASP_And_SOLID
{   

    //Ahora recibe IRecipePrint en vez de recipe
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipePrint recipePrint)
        {
            Console.WriteLine(recipePrint.GetTextToPrint());
        }
    }
}