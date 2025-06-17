using UnityEngine;

[System.Serializable]
public class Personagem :MonoBehaviour
{
    // Atributos básicos
    public string nome;
    public int nivel;
    public int forca;
    public int vida;

    // Getters e Setters
    public string GetNome() => nome;
    public void SetNome(string valor) => nome = valor;

    public int GetNivel() => nivel;
    public void SetNivel(int valor) => nivel = valor;

    public int GetForca() => forca;
    public void SetForca(int valor) => forca = valor;

    public int GetVida() => vida;
    public void SetVida(int valor) => vida = valor;

    // Método de comparação entre personagens
    public string CompararForca(Personagem outro)
    {
        if (this.forca > outro.forca)
            return $"{this.nome} é mais forte que {outro.nome}.";
        else if (this.forca < outro.forca)
            return $"{outro.nome} é mais forte que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} têm a mesma força.";
    }
}