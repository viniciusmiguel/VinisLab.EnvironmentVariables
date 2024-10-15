namespace VinisLab.EnvironmentVariables;

public class EnvironmentVariables : IEnviromentVariables
{
    public string GetEnvironmentVariable(string name)
    {
        string? value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);

        value ??= Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User);

        value ??= Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Machine);

        if (value is null)
            throw new EnvironmentVariableNotFoundException(name);

        return value;
    }
}
