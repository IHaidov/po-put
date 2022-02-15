namespace PO_PRO.Classes
{
    public interface IPerson
    {
        string GetID();
        string getEmail();
        bool checkPassword(string pass);
        string getCredentials();

    }
}