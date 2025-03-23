using UnityEngine;

public class Constants
{
    // ******* AssetReference *******   

    public static string AssetReferenceParameter = "Parameter";
    public static string AssetReferencePlayer = "Player";
    public static string AssetReferenceEnemy = "Enemy";

    // ******* Player *******

    public static float PlayerMoveSpeed = 1.5f;

    // ******* Enemy *******

    // ******* Field *******

    public static Vector3 FieldCornerDownLeft = new Vector3(-7, -7, 0);
    public static Vector3 FieldCornerUpRight = new Vector3(8, 8, 0);
    public static Vector3 PlayerSpownPosition = new Vector3(-7, -7, 0);

    // ******* Battle *******
    public static int MaxTurn = 20;

    public static string GetSentenceWhenStartBattle(string language, string entityName)
    {
        switch (language)
        {
            case "Japanese":
                return string.Format("{0}�����ꂽ!", entityName);
            case "English":
                return string.Format("{0} Appeared!", entityName);
            default:
                return string.Format("{0} Appeared!", entityName);
        }
    }

    public static string GetSentenceWhileWaitingAction(string language, string entityName)
    {
        switch (language)
        {
            case "Japanese":
                return string.Format("{0}�̍s����҂��Ă���...", entityName);
            case "English":
                return string.Format("{0} should take an action...", entityName);
            default:
                return string.Format("{0} should take an action...", entityName);
        }
    }

    public static string GetAttackSentence(Language language, string entityName)
    {
        switch (language)
        {
            case Language.Japanese:
                return string.Format("{0}�̍U���I", entityName);
            case Language.English:
                return string.Format("{0} is Attacking!", entityName);
            default:
                return string.Format("{0} is Attacking!", entityName);
        }
    }

    public static string GetSkillSentence(Language language, string entityName, string skillName)
    {
        switch (language)
        {
            case Language.Japanese:
                return string.Format("{0}��{1}", entityName, skillName);
            case Language.English:
                return string.Format("{0} is using {1}", entityName, skillName);
            default:
                return string.Format("{0} is using {1}", entityName, skillName);
        }
    }

    public static string GetResultSentence(Language language, string winner, string loser)
    {
        switch (language)
        {
            case Language.Japanese:
                return string.Format("{0}��{1}��|����!", winner, loser);
            case Language.English:
                return string.Format("{0} beat {1}!", winner, loser);
            default:
                return string.Format("{0} beat {1}!", winner, loser);
        }
    }

    public static string GetSentenceWhenBothDied(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "���ғ|��Ă��܂����I";
            case Language.English:
                return "Both died!";
            default:
                return "Both died!";
        }
    }

    public static string GetSentenceWhenTurnOver(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "���̐킢�ɂ͌��������������ɂȂ�.....";
            case Language.English:
                return "This battle seems to be endless.....";
            default:
                return "This battle seems to be endless.....";
        }
    }

    public static string GetSkillGetSentence(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "{0}��{1}���擾����!";
            case Language.English:
                return "{0} has learned {1}!";
            default:
                return "This battle seems to be endless.....";
        }
    }
    // ******* RewordResult *******
    public static string GetHitPointSentence(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "{0}��{1}HP�񕜂���!";
            case Language.English:
                return "{0} has healed {1}HP!";
            default:
                return "This battle seems to be endless.....";
        }
    }
    public static string GetManaSentence(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "{0}��{1}MP�⋋����!";
            case Language.English:
                return "{0} has refreshed {1}MagicPoint!";
            default:
                return "This battle seems to be endless.....";
        }
    }
    public static string GetPowerSentence(Language language)
    {
        switch (language)
        {
            case Language.Japanese:
                return "{0}��{1}���擾����!";
            case Language.English:
                return "{0} has learned {1}!";
            default:
                return "This battle seems to be endless.....";
        }
    }
    // ******* SkillCaption *******
    public static string GetSkillCaption(string skillName)
    {
        switch (skillName)
        {
            case "�q�[��":
                return HealCaption;
            case "���݂�":
                return "Bite";
            default:
                return "Unknown";
        }
    }
    public static string HealCaption = "Heal";
}
