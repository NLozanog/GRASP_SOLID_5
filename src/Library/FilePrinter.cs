using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipePrint recipePrint)
        {
            File.WriteAllText("Recipe.txt", recipePrint.GetTextToPrint());
        }
    }
}