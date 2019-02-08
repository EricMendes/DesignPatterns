namespace DesignPatterns.Composite
{
    public interface IMenuComponent
    {
        ComponentType GetComponentType();
        string Name { get; }
        string Description { get; }
        void Print();

    }
}
