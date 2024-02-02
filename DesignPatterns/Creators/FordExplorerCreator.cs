using DesignPatterns.Models;
using DesignPatterns.Models.Builder;

namespace DesignPatterns.Creators
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarModelBuilder()
                .SetModel("Explorer")
                .SetColor("blue");
            return builder.Build();
        }   

    }
}
