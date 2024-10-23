using NavKeypad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractionFPV : MonoBehaviour
{
    private void OnEnable()
    {
        foreach (var keypadButton in GetComponentsInChildren<KeypadButton>())
        {
            keypadButton.OnButtonPressed.AddListener(PressButton);
        }
    }

    private void OnDisable()
    {
        foreach (var keypadButton in GetComponentsInChildren<KeypadButton>())
        {
            keypadButton.OnButtonPressed.RemoveListener(PressButton);
        }
    }

    private void PressButton(KeypadButton button)
    {
        button.PressButton();
    }
}
