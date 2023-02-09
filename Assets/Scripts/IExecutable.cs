using RPG.Units;

namespace RPG.Actions
{
    public interface IExecutable
    {
        void Execute(BaseUnit agent, BaseUnit target);
    }
}
