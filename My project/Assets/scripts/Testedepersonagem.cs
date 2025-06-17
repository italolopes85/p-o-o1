using UnityEngine;



public class TestePersonagem : MonoBehaviour
{
    public Caçador caçador1;
    public Caçador caçador2;

    void Start()
    {
   
        caçador1 = new Caçador();
        caçador1.SetNome("Arthur");
        caçador1.SetNivel(5);
        caçador1.SetForca(20);
        caçador1.SetVida(100);
        caçador1.SetArma("Espada Longa");

        caçador2 = new Caçador();
        caçador2.SetNome("Lancelot");
        caçador2.SetNivel(4);
        caçador2.SetForca(18);
        caçador2.SetVida(95);
        caçador2.SetArma("Machado de Guerra");

        
        Debug.Log($"Personagem 1: {caçador1.GetNome()}, Força: {caçador1.GetForca()}, Arma: {caçador1.GetArma()}");
        Debug.Log($"Personagem 2: {caçador2.GetNome()}, Força: {caçador2.GetForca()}, Arma: {caçador1.GetArma()}");

        Debug.Log(caçador1.CompararForca(caçador2));

        caçador1.Atacar();
        caçador2.Atacar();
    }
}
