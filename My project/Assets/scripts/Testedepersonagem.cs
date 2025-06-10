using UnityEngine;



public class TestePersonagem : MonoBehaviour
{
    public Guerreiro guerreiro1;
    public Guerreiro guerreiro2;

    void Start()
    {
        // Inicializando dados
        guerreiro1 = new Guerreiro();
        guerreiro1.SetNome("Arthur");
        guerreiro1.SetNivel(5);
        guerreiro1.SetForca(20);
        guerreiro1.SetVida(100);
        guerreiro1.SetArma("Espada Longa");

        guerreiro2 = new Guerreiro();
        guerreiro2.SetNome("Lancelot");
        guerreiro2.SetNivel(4);
        guerreiro2.SetForca(18);
        guerreiro2.SetVida(95);
        guerreiro2.SetArma("Machado de Guerra");

        // Testando métodos
        Debug.Log($"Personagem 1: {guerreiro1.GetNome()}, Força: {guerreiro1.GetForca()}, Arma: {guerreiro1.GetArma()}");
        Debug.Log($"Personagem 2: {guerreiro2.GetNome()}, Força: {guerreiro2.GetForca()}, Arma: {guerreiro2.GetArma()}");

        Debug.Log(guerreiro1.CompararForca(guerreiro2));

        guerreiro1.Atacar();
        guerreiro2.Atacar();
    }
}
