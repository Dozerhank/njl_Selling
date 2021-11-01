using System;

public interface ISellable
{
    void SalesSpeech();
    void MakeSale(int x);
}

abstract class Salesperson
{
    protected string firstName { get; set; }
    protected string lastName { get; set; }

    public string GetName()
    {
        return firstName + " " + lastName;
    }
}

class RealEstateSalesperson : Salesperson, ISellable
{
    public int TotalValueSold { get; set; }
    public int TotalCommissionEarned { get; set; }
    public double CommissionRate;

    public RealEstateSalesperson(string f, string l, double cr)
    {
        TotalValueSold = 0;
        TotalCommissionEarned = 0;
        firstName = f;
        lastName = l;
        CommissionRate = cr;
    }

    public void SalesSpeech()
    {
        Console.WriteLine("This property will double in value in the next ten years");
        Console.WriteLine("Buy it now or regret it forever.");
        Console.WriteLine();
        return;
    }

    public void MakeSale(int x)
    {
        TotalValueSold += x;
        double temp = Convert.ToDouble(x) * CommissionRate;
        TotalCommissionEarned += Convert.ToInt32(temp);
        return;
    }
}

class GirlScout : Salesperson, ISellable
{
    public int TotalBoxes { get; set; }
    
    public GirlScout(string f, string l)
    {
        TotalBoxes = 0;
        firstName = f;
        lastName = l;
    }

    public void SalesSpeech()
    {
        Console.WriteLine("Would you like to buy some cookies?");
        Console.WriteLine("They are delicious and they help us go to camp.");
        Console.WriteLine();
        return;
    }

    public void MakeSale(int x)
    {
        TotalBoxes += x;
        return;
    }
}