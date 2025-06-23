using UnityEngine;

public class Guerreiro : Personagem
{
    [SerializeField]
    private string arma;
    [SerializeField]
    private string armadura;
    [SerializeField]
    private string habilidadeEspecial;

    public Guerreiro(string nome, int nivel, int vida, int forca) : base(nome, nivel, vida, forca)
    {
        this.arma = "Machadão";
        this.armadura = "Armadura Pesada";
        this.habilidadeEspecial = "Machadada";
    }

    public string GetArma() { return arma; }
    public string GetArmadura() { return armadura; }
    public string GetHabilidadeEspecial() { return habilidadeEspecial; }
    
    public void FalarCom(Personagem outro)
    {
        Debug.Log($"{GetNome()}: Opa, bão?");
        
        
        if ( outro is Urso  )
        {
            Urso urso = (Urso)outro;
        }
        else
        {
            Debug.Log($"{outro.GetNome()}: E o tempo, hein? Uma loucura");
        }
    }
}