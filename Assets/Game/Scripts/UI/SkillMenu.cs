using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillMenu : MonoBehaviour
{
    private string disc1 = "Đạn bắn ra với tốc độ nhanh hơn, tốc độ di chuyển của nhân vật cũng nhanh hơn.";
    private string disc2 = "Tăng số lượng đạn tối đa có thể bắn trước khi nạp đạn cho lần bắn kế tiếp, giảm thời gian nạp đạn";
    private string disc3 = "Trong 3s, bắn ra tối đa 16 viên";
    private string disc4 = "Gọi đến 1 viên thiên thạch siêu to, tiêu diệt tất cả trừ player";
    public int indexOfChoosedSkill;
    public TextMeshProUGUI discription;
    public void Skill1_SpeedUp()
    {
        discription.text = disc1;
        indexOfChoosedSkill = 0;
    }
    public void Skill2_GunUp()
    {
        discription.text = disc2;
        indexOfChoosedSkill = 1;
    }
    public void Skill3_BulletUp()
    {
        discription.text = disc3;
        indexOfChoosedSkill = 2;
    }
    public void Skill4_Meteorite()
    {
        discription.text = disc4;
        indexOfChoosedSkill = 3;
    }
    public void ChooseButton()
    {
        indexOfChoosedSkill += 1;
        Debug.Log("Choose " + indexOfChoosedSkill);
    }
}
