using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 100f;
    [SerializeField] float screenWidthInUnits = 100f;

    // Update is called once per frame
    void Update()
    {
        float mouseposinunits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mouseposinunits, minX, maxX);
        transform.position = paddlepos;
    }
}