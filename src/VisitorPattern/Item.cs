

class Item(int id, double price)
{
  public int Id = id;
  public double Price = price;

  public double GetDiscount(double percentage)
  {
    return Math.Round(Price * percentage, 2);
  }
}
