using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private State state;

    [SerializeField] private bool isPlayer1DoneSelecting;
    [SerializeField] private bool isPlayer2DoneSelecting;
    [SerializeField] private bool isAttackDone;
    [SerializeField] private bool isDamagingDone;
    [SerializeField] private bool isReturningDone;
    [SerializeField] private bool isPlayerEliminated;

    //[SerializeField] Player player1;
    //[SerializeField] Player player2;

    enum State
    {
        Preparation,
        Player1Select,
        Player2Select,
        Attacking,
        Damaging,
        Returning,
        BattleOver
    }

    private void Update()
    {
        switch (state)
        {
            case State.Preparation:
                // Player prepares
                // Set player 1 play first
                state = State.Player1Select;
                break;

            case State.Player1Select:
                if(isPlayer1DoneSelecting)
                {
                // set player 2 play next
                    state = State.Player2Select;
                }
                break;

            case State.Player2Select:
                if(isPlayer2DoneSelecting)
                {
                // set player 1 and player 2 attack
                    state = State.Attacking;
                }
                break;

            case State.Attacking:
                if(isAttackDone)
                {
                // calculate who take damage
                // start damage animation
                        state = State.Damaging;
                }
                break;

            case State.Damaging:
                if(isDamagingDone)
                {
                    state = State.Returning;
                }
                break;

            case State.Returning:
                if(isReturningDone)
                {
                    if(isPlayerEliminated)
                        state = State.BattleOver;
                    else
                        state = State.Preparation;
                }
                break;

            case State.BattleOver:
                break;
        }
    }
}
