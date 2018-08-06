namespace Parcial1_logic.OOP
{
    public abstract class Gear
    {
        private int paramMod;
        private bool esArmadura;
        private bool esArma;

        public int ParamMod { get => paramMod; set => paramMod = value; }
        public bool EsArmadura { get => esArmadura; set => esArmadura = value; }
        public bool EsArma { get => esArma; set => esArma = value; }

        public Gear()
        {
            esArmadura = true;
        }

        public Gear(bool EsArma)
        {
            if (EsArma == true)
            {
                esArma = true;
            }
        }

    }
}