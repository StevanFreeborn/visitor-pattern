

class Vinyl(int id, double price) : Item(id, price), IVisitableElement
{
  public void Accept(IVisitor visitor)
  {
    visitor.VisitVinyl(this);
  }
}