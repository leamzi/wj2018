using UnityEngine;
using Utils;

namespace Player
{
    public class PlayerMovement : PhysicsObject
    {
        public float maxSpeed = 7;
        public float jumpTakeOffSpeed = 7;
        public int status;
        public SpriteRenderer spriteRenderer;
        //private Animator animator;

        // Use this for initialization
        void Awake()
        {
            status = 0;
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
   

        protected override void ComputeVelocity()
        {
            Vector2 move = Vector2.zero;

            move.x = Input.GetAxis("Horizontal");

            if (grounded && move.x != 0)
                status = 1;
            else if (grounded && move.x == 0)
                status = 0;

            if (Input.GetButtonDown("Jump") && grounded)
            {
                velocity.y = jumpTakeOffSpeed;
                status = 2;
                gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("jumped");
            }
            //else if (Input.GetButtonUp("Jump"))
            //{
            //    if (velocity.y > 0)
            //    {
            //        velocity.y = velocity.y * 0.5f;
            //        status = 2;
            //        Debug.Log("Jumped");
            //    }
            //}

            //bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
            //if (flipSprite)
            //{
            //    spriteRenderer.flipX = !spriteRenderer.flipX;
            //}

            //animator.SetBool("grounded", grounded);
            //animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

            targetVelocity = move * maxSpeed;
        }

    }
}

