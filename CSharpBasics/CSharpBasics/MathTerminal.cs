using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class MathTerminal
    {
        private ICalculator _calc;
        private ILoggingService _logger;

        public MathTerminal(ICalculator calc, ILoggingService logService)
        {
            this._calc = calc;
            this._logger = logService;
        }

        public void DoSomeStuff()
        {
            _logger.LogMessage("Started Do Some Stuff Method", LogLevel.Information);


        }
    }
}
