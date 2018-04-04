namespace _03BarracksFactory.Contracts
{
    public interface ICommandInterpreter
    {
        string InterpretCommand(string[] data, string commandName);
    }
}
