https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts
link naar code opdracht 1 tot 8 van m5


Opdracht 1:
https://github.com/user-attachments/assets/fc570e56-5afc-47a7-8f29-d49c7fa108b1


Opdracht 2:
https://github.com/user-attachments/assets/471ceeaa-5aa6-43fe-9f2d-7d84fa44ee16


Opdracht 3
https://github.com/user-attachments/assets/571edef1-1467-483d-81e5-003530153ec3


Opdracht 4
https://github.com/user-attachments/assets/82e03cbd-e30a-49be-bb23-6e224410fb00


Opdracht 6
https://github.com/user-attachments/assets/3533ea70-7932-4032-a591-51de4cf0907b


Opdracht 7
https://github.com/user-attachments/assets/80aae191-8aa4-4048-b319-8afd82a75260

opdracht 8
https://github.com/user-attachments/assets/a9348947-4e74-4d90-a8e3-84fe87702df1

M6 -----------------------------------------------------------------------------

Opdracht 1

https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts/m6/Opdracht%201%20M6
![m6op1](https://github.com/user-attachments/assets/eaf93e60-8fb2-4948-9f9d-0cd16905c1ec)

opdracht 2

https://github.com/MarcosMartinsCarvalho/progM5-6/blob/main/ClassDiagramTD.md


opdracht 3
https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts/m6/opdracht%203
![m6op3](https://github.com/user-attachments/assets/40ad62fd-9bb2-4026-bd32-8826107a4188)


opdracht 4
https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts/m6/opdracht%204
![m6op4](https://github.com/user-attachments/assets/27c93be4-e0e0-4630-b6a4-1d7f51ed9703)

opdracht 5
https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts/m6/opdracht%205
![m6op5](https://github.com/user-attachments/assets/dc202bcf-0525-4c1f-b5eb-6a239f0f8070)


opdracht 6
https://github.com/MarcosMartinsCarvalho/progM5-6/tree/main/progm5/Assets/scripts/m6/opdracht%206
![m6op6](https://github.com/user-attachments/assets/f080fbf9-ab92-445c-b349-972240b08882)


## Les 7 – Early Return Patterns

```csharp
public bool IsPlayerReadyToAttack(Player player)
{
    if (player == null) return false;
    if (!player.IsAlive) return false;
    if (player.AttackCooldown > 0) return false;
    if (player.Target == null) return false;
    if (!player.Target.IsAlive) return false;
    if (Vector3.Distance(player.transform.position, player.Target.transform.position) >= 5f) return false;

    bool hasRequirements =
        (player.Mana >= 20 && player.WeaponEquipped) ||
        (player.Health > 30 && player.HasBuff("Strength"));

    if (!hasRequirements) return false;
    if (player.IsStunned) return false;
    if (player.IsSlowed) return false;

    return true;
}





