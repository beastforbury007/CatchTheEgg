using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Camera camera;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        Vector2 position = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 targetPosition = new Vector2(position.x, 0f);

        Vector2 clampedPosition = targetPosition;
        clampedPosition.x = Mathf.Clamp(targetPosition.x, -7.16f, 7.16f);
        targetPosition = clampedPosition;

        rb.MovePosition(targetPosition);
    }
    
}
