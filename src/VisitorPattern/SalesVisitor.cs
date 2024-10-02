

class SalesVisitor : IVisitor
{
  private int _totalBooks;
  private int _totalVinyls;

  public void Print()
  {
    Console.WriteLine();
    Console.WriteLine($"Total books: {_totalBooks}");
    Console.WriteLine($"Total vinyls: {_totalVinyls}");
    Console.WriteLine();
  }

  public void VisitBook(Book book)
  {
    Console.WriteLine($"SOLD: Book #{book.Id}");
    _totalBooks++;
  }

  public void VisitVinyl(Vinyl vinyl)
  {
    Console.WriteLine($"SOLD: Vinyl #{vinyl.Id}");
    _totalVinyls++;
  }
}
