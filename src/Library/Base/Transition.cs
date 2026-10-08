namespace Ucu.Poo.Fsm
{
   public class Transition
   {
      private Input triggerInput;
      private State nextState;

      public Transition(Input triggerInput, State nextState)
      {
         this.triggerInput = triggerInput;
         this.nextState = nextState;
      }

      public bool IsTriggeredBy(Input input)
      {
         return this.triggerInput == input;
      }

      public State NextState
      {
         get
         {
            return this.nextState;
         }
      }
   }
}