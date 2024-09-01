
internal class Myclass
{
    public string Nombre { get; internal set; }

    public static implicit operator Myclass(MyClass v)
    {
        throw new NotImplementedException();
    }
}