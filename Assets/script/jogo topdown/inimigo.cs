using Unity.VisualScripting;
using UnityEngine;

public class inimigo : personagem
{
    [SerializeField] private int dano = 1;

    public float raioDeVisão = 1;
    public CircleCollider2D _visaoCollider2D;
    
    [SerializeField] private Transform posicaoPlayer;
    
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private bool andando= false;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        if (posicaoPlayer == null)
        {
            posicaoPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        }

        raioDeVisão = _visaoCollider2D.radius;
        
    }

    
    void Update()
    {
        andando = false;

        if (Getvidas() > 0)
        {
            if (posicaoPlayer.position.x - transform.position.x > 0)
            {
                spriteRenderer.flipX = false;
            }

            if (posicaoPlayer.position.x - transform.position.x < 0)
            {
                spriteRenderer.flipX = true;
            }

            if (posicaoPlayer != null && Vector3.Distance(posicaoPlayer.position, transform.position) <= raioDeVisão)
            {
                Debug.Log("No raio de visão: " + posicaoPlayer.position);
                
                transform.position = Vector3.MoveTowards(transform.position, posicaoPlayer.transform.position,GetVelocidade()* Time.deltaTime);
                
                andando = true;
            }
        }

        if (Getvidas() <= 0)
        {
            animator.SetTrigger("Morte");
        }
        animator.SetBool("Andando",andando);
    }

    public void desative()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Getvidas() > 0)
        {
            int novaVida = collision.gameObject.GetComponent<personagem>().Getvidas() - getDano();
            collision.gameObject.GetComponent<personagem>().Setvidas(novaVida);
            
            
        }
    }
}
