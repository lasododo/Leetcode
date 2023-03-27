using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.DesignBrowserHistory
{
    public class BrowserHistory
    {
        private Stack<string> _history = new();
        private Stack<string> _forwardHistory = new();

        public BrowserHistory(string homepage)
        {
            _history.Push(homepage);
        }

        public void Visit(string url)
        {
            _history.Push(url);
            _forwardHistory = new();
        }

        public string Back(int steps)
        {
            while (_history.Count > 1 && steps > 0)
            {
                _forwardHistory.Push(_history.Pop());
                steps--;
            }

            return _history.Peek();
        }

        public string Forward(int steps)
        {
            while (_forwardHistory.Count > 0 && steps > 0)
            {
                _history.Push(_forwardHistory.Pop());
                steps--;
            }

            return _history.Peek();
        }
    }

}
