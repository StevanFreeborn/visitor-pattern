

class SalesVisitor : IVisitor
{
  private int _totalBooks;
  private int _totalVinyls;

  private void Reset()
  {
    _totalBooks = 0;
    _totalVinyls = 0;
  }

  public void Print()
  {
    Console.WriteLine();
    Console.WriteLine($"Total books: {_totalBooks}");
    Console.WriteLine($"Total vinyls: {_totalVinyls}");
    Console.WriteLine();
    Reset();
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
