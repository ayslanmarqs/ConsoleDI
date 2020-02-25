namespace ConsoleDI.UseCases
{
    public class SumUseCase : IUseCase
    {
        public int DoOperation(int item1, int item2)
        {
            return item1 + item2;
        }
    }
}