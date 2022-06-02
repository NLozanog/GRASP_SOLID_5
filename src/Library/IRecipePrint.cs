
namespace Full_GRASP_And_SOLID
{

    //Se crea interface IRecipeprint para poder cumplir con el principio de inversion.
    public interface IRecipePrint
    {
        string GetTextToPrint();
    }
}