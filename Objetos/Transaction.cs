public class Transaction
{

    public Transaction()
    {
        status = "";
        payment_date = "";
        amount = 0;
        authorization_code = "";
        id = "";
        status_detail = 0;

    }

    private string status;

    public string Status
    {
        get { return status; }
        set { status = value; }
    }
    private string payment_date;

    public string Payment_date
    {
        get { return payment_date; }
        set { payment_date = value; }
    }
    private decimal amount;

    public decimal Amount
    {
        get { return amount; }
        set { amount = value; }
    }
    private string authorization_code;

    public string Authorization_code
    {
        get { return authorization_code; }
        set { authorization_code = value; }
    }
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    private short status_detail;

    public short Status_detail
    {
        get { return status_detail; }
        set { status_detail = value; }
    }

}