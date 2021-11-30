using UnityEngine;

public class DeathState : BaseState
{
    [SerializeField] private Vector3 knockBackForce = new Vector3(0, 4, -3);
    private Vector3 currentKnockback;


    public override void Construct()
    {
        tiagoMotor.animator?.SetTrigger("Death");
        currentKnockback = knockBackForce;
    }

    public override Vector3 ProcessMotion()
    {
        //Vector3 movement = knockBackForce;

        currentKnockback = new Vector3(
            0,
            currentKnockback.y *= tiagoMotor.gravity * Time.deltaTime,
            currentKnockback.z += 2.0f * Time.deltaTime
            );

        if (currentKnockback.z > 0)
        {
            currentKnockback.z = 0;
            GameManager._Instance.ChangeState(GameManager._Instance.GetComponent<GameStateDeath>());
        }

        return currentKnockback;
    }
}
