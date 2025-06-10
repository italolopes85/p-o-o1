using UnityEngine;

[System.Serializable]
public class Caçador: Personagem
{
    public string arma;

    public string GetArma() => arma;
    public void SetArma(string valor) => arma = valor;

    public void Atacar()
    {
        Debug.Log($"{nome} ataca com a arma {arma} causando {forca} de dano.");
    }
}