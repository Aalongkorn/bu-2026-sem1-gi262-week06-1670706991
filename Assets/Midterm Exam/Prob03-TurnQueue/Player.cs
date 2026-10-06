using System.Collections.Generic;

public bool SwapQueue(LinkedList<Player> turnQueue, Player targetPlayer, Player afterPlayer)
{
    // 1) ตรวจค่าที่ไม่ถูกต้อง
    if (turnQueue == null || targetPlayer == null || afterPlayer == null)
        return false;

    // 2) ผู้เล่นคนเดียวกัน ย้ายไม่ได้
    if (targetPlayer == afterPlayer)
        return false;

    // 3) หาโหนดของทั้งสองคนในคิว
    LinkedListNode<Player> targetNode = turnQueue.Find(targetPlayer);
    LinkedListNode<Player> afterNode = turnQueue.Find(afterPlayer);

    if (targetNode == null || afterNode == null)
        return false;   // มีคนใดคนหนึ่งไม่อยู่ในคิว

    // 4) นำ targetPlayer ออกจากตำแหน่งเดิม แล้วแทรกต่อท้าย afterPlayer
    turnQueue.Remove(targetNode);
    turnQueue.AddAfter(afterNode, targetNode);

    return true;
}