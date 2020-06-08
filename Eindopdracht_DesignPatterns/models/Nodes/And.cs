using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class And : Composite
    {

        public override void CalculateOutput(int _value)
        {

            //short circuit
            if(_value == 0)
            {
                Value = 0; 
                Finished = true;
                Continue();
                return; 
            }

            SavedValues.Add(_value);
            //if two values came in and they were both not 0 then they were 1. 
            if (SavedValues.Count == NumberOfInputNodes)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }
        }

        public override bool ValidNode()
        {
            return NumberOfInputNodes == 2;
        }
    }
}
