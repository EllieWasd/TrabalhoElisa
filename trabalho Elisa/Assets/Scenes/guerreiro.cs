using UnityEngine;

public class Guerreiro : Personagem
{
    [SerializeField]
    private string arma;
    [SerializeField]
    private string armadura;
    [SerializeField]
    private string habilidadeEspecial;
    public Guerreiro(string nome, int nivel, int vida, int forca)
        : base(nome, nivel, vida, forca)
    {
        this.arma = "Machadão";
        this.armadura = "Armadura Pesada";
        this.habilidadeEspecial = "Machadada";
    }

    // Getters específicos do Guerreiro
    public string GetArma() { return arma; }
    public string GetArmadura() { return armadura; }
    public string GetHabilidadeEspecial() { return habilidadeEspecial; }
}