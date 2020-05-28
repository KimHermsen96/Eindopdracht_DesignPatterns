using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.Decorator
{
    public class ValidStateDecorator : StateDecorator
    {
        public ValidStateDecorator(IState circuit) : base(circuit)
        {
        }

        //public override void DoAction(Circuit circuit)
        //{
        //    _stateObject.DoAction(circuit);

        //    //sendUserInput();
        //}
    }
}
