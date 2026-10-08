/// <summary>
/// Representa una máquina de estados finitos (FSM) que puede procesar entradas y cambiar de estado según las transiciones definidas.
/// </summary>

public abstract class StateMachine
{

    /// <summary>
    /// Lista de estados que forman parte de la máquina de estados finitos (FSM).
    /// </summary>
    private List<State> states = new List<State>();

    public State CurrentState { get; private set; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="StateMachine"/>.
    /// </summary>
    public StateMachine(State initialState)
    {
        CurrentState = initialState;
        states.Add(initialState);
    }

    /// <summary>
    /// Agrega un estado a la lista de estados de la máquina de estados finitos (FSM).
    /// </summary>
    /// <param name="state"></param>
    public void AddState(State state)
    {
        states.Add(state);
    }

    /// <summary>
    /// Procesa una entrada y realiza la transición al siguiente estado según las transiciones definidas en el estado actual.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public bool ProcessInput(Input input)
    {
        State nextState = CurrentState.GetNextState(input);

        if (nextState == CurrentState)
        {
            return false;
        }

        CurrentState = nextState;
        return true;
    }

    /// <summary>
    /// Procesa una lista de entradas y realiza las transiciones correspondientes según las transiciones definidas en los estados actuales.
    /// Devuelve <see langword="true"/> si todas las entradas fueron procesadas
    /// </summary>
    /// <param name="inputs"></param>
    /// <returns></returns>
    public bool ProcessInputs(List<Input> inputs)
    {
        foreach (Input input in inputs)
        {
            ProcessInput(input);
        }

        return true;
    }
}