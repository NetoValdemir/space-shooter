using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private Animator playerAnimator;

    public float velocidade;
    private int direcao;

    public Transform arma;
    public GameObject tiroPrefab;
    public float forcaTiro;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            atirar();
        }
    }
    void FixedUpdate()
    {
        float movimentoX = Input.GetAxis("Horizontal");
        if (movimentoX < 0)
        {
            direcao = -1;
        }
        else if (movimentoX == 0)
        {
            direcao = 0;
        }
        else if (movimentoX > 0)
        {
            direcao = 1;
        }
        float movimentoY = Input.GetAxis("Vertical");
        playerRb.velocity = new Vector2(movimentoX * velocidade, movimentoY * velocidade);

        playerAnimator.SetInteger("direcao", direcao);

    }

    void atirar()
    {
        GameObject tempPrefab = Instantiate(tiroPrefab) as GameObject;
        tempPrefab.transform.position = arma.position;
        tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forcaTiro));
    }
}
