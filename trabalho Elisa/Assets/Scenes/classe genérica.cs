using UnityEngine;

public class Personagem
{
    private string nome;
    private int nivel;
    private int vida;
    private int forca;
    
    public Personagem(string nome, int nivel, int vida, int forca)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.vida = vida;
        this.forca = forca;
    }

  
    public string GetNome() { return nome; }
    public void SetNome(string nome) { this.nome = nome; }

    public int GetNivel() { return nivel; }
    public void SetNivel(int nivel) { this.nivel = nivel; }

    public int GetVida() { return vida; }
    public void SetVida(int vida) { this.vida = vida; }

    public int GetForca() { return forca; }
    public void SetForca(int forca) { this.forca = forca; }

  
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