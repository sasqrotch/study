using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject objectToToggle;
    public Button toggleButton;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleObject);
    }

    void ToggleObject()
    {
        objectToToggle.SetActive(!objectToToggle.activeSelf);

        // Вывод состояния объекта в консоль для дебага
        Debug.Log("Object is active: " + objectToToggle.activeSelf);
    }
}
