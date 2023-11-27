using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionCounter : MonoBehaviour
{
    public int counter = 5; // ������� ������������
    public Text counterText; // ������ �� ��������� ������
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OtherObject")
        {
            counter--;
            UpdateCounterText();
        }
    }

    void UpdateCounterText()
    {
        counterText.text = "Counter: " + counter;
    }
}
