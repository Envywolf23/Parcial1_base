using System;

namespace Parcial1_logic.OOP
{
    public abstract class Actor : ICharacter
    {

        private bool enable;
        private int baseAtk;
        private int baseDef;

        public bool Enable { get => enable; set => enable = value; }
        public int BaseAtk { get => baseAtk; set => baseAtk = value; }
        public int BaseDef { get => baseDef; set => baseDef = value; }

        public Actor(int Atk, int Def, bool enableAttack)
        {
            enable = false;
            baseAtk = Atk;
            baseDef = Def;
        }

        public void Ataque()
        {
            
        }

        public virtual MovementType Move(MovementType Movimiento)
        {
            MovementType resultado = new MovementType();

            resultado = Movimiento;

            Console.WriteLine("Mi movimiento es = " + resultado);

            return resultado;

            
        }

    
   
    }
}