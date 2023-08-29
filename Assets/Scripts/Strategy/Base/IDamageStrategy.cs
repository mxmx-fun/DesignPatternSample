using DesignPatternSample.Bridge;

namespace DesignPatternSample.Strategy
{
    public interface IDamageStrategy
    {
        int GetDamage(RoleEntity role);
    }
}