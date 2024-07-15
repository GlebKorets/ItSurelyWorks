using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrintInputToConsole : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button printButton;

    void Start()
    {
        printButton.onClick.AddListener(PrintToConsole);
    }

    void PrintToConsole()
    {
        string userInput = inputField.text;
        Debug.Log(userInput);
    }
}
