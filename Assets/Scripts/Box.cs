using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float jumpForce;
    public bool isUp;

    public int health = 5;

    public Animator anim;
    public GameObject effect;

    private void Update()
    {
        if(health <= 0)
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(transform.parent.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) // Collision retorna o objeto o qual bateu no item.
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(isUp)
            {
                anim.SetTrigger("hit");
                health --;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            } else
            {
                anim.SetTrigger("hit");
                health--;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -jumpForce), ForceMode2D.Impulse);
            }
        }
    }
}
