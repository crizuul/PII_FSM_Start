using System.Collections.Generic;

namespace Ucu.Poo.Base
{
   public class State
    {
        private List<Transition> transitions;

        public State()
        {
            this.transitions = new List<Transition>();
        }

        public void AddTransition(Transition transition)
        {
            Transition transition = new Transition(input, state);
            this.transitions.Add(transition);
        }
    } 
}