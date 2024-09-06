using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab;
    List<BallPrefab> balls = new List<BallPrefab>();
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Touchscreen.current.press.isPressed) {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            float delay = 1.0f;
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward *UnityEngine.Random.Range(500, 750));
            balls.Add(ball);
            Object.Destroy(ball, delay);
        }
        
    }
}
