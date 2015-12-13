using UnityEngine;
using System.Collections;

public class CheshireControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = true;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 100f;
	//float move;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool("Ground", grounded);

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		//anim.SetFloat("Speed", Mathf.Abs(move));	
		
		// Moves the character left & right
		float move = Input.GetAxis ("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2(move *maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if(move > 0 &&!facingRight)
			Flip ();
		else if(move < 0 && facingRight)
			Flip ();
	}

	void Update ()
	{
		if(grounded && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector3(0, jumpForce, 0));

		}
	}

	void Flip() 
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
