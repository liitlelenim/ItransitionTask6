namespace ItransitionTask6;

public class PersonModel
{
    public int Index { get; set; }
    public int RandomIdentifier { get; set; }
    public string FullName { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
 }

public enum Region
{
    Poland,
    Germany,
    UnitedStates
}