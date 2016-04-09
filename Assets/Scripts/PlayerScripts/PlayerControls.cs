using UnityEngine;

public class PlayerControls : MonoBehaviour {

    private float maxSpeed = 5f;
    private float jumpForce = 250f;

    private bool grounded = false;
    public Transform groundCheck;
    private float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    private bool hasAirJumped = false;

    private Rigidbody2D rb2d;

	// Use this for initialization.
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// FixedUpdate is called every Fixed Update.
	void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        float move = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);
    }

    // Update is called once per frame.
    void Update () {

        if (grounded)
        {
            hasAirJumped = false;
        }

        if (grounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        else if (Input.GetButtonDown("Jump") && !hasAirJumped && !grounded)
        {
            Jump();
            hasAirJumped = true;
        }
    }

    void Jump () {
        rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        rb2d.AddForce(new Vector2(0, jumpForce));
    }
}
