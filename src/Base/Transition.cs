public class Transition
{
    public Input Input { get; }
    public State NextState { get; }

    public Transition(Input input, State nextState)
    {
        Input = input;
        NextState = nextState;
    }
}