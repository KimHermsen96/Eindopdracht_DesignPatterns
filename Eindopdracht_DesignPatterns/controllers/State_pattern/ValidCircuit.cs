using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.State
{
    public class ValidCircuit : IState
    {
        private Circuit Circuit { get; set; }

        public void DoAction(Circuit _circuit)
        {
            Circuit = _circuit; 
            CicruitIterator circuitIterator = new CicruitIterator(Circuit.Firsts);
            circuitIterator.Run();
        }
    }
}
