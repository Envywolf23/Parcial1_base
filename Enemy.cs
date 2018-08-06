using System;

namespace Parcial1_logic.OOP
{
    public class Enemy : Actor
    {
       Actor(1,1,true);

        public override MovementType Move(MovementType Movimiento)
        {

            MovementType resultado = new MovementType();

            resultado = MovementType.AI;

            Console.WriteLine("Mi movimiento es = " + resultado);

            return resultado;



        }



    }
}