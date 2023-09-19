using System.Collections.Generic;

namespace DesignPatternSample.Filter
{
    public interface IFilter<T>
    {
        List<T> Filter(List<T> roleList);
    }
}