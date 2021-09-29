using System;

public class BankDetails : IEquatable<BankDetails>
{
    public string Name{get; set;}
    public int PIN{get; set;}
    public int AmountAvailable{get; set;}
    public override string ToString()
    {
        return "Name: " + Name + "   PIN: " + PIN + "   AmountAvailable: " + AmountAvailable;
    }
    public bool Equals(BankDetails other)
    {
        if (other == null) return false;
        return (this.PIN.Equals(other.PIN));
    }
}