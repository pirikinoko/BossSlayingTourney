using System.Collections.Generic;
using UnityEngine;

public class Reward
{
    public string Description { get; private set; }

    public delegate string StatusReword(Entity target);

    public StatusReword StatusRewordAction { get; private set; }

    public Reward()
    {
        SetRandomReword();
    }

    private void SetRandomReword()
    {
        // ��V�̌��ƂȂ�A�N�V�����Ɛ��������X�g�ɂ܂Ƃ߂�
        List<(StatusReword action, string description)> rewordActions = new List<(StatusReword, string)>
        {
            (IncreaseHealth, "HP��10�|�C���g��������"),
            (IncreaseMana, "MP��10�|�C���g��������"),
            (IncreasePower, "�U���͂�2�|�C���g��������")
        };

        // �����_���ɃC���f�b�N�X��I��
        int index = Random.Range(0, rewordActions.Count);

        // �I��������V���Z�b�g
        StatusRewordAction = rewordActions[index].action;
        Description = rewordActions[index].description;
    }

    private string IncreaseHealth(Entity target)
    {
        target.Parameter.HitPoint += 10;
        return $"{target.name}��HP��10�|�C���g���������I";
    }

    private string IncreaseMana(Entity target)
    {
        target.Parameter.ManaPoint += 10;
        return $"{target.name}��MP��10�|�C���g���������I";
    }

    private string IncreasePower(Entity target)
    {
        target.Parameter.Power += 1;
        return $"{target.name}�̍U���͂�2�|�C���g���������I";
    }

    public string Execute(Entity target)
    {
        return StatusRewordAction?.Invoke(target);
    }
}
