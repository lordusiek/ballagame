using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformblock : MonoBehaviour
{
    [SerializeField] float minX = -330f;
    [SerializeField] float maxX = 330f;
    [SerializeField] float screenWidthInUnits = 596f;

    void Update()
    {
        float mouseposinunits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mouseposinunits, minX, maxX);
        transform.position = paddlepos;
    }
}
