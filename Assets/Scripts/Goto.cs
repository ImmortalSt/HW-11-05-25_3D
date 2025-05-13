using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public float moveIncrement = 0.1f; // Интервал перемещения за кадр
    public float rotationSpeed = 90f; // Скорость вращения в градусах в секунду

    // Update is called once per frame
    void Update()
    {        
        if (transform.position.y > 0) // Проверяем, находится ли объект выше нуля по оси Y
        {            
            float moveAmount = Mathf.Min(moveIncrement, transform.position.y); // Вычисляем, насколько мы можем переместить объект вниз, не опуская его ниже нуля
                        
            transform.Translate(0, -moveAmount, 0); // Перемещаем объект вниз по оси Y                      
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); // Вращаем объект
        }
    }

}
