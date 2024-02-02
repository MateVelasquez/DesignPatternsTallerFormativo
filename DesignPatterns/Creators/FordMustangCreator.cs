using DesignPatterns.Models;
using DesignPatterns.Models.Builder;

namespace DesignPatterns.Creators
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder.Build();
        }
    }
}
