using UnityEngine;
using Variables;

public class Operators : MonoBehaviour
{
    // Arithmetic Operators
    int sum = myInteger + 4; // Addition
    float diff = myDecimal - 0.25f; // Subtraction
    int prod = myInteger * 2; // Multiplication
    int quot = myInteger / 5; // Division
    int mod = myInteger % 3; // Modulus
    int incr = myInteger++; // Increment
    int decr = myInteger--; // Decrement

    // Concatenation
    string newText = myText + " This is concatenation!";

    // Comparison Operators
    bool eq = myInteger == 5; // True if equal
    bool ne = myInteger != 7; // True if not equal
    bool gt = myInteger > 3; // True if greater than
    bool lt = myInteger < 10; // True if less than
    bool ge = myInteger >= 1; // True if greater than or equal
    bool le = myInteger <= 5; // True if less than or equal
}