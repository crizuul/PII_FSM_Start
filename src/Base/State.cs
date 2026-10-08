/// <summary>
/// Representa un estado en una máquina de estados finitos (FSM).
/// </summary>

public class State
{

    /// <summary>
    /// Lista de transiciones que definen cómo se puede pasar a otros estados desde este estado.
    /// </summary>
    private List<Transition> transitions = new List<Transition>();

    public string Name { get; }

    public State(string name)
    {
        Name = name;
    }
    
    /// <summary>
    /// Agrega una transición a la lista de transiciones del estado.
    /// </summary>
    /// <param name="transition"></param>
    public void AddTransition(Transition transition)
    {
        transitions.Add(transition);
    }
    
    /// <summary>
    /// Obtiene el siguiente estado según la entrada proporcionada. 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public State GetNextState(Input input)
    {
        foreach (Transition transition in transitions)
        {
            if (transition.Input.Name == input.Name)
            {
                return transition.NextState;
            }
        }

        return this;
    }
}
