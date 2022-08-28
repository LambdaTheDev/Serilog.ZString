namespace Serilog.ZString.CodeGeneration;

public static class Program
{
    public static void Main(string[] args)
    {
        // Get top solution path
        string currentPath = Directory.GetCurrentDirectory();
        string solutionPath = Path.GetFullPath(Path.Combine(currentPath, "..", "..", "..", ".."));
        
        // Assert that path is valid
        if (!solutionPath.EndsWith("Serilog.ZString"))
            throw new Exception("Failed to access solution folder!");
        
        // Run code gen scripts
        new LoggerExtensionsCodeGeneration(solutionPath);
    }
}