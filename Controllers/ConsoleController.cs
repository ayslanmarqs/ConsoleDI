using ConsoleDI.Presenters;
using ConsoleDI.UseCases;

namespace ConsoleDI.Controllers
{
    public class ConsoleController: IController
    {
        private IPresenter presenter;
        private IUseCase useCase;

        public ConsoleController(IPresenter presenter, IUseCase useCase)
        {
            this.presenter = presenter;
            this.useCase = useCase;
        }

        public void Run()
        {
            presenter.AskOperation();
            var operands = presenter.AskOperands();
            var result = useCase.DoOperation(operands.Item1, operands.Item2);
            presenter.ShowResult(result);
        }
    }
}