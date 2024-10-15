namespace VinisLab.EnvironmentVariables;

public class EnvironmentVariableNotFoundException : Exception
{
    public EnvironmentVariableNotFoundException(string environmentVariableName)
        : base($"Environment variable {environmentVariableName} not found.")
    {
        
    }
}
