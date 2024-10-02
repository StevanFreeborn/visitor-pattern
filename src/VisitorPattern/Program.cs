IVisitableElement[] items = [
  new Book(1, 10.99),
  new Book(2, 20.99),
  new Vinyl(3, 30.99),
  new Vinyl(4, 40.99)
];

IVisitor[] visitors = [
  new DiscountVisitor(),
  new SalesVisitor(),
];

var cart = new ObjectStructure(items);

foreach (var visitor in visitors)
{
  cart.ApplyVisitor(visitor);
}
