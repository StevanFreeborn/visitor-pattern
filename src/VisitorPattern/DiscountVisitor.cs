

class DiscountVisitor : IVisitor
{
  private double _savings;

  public void Print()
  {
    Console.WriteLine();
    Console.WriteLine($"Total savings: {Math.Round(_savings, 2)}");
    Console.WriteLine();
  }

  public void VisitBook(Book book)
  {
    var discount = 0.0;

    if (book.Price < 20.00)
    {
      discount = book.GetDiscount(0.10);
      Console.WriteLine($"DISCOUNTED: Book #{book.Id} is now {Math.Round(book.Price - discount, 2)}");
    }
    else
    {
      Console.WriteLine($"FULL PRICE: Book #{book.Id} is {Math.Round(book.Price - discount, 2)}");
    }

    _savings += discount;
  }

  public void VisitVinyl(Vinyl vinyl)
  {
    var discount = vinyl.GetDiscount(0.15);
    Console.WriteLine($"DISCOUNTED: Vinyl #{vinyl.Id} is now {Math.Round(vinyl.Price - discount, 2)}");

    _savings += discount;
  }
}
