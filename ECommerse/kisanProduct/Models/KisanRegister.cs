namespace kisranCart;

public class KisanRegister{

    public string Email{get;set;}
    public string Password{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Address{get;set;}

    public string ContactNo{get;set;}

    public KisanRegister(){

    }
    public KisanRegister(string FirstName,string LastName,string Address,string Password,string Email,string ContactNo){
        this.Email=Email;
        this.Password=Password;
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.ContactNo=ContactNo;
    }
    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3},{4}",Email,Password,FirstName,LastName,ContactNo);
    }
    public KisanRegister(string Email,string Password){
        this.Email=Email;
        this.Password=Password;
    }
    public override bool Equals(Object anotherObj){
//      Vehicle obj2=(Vehicle)obVehicle;
        KisanRegister obj2=(KisanRegister)anotherObj;
        return this.Email.Equals((obj2).Email);

    }
    

}