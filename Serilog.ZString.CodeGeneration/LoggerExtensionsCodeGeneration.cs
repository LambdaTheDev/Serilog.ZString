namespace Serilog.ZString.CodeGeneration
{
    public class LoggerExtensionsCodeGeneration
    {
        private static readonly string[] FilesToGenerate = new[]
        {
            "Debug", "Information", "Warning", "Error", "Fatal"
        };

        private const string FileNameTemplate = "{0}LoggerExtensions.cs";
        
        
        public LoggerExtensionsCodeGeneration(string solutionFolder)
        {
            string extensionsPath = solutionFolder + Path.DirectorySeparatorChar + "Serilog.ZString" +
                                    Path.DirectorySeparatorChar + "Extensions" + Path.DirectorySeparatorChar + "Logger";

            // Delete all files besides template one
            string templateFile = null!;
            string[] existingFiles = Directory.GetFiles(extensionsPath);
            foreach (var file in existingFiles)
            {
                if (!file.EndsWith("VerboseLoggerExtensions.cs"))
                    File.Delete(file);
                else templateFile = file;
            }
            
            // Load all text from template file
            string templateFileContent = File.ReadAllText(templateFile);
            
            // Generate new files
            foreach (var fileToGen in FilesToGenerate)
            {
                // Prepare new file
                string fileName = string.Format(FileNameTemplate, fileToGen);
                string generatedFilePath = extensionsPath + Path.DirectorySeparatorChar + fileName;
                string generatedFileContent = templateFileContent.Replace("Verbose", fileToGen);
                
                // Write content
                using (var generatedFile = File.CreateText(generatedFilePath))
                {
                    generatedFile.Write(generatedFileContent);
                    Console.WriteLine("Generated file: " + fileName);
                }
            }
        }
    }
}