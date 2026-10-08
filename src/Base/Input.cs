/// <summary>
/// Representa una entrada que puede ser utilizada para determinar la transición entre estados en una máquina de estados finitos (FSM).
/// </summary>

public class Input
{
    
    /// <summary>
    /// Obtiene el nombre de la entrada, que se utiliza para identificarla en las transiciones.
    /// </summary>
    public string Name { get; }

    public Input(string name)
    {
        Name = name;
    }
}