/// <summary>
/// Representa una transición entre estados en una máquina de estados finitos (FSM). 
/// Contiene la entrada que provoca la transición y el estado al que se transita.
/// </summary>

public class Transition
{
    /// <summary>
    /// Obtiene la entrada que provoca la transición.
    /// </summary>
    public Input Input { get; }

    /// <summary>
    /// Obtiene el estado al que se transita.
    /// </summary>
    public State NextState { get; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Transition"/> con la entrada y el estado de destino especificados.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="nextState"></param>
    public Transition(Input input, State nextState)
    {
        Input = input;
        NextState = nextState;
    }
}