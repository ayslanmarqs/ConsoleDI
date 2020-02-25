using System;

namespace ConsoleDI.Presenters
{
    public interface IPresenter
    {
        string AskOperation();
        Tuple<int, int> AskOperands();
        void ShowResult(int result);
    }
}