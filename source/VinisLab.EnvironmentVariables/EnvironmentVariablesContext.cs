namespace VinisLab.EnvironmentVariables;

public static class EnvironmentVariablesContext
{
    public static IEnviromentVariables CreateStaticContext()
    {
        return new EnvironmentVariables();
    }
}
