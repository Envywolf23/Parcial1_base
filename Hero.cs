namespace Parcial1_logic.OOP
{
    public class Hero : Actor
    {


        public  Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }
        


        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public void Equip(Gear ObjetoEquipado)
        {
            if(ObjetoEquipado.)
            {
            }
        }

        public override MovementType Move(MovementType Movimiento)
        {
            MovementType resultado = new MovementType();

            Movimiento = MovementType.Input;

            resultado = Movimiento;

            return resultado;
        }

        public int GetCurrentAtk()
        {
            int resultado = new int();

            resultado = BaseAtk * CurrentWeapon.ParamMod;

            return resultado;


        }

        public int GetCurrentDef()
        {
            int resultado = new int();

            resultado = BaseDef * CurrentArmor.ParamMod;

            return resultado;


        }


    }
}