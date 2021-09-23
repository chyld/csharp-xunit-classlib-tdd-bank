namespace Library
{
  public struct User
  {
    public string First;
    public string Last;

    public override string ToString() => $"{First} {Last}";
  }
}
