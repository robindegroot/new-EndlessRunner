using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MovementScript : MonoBehaviour
{

    private Vector3 movement;
    private Rigidbody rigidBody;
    public float speed;
    public float jumpSpeed;
    public bool isJumping = false;
    public float x;
    public float z;
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        speed += .1f * Time.fixedDeltaTime;
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        movement = transform.forward.normalized;
		if (transform.position.y <= -10) 
		{
			SceneManager.LoadScene("GameOver");
		}


        if (Input.GetKeyDown("space"))
        {
            if (isJumping == false)
            {
                rigidBody.AddForce(0, jumpSpeed, 0);
                isJumping = true;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(col.gameObject, 2);
            isJumping = false;
        }
    }

    void FixedUpdate()
    {
        rigidBody.rotation = Quaternion.Euler(rigidBody.rotation.eulerAngles + new Vector3(0f, x, 0f));
        Vector3 velocity = movement * speed * Time.fixedDeltaTime;
        rigidBody.MovePosition(rigidBody.position + velocity);
        rigidBody.AddForce(0f, -10f, 0f);
    }
}