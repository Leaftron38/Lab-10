using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int DireccionX;
    public int DireccionY;
    public float Velocity;
    public Transform _transform;
    private SpriteRenderer _rendender2D;
    void Awake()
    {
        
        _transform = GetComponent<Transform>();
        _rendender2D = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(_transform.position.x + Velocity * DireccionX * Time.deltaTime, _transform.position.y + Velocity * DireccionY * Time.deltaTime);
        if (_transform.position.x >= 29.9 )
        {
            DireccionX= -1;
            _rendender2D.flipX = true;
           
        }
        else if(_transform.position.y >= 18.3)
        {
           
            DireccionY = -1;
            _rendender2D.flipY = true;
        }
        if (_transform.position.x <= -29.9 )
        {
            DireccionX = 1;
            _rendender2D.flipX = false;
        }
        else if(_transform.position.y <= -18.3)
        {
           
            DireccionY = 1;
            _rendender2D.flipY = false;
        }
    }
}
