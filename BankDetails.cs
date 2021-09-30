using System;

public class BankDetails : IEquatable<BankDetails>
{
    public int AccountNo{get; set;}
    public int PIN{get; set;}
    public int AmountAvailable{get; set;}
    public override string ToString()
    {
        return "Account Number: " + AccountNo + "   PIN: " + PIN + "   AmountAvailable: " + AmountAvailable;
    }
    public bool Equals(BankDetails other)
    {
        if (other == null) return false;
        return (this.PIN.Equals(other.PIN));
    }
}