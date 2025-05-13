using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public float moveIncrement = 0.1f; // �������� ����������� �� ����
    public float rotationSpeed = 90f; // �������� �������� � �������� � �������

    // Update is called once per frame
    void Update()
    {        
        if (transform.position.y > 0) // ���������, ��������� �� ������ ���� ���� �� ��� Y
        {            
            float moveAmount = Mathf.Min(moveIncrement, transform.position.y); // ���������, ��������� �� ����� ����������� ������ ����, �� ������� ��� ���� ����
                        
            transform.Translate(0, -moveAmount, 0); // ���������� ������ ���� �� ��� Y                      
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); // ������� ������
        }
    }

}
