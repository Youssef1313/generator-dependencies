using Microsoft.CodeAnalysis;
using MS.CA.Utilities.CSharp.Generators;

namespace MyGen
{
    [Generator]
    public class HelloSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            // Use a type from the package.
            var writer = new CSharpGeneratorWriter();
            writer.Builder.AppendLine("#error The generator was run successfully :)");
            
            context.AddSource("File.g.cs", writer.Builder.ToString());
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}