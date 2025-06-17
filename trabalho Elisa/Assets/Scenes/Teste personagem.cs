using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        // Criando um personagem genérico
        Personagem generico = new Personagem("João Paulo", 2, 50, 10);

        // Criando um guerreiro
        Guerreiro guerreiro = new Guerreiro("Brutus Grandalhão grandão", 5, 120, 18);

        // Debugando informações do personagem genérico
        Debug.Log("Personagem Genérico:");
        Debug.Log($"Nome: {generico.GetNome()}");
        Debug.Log($"Nível: {generico.GetNivel()}");
        Debug.Log($"Vida: {generico.GetVida()}");
        Debug.Log($"Força: {generico.GetForca()}");

        // Debugando informações do guerreiro
        Debug.Log("Guerreiro:");
        Debug.Log($"Nome: {guerreiro.GetNome()}");
        Debug.Log($"Nível: {guerreiro.GetNivel()}");
        Debug.Log($"Vida: {guerreiro.GetVida()}");
        Debug.Log($"Força: {guerreiro.GetForca()}");
        Debug.Log($"Arma: {guerreiro.GetArma()}");
        Debug.Log($"Armadura: {guerreiro.GetArmadura()}");
        Debug.Log($"Habilidade Especial: {guerreiro.GetHabilidadeEspecial()}");

        // Comparando força entre os personagens
        Debug.Log(guerreiro.CompararForca(generico));
    }
}