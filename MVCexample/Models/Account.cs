
public enum AccountTypes{

    Checking,
    Savings,
    Cashmarket
}

public class Account {

    public int ID;
    public AccountTypes AccountType;
    public int AccountNumber;
    public float InterestRate;
    public int OwnerID;
    public int CurrentAmount;

    constructor(int ID, AccountTypes AccountType, int AccountNumber, float InterestRate, int OwnerID, int CurrentAmount){

        this.ID = ID;
        this.AccountType = AccountType;
        this.AccountNumber = AccountNumber;
        this.InterestRate = InterestRate;
        this.OwnerID = OwnerID;
        this.CurrentAmount = CurrentAmount;

    }

}
