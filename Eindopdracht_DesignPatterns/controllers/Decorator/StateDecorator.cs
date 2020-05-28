using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Decorator
{
    public abstract class StateDecorator : IState
    {

        public IState _stateObject;

        public StateDecorator(IState circuit)
        {
            _stateObject = circuit;

        }

        public void DoAction(Circuit circuit)
        {
            throw new NotImplementedException();
        }
        //public abstract void DoAction(Circuit circuit)
        //{
        //   _stateObject.DoAction(circuit);
        //}
    }
}
