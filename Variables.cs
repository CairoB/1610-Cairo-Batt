using UnitiyEngine;

public class Variables : ScriptableObject
{
    int myInteger = 5;                  // Integer; negative or positive
    float myDecimal = 2.75f;            // Decimal number; negative or positive
    double myAccurateDecimal = 0.99D;   // Decimal number; uses double the storage of float
    char myCharacter = 'Z';             // Single letter, symbol, or number character
    bool myBoolean = true;              // True/False, Off/On, etc.
    string myText = "Hello world!";     // String of characters; text
}