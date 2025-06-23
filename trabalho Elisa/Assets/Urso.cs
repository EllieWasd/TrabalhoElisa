using UnityEngine;

public class Urso : Personagem
{
 
        [SerializeField]
        private string patada;
        [SerializeField]
        private string defesaDoPelo;
        [SerializeField]
        private string habilidadeEspecial;

        public Urso(string nome, int nivel, int vida, int forca) : base(nome, nivel, vida, forca)
        {
            this.patada = "Garras Mortais";
            this.defesaDoPelo = "Couro Duro";
            this.habilidadeEspecial = "Mordidona";
        }

        public string Getpatada() { return this.patada; }
        public string GetdefesaDoPelo() { return this.defesaDoPelo; }
        public string GetHabilidadeEspecial() { return habilidadeEspecial; }
        
        public void Responder()
        {
            
            Debug.Log($"{GetNome()}: Oxe, tá falando com urso, mano? Tá ficando doido?");
            
        }
        
}

