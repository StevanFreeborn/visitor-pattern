

class ObjectStructure(IEnumerable<IVisitableElement> items)
{
  private readonly List<IVisitableElement> _cart = items.ToList();

  public void RemoveItem(IVisitableElement item)
  {
    _cart.Remove(item);
  }

  public void AddItem(IVisitableElement item)
  {
    _cart.Add(item);
  }

  public void ApplyVisitor(IVisitor visitor)
  {
    foreach (var item in _cart)
    {
      item.Accept(visitor);
    }

    visitor.Print();
  }
}