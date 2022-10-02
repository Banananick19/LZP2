namespace LPZ1;

public interface IDateAndCopy
{
    object DeepCopy();
    DateTime Date { get; set; }
}