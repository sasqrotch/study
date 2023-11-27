using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject objectToToggle;
    public Button toggleButton;

    public Text counterText;
    public int counter = 10;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleObject);
    }

    void ToggleObject()
    {
        objectToToggle.SetActive(!objectToToggle.activeSelf);
        Debug.Log("Object is active: " + objectToToggle.activeSelf);
    }

    // ��������� ����� ����� ��� ��������� ������������
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            // ��������� ������� ��� ������������ � otherObject
            counter--;
            // ��������� ����� �� ������
            counterText.text = "Counter: " + counter;
        }
    }
}