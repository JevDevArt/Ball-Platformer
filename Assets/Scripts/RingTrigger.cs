using System.Collections;
using UnityEngine;

public class RingTrigger : MonoBehaviour
{
    private AudioSource m_AudioSource;
    private Animator animator;
    private Collider2D objectCollider;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        objectCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objectCollider.enabled = false;
            m_AudioSource.Play();

            StartCoroutine(Delay());
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.9f);
        animator.Play("ring collected");
        Destroy(gameObject);
    }
}