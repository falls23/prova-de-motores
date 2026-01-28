using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private int dano = 1;
    [SerializeField] private float velocidade = 1.5f;
    
    private SpriteRenderer m_spriteRenderer;
    
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
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (!m_spriteRenderer.isVisible)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
          //causa dano no inimigo 
         int novaVida = colisao.gameObject.GetComponent<personagem>().Getvidas() - getDano();
       
         colisao.gameObject.GetComponent<personagem>().Setvidas(novaVida);       
        } 
       
         Destroy(this.gameObject);
    }
}
