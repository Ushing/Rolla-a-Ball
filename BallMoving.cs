using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BallMoving : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private float Speed = 10.0f;

    public GameObject Boom;

    public JoyStick Movejoystick;

    public static int NumberofCounts;
    public Text CountText;
    public RectTransform Win,GameOver;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        NumberofCounts = 0;
    }
    private void Update()
    {
      
        horizontalInput = Movejoystick.Horizontal();
        verticalInput = Movejoystick.Vertical();
        CountText.text = "Count: " + NumberofCounts +" / 7";
        if(NumberofCounts == 7)
        {
            Win.DOAnchorPos(Vector2.zero, 0.60f);
        }
    }
    public void FixedUpdate()
    {
     
        rb.AddForce(new Vector3(horizontalInput,0,verticalInput) * Speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boom")
        {
            Destroy(gameObject);
            GameOver.DOAnchorPos(Vector2.zero, 0.60f);
        }
    }
}
