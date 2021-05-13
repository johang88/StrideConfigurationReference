using Stride.Engine;

namespace StrideConfigurationReference
{
    class StrideConfigurationReferenceApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
