using System;
using System.Collections.Generic;
using System.Text;

namespace State.Core
{
    public class OpState: AbstractState
    {
        public OpState(Calculator calculator): base(calculator)
        {
        }

        public override void storeOperator(string title)
        {
            //calculator.setOperator(title);
            //calculator.setState(new OpState(calculator));
        }

        public override void showResult()
        {
            //calculator.showResult();
            //calculator.reset();
            //calculator.setState(new FirstNumberState(calculator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public override void storeDigit(String title)
        {
            //State Changing its State when an 
            calculator.setState(new SecondNumberState(calculator));
            calculator.addToCurrentNumber(title);
        }
    }
}
